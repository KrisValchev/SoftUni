using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.Models;
using System.Text.Json;


namespace ProductShop
{
	public class StartUp
	{
		public static void Main()
		{
			using ProductShopContext context = new ProductShopContext();
			string userText = File.ReadAllText("../../../Datasets/categories-products.json");
			Console.WriteLine(GetUsersWithProducts(context));
		}
		public static string ImportUsers(ProductShopContext context, string inputJson)
		{
			var users = JsonConvert.DeserializeObject<List<User>>(inputJson);
			context.Users.AddRange(users);
			context.SaveChanges();
			return $"Successfully imported {users.Count}";
		}
		public static string ImportProducts(ProductShopContext context, string inputJson)
		{
			var products = JsonConvert.DeserializeObject<List<Product>>(inputJson);
			context.Products.AddRange(products);
			context.SaveChanges();
			return $"Successfully imported {products.Count}";
		}
		public static string ImportCategories(ProductShopContext context, string inputJson)
		{
			var categories = JsonConvert.DeserializeObject<List<Category>>(inputJson);
			categories.RemoveAll(c => c.Name == null);
			context.Categories.AddRange(categories);
			context.SaveChanges();
			return $"Successfully imported {categories.Count}";
		}
		public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
		{
			var categoryProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(inputJson);
			context.CategoriesProducts.AddRange(categoryProducts);
			context.SaveChanges();
			return $"Successfully imported {categoryProducts.Count}";
		}
		public static string GetProductsInRange(ProductShopContext context)
		{
			var product = context.Products.Where(c => c.Price > 500 && c.Price <= 1000).Select(c => new ExportProductDto
			{
				Name = c.Name,
				Price = c.Price,
				Seller = c.Seller.FirstName + " " + c.Seller.LastName
			}).OrderBy(c => c.Price).ToList();
			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				Formatting = Formatting.Indented
			};

			return JsonConvert.SerializeObject(product, settings);
		}
		public static string GetSoldProducts(ProductShopContext context)
		{
			var users = context.Users.Where(u => u.ProductsSold.Any(p => p.BuyerId != null)).OrderBy(u => u.LastName).ThenBy(u => u.FirstName).Select(u => new
			{
				u.FirstName,
				u.LastName,
				soldProducts = u.ProductsSold.Select(p => new
				{
					p.Name,
					p.Price,
					buyerFirstName = p.Buyer.FirstName,
					buyerLastName = p.Buyer.LastName
				}).ToList()
			}).ToList();
			var settings = new JsonSerializerSettings()
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				Formatting = Formatting.Indented
			};
			return JsonConvert.SerializeObject(users, settings);
		}
		public static string GetCategoriesByProductsCount(ProductShopContext context)
		{
			var categories = context.Categories.OrderByDescending(c => c.CategoriesProducts.Count()).Select(c => new
			{
				category=c.Name,
				productsCount=c.CategoriesProducts.Count(),
				averagePrice=$"{c.CategoriesProducts.Average(cp=>cp.Product.Price):f2}",
				totalRevenue= $"{c.CategoriesProducts.Sum(cp => cp.Product.Price):f2}"

			});
			var settings = new JsonSerializerSettings()
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				Formatting = Formatting.Indented
			};
			return JsonConvert.SerializeObject(categories, settings);
		}
		public static string GetUsersWithProducts(ProductShopContext context)
		{
			var users = context.Users
				.Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
				.Select(u => new
				{
					firstName = u.FirstName,
					lastName = u.LastName,
					age = u.Age,
					soldProducts = new
					{
						count = u.ProductsSold.Count(p => p.BuyerId != null),
						products = u.ProductsSold
							.Where(p => p.BuyerId != null)
							.Select(p => new
							{
								name = p.Name,
								price = p.Price
							}).ToArray()
					}
				}).OrderByDescending(u => u.soldProducts.count).ToList();

			var resultUsers = new
			{
				usersCount = users.Count(),
				users = users
			};
			var settings = new JsonSerializerSettings()
			{
				NullValueHandling= NullValueHandling.Ignore,
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				Formatting = Formatting.Indented
			};
			return JsonConvert.SerializeObject(resultUsers,settings);
		}

	}
}