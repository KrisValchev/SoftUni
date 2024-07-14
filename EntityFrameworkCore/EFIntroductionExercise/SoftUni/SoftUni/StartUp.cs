using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;

namespace SoftUni
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			var context = new SoftUniContext();
			Console.WriteLine(RemoveTown(context));
		}

		public static string GetEmployeesFullInformation(SoftUniContext context)
		{
			return string.Join(Environment.NewLine, context.Employees.OrderBy(e => e.EmployeeId).Select(e => $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F2}").ToList());
		}
		public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
		{
			var sb = new StringBuilder();
			var employees = context.Employees.Select(e => new { e.FirstName, e.Salary }).Where(e => e.Salary > 50000).OrderBy(e => e.FirstName).ToList();

			foreach (var e in employees)
			{
				sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
			}

			return sb.ToString().TrimEnd();
		}

		public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
		{

			return string.Join(Environment.NewLine, context.Employees.Where(e => e.Department.Name == "Research and Development").OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName).Select(e => $"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:F2}").ToList());
		}
		public static string AddNewAddressToEmployee(SoftUniContext context)
		{
			Address address = new Address();
			address.AddressText = "Vitoshka 15";
			address.TownId = 4;
			context.Addresses.Add(address);
			context.SaveChanges();

			var employee = context.Employees.Where(e => e.LastName == "Nakov").FirstOrDefault();

			employee.Address = address;
			context.SaveChanges();

			return string.Join(Environment.NewLine, context.Employees.OrderByDescending(e => e.AddressId).Select(e => $"{e.Address.AddressText}").Take(10));
		}
		public static string GetEmployeesInPeriod(SoftUniContext context)
		{
			var sb = new StringBuilder();
			var employees = context.Employees.Select(e => new
			{
				e.FirstName,
				e.LastName,
				e.Manager,
				Projects = e.EmployeesProjects.Where(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003).Select(ep => new
				{
					ep.Project.Name,
					ep.Project.StartDate,
					ep.Project.EndDate
				})
			}).Take(10).ToList();

			foreach (var e in employees)
			{
				sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.Manager.FirstName} {e.Manager.LastName}");

				if (e.Projects.Any())
				{
					foreach (var ep in e.Projects)
					{
						if (ep.EndDate != null)
						{
							sb.AppendLine($"--{ep.Name} - {ep.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - {ep.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt")}");
						}
						else
						{
							sb.AppendLine($"--{ep.Name} - {ep.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - not finished");
						}
					}
				}
			}

			return sb.ToString().TrimEnd();
		}
		public static string GetAddressesByTown(SoftUniContext context)
		{
			var sb = new StringBuilder();
			var addresses = context.Addresses.OrderByDescending(a => a.Employees.Count)
				.ThenBy(a => a.Town.Name)
				.ThenBy(a => a.AddressText)
				.Select(a => new { a.AddressText, TownName = a.Town.Name, EmployeeCount = a.Employees.Count() })
				.Take(10).ToList();

			foreach (var a in addresses)
			{
				sb.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
			}
			return sb.ToString().TrimEnd();
		}

		public static string GetEmployee147(SoftUniContext context)
		{
			var sb = new StringBuilder();
			var employee = context.Employees.Where(e => e.EmployeeId == 147).Select(e => new { e.FirstName, e.LastName, e.JobTitle, Projects = e.EmployeesProjects.OrderBy(ep => ep.Project.Name).Select(ep => new { Name = ep.Project.Name }) }).FirstOrDefault();

			sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
			foreach (var p in employee.Projects)
			{
				sb.AppendLine(p.Name);
			}
			return sb.ToString().TrimEnd();
		}
		public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
		{
			var sb = new StringBuilder();
			var deparments = context.Departments
				.Where(d => d.Employees.Count() > 5)
				.OrderBy(d => d.Employees.Count())
				.ThenBy(d => d.Name)
				.Select(d => new
				{
					d.Name,
					ManagerFirstName = d.Manager.FirstName,
					ManagerLastName = d.Manager.LastName,
					Employees = d.Employees.OrderBy(e => e.FirstName)
				.ThenBy(e => e.LastName)
				.Select(e => new
				{
					e.FirstName,
					e.LastName,
					e.JobTitle
				})

				})
				.ToList();
			foreach (var d in deparments)
			{
				sb.AppendLine($"{d.Name} - {d.ManagerFirstName} {d.ManagerLastName}");

				foreach (var e in d.Employees)
				{
					sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
				}
			}
			return sb.ToString().TrimEnd();
		}

		public static string GetLatestProjects(SoftUniContext context)
		{
			var sb = new StringBuilder();
			var projects = context.Projects
				.OrderBy(p => p.StartDate)
				.Select(p => new
				{
					p.Name,
					p.Description,
					StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt")
				})

			.ToList()
			.TakeLast(10);

			foreach (var p in projects.OrderBy(p => p.Name))
			{
				sb.AppendLine($"{p.Name}");
				sb.AppendLine($"{p.Description}");
				sb.AppendLine($"{p.StartDate}");
			}
			return sb.ToString().TrimEnd();
		}

		public static string IncreaseSalaries(SoftUniContext context)
		{
			var employees = context.Employees.Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" || e.Department.Name == "Information Services");
			foreach ( var employee in employees)
			{
				employee.Salary *= 1.12m;

			}
			context.SaveChanges();
		
			return string.Join(Environment.NewLine, context.Employees.Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" || e.Department.Name == "Information Services")
			.OrderBy(e => e.FirstName)
			.ThenBy(e => e.LastName)
			.Select(e => $"{e.FirstName} {e.LastName} (${e.Salary:f2})").ToList());
		}

		public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
		{

			return string.Join(Environment.NewLine, context.Employees
			.Where(e => e.FirstName.Substring(0, 2).ToLower() == "sa")
			.OrderBy(e => e.FirstName)
			.ThenBy(e => e.LastName)
			.Select(e => $"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})").ToList());

		}

		public static string DeleteProjectById(SoftUniContext context)
		{
			var project = context.Projects.Find(2);
			var employeeProject = context.EmployeesProjects.Where(e => e.ProjectId == project.ProjectId);
			context.EmployeesProjects.RemoveRange(employeeProject);
			context.Projects.Remove(project);
			context.SaveChanges();

			

			return string.Join(Environment.NewLine, context.Projects
						.Take(10)
						.Select(p => p.Name)
						.ToList());

		}

		public static string RemoveTown(SoftUniContext context)
		{
			var town = context.Towns.Where(t => t.Name == "Seattle").FirstOrDefault();
			Address[] addresses = context.Addresses.Where(a => a.TownId == town.TownId).ToArray();
			var employees = context.Employees.Where(e=>addresses.Contains(e.Address)).ToList();

			foreach (var e in employees)
			{
				e.AddressId = null;
			}

			context.Addresses.RemoveRange(addresses);
			context.Towns.Remove(town);
			context.SaveChanges();
			return $"{addresses.Count()} addresses in Seattle were deleted";
		}
	}

}
