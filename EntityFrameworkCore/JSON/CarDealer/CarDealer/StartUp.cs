using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Text;

namespace CarDealer
{
	public class StartUp
	{
		public static void Main()
		{
			using CarDealerContext context = new CarDealerContext();
			var supplierTxt = File.ReadAllText("../../../Datasets/sales.json");
			Console.WriteLine(GetSalesWithAppliedDiscount(context));
		}
		public static string ImportSuppliers(CarDealerContext context, string inputJson)
		{
			var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);
			context.Suppliers.AddRange(suppliers);
			context.SaveChanges();
			return $"Successfully imported {suppliers.Count}.";
		}
		public static string ImportParts(CarDealerContext context, string inputJson)
		{
			var parts = JsonConvert.DeserializeObject<List<Part>>(inputJson);
			parts.RemoveAll(p => !context.Suppliers.Any(s => s.Id == p.SupplierId));
			context.Parts.AddRange(parts);
			context.SaveChanges();
			return $"Successfully imported {parts.Count}.";
		}
		public static string ImportCars(CarDealerContext context, string inputJson)
		{
			var carsDtos = JsonConvert.DeserializeObject<List<ImportCarDto>>(inputJson);
			var cars = new HashSet<Car>();
			var partsCars = new HashSet<PartCar>();

			foreach (var carDto in carsDtos)
			{
				var newCar = new Car()
				{
					Make = carDto.Make,
					Model = carDto.Model,
					TraveledDistance = carDto.TraveledDistance,
				};
				cars.Add(newCar);
				foreach (var partId in carDto.PartsId.Distinct())
				{
					partsCars.Add(new PartCar()
					{
						Car = newCar,
						PartId = partId
					});
				}
			}
			context.Cars.AddRange(cars);
			context.PartsCars.AddRange(partsCars);

			context.SaveChanges();
			return $"Successfully imported {cars.Count}.";
		}
		public static string ImportCustomers(CarDealerContext context, string inputJson)
		{
			var customers = JsonConvert.DeserializeObject<List<Customer>>(inputJson);
			context.Customers.AddRange(customers);
			context.SaveChanges();
			return $"Successfully imported {customers.Count}.";
		}

		public static string ImportSales(CarDealerContext context, string inputJson)
		{
			var sales = JsonConvert.DeserializeObject<List<Sale>>(inputJson);
			context.Sales.AddRange(sales);
			context.SaveChanges();
			return $"Successfully imported {sales.Count}.";
		}
		public static string GetOrderedCustomers(CarDealerContext context)
		{
			var customers = context.Customers.OrderBy(c => c.BirthDate).ThenBy(c => c.IsYoungDriver).Select(c => new
			{
				c.Name,
				BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
				c.IsYoungDriver
			}).ToList();
			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				Formatting = Formatting.Indented,
			};

			return JsonConvert.SerializeObject(customers, settings);
		}
		public static string GetCarsFromMakeToyota(CarDealerContext context)
		{
			var cars = context.Cars.Where(c => c.Make == "Toyota").OrderBy(c => c.Model).ThenByDescending(c => c.TraveledDistance).Select(c => new
			{
				c.Id,
				c.Make,
				c.Model,
				c.TraveledDistance
			});

			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				Formatting = Formatting.Indented,
			};
			return JsonConvert.SerializeObject(cars, settings);
		}
		public static string GetLocalSuppliers(CarDealerContext context)
		{
			var suppliers = context.Suppliers.Where(s => s.IsImporter == false).Select(s => new
			{
				s.Id,
				s.Name,
				PartsCount = s.Parts.Count()
			}).ToList();
			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				Formatting = Formatting.Indented,
			};
			return JsonConvert.SerializeObject(suppliers, settings);
		}
		public static string GetCarsWithTheirListOfParts(CarDealerContext context)
		{
			var cars = context.Cars.Select(c => new
			{
				car = new
				{
					c.Make,
					c.Model,
					c.TraveledDistance,
				},
				parts = c.PartsCars.Select(pc => new
				{
					pc.Part.Name,
					Price = pc.Part.Price.ToString("f2")
				}).ToList()

			});
			var settings = new JsonSerializerSettings()
			{
				Formatting = Formatting.Indented,
			};

			return JsonConvert.SerializeObject(cars, settings);

		}
		public static string GetTotalSalesByCustomer(CarDealerContext context)
		{
			var customers = context.Customers.Where(c => c.Sales.Count > 0).Select(c => new
			{
				FullName = c.Name,
				BoughtCars = c.Sales.Count,
				SpentMoney = c.Sales.Sum(s => s.Car.PartsCars.Sum(pc => pc.Part.Price))
			}).OrderByDescending(x => x.SpentMoney)
				.ThenByDescending(x => x.BoughtCars).ToList();

			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				Formatting = Formatting.Indented,
			};

			return JsonConvert.SerializeObject(customers, settings);
		}
		public static string GetSalesWithAppliedDiscount(CarDealerContext context)
		{
			var sales = context.Sales.Take(10).Select(s => new
			{
				car = new
				{
					s.Car.Make,
					s.Car.Model,
					s.Car.TraveledDistance
				},
				customerName = s.Customer.Name,
				discount = s.Discount.ToString("f2"),
				price = s.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("f2"),
				priceWithDiscount = (s.Car.PartsCars.Sum(pc => pc.Part.Price) - (s.Discount*0.01m )* s.Car.PartsCars.Sum(pc => pc.Part.Price)).ToString("f2")
			}) ;

			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				Formatting = Formatting.Indented,
			};

			return JsonConvert.SerializeObject(sales, settings);
		}
	}
}