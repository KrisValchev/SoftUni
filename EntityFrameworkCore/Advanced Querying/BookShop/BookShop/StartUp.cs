namespace BookShop
{
	using BookShop.Models.Enums;
	using Data;
    using Initializer;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Conventions;
	using System;
	using System.Globalization;
	using System.Runtime.InteropServices;
	using System.Text;

	public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);
            Console.WriteLine(GetMostRecentBooks(db));
        }
		public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
           if(Enum.TryParse(command,true,out AgeRestriction ageRestriction))
            {
            return string.Join(Environment.NewLine, context.Books.OrderBy(b => b.Title).Where(b => b.AgeRestriction == ageRestriction).Select(b => $"{b.Title}").ToList());
            }
            else
            {
                return string.Empty;
            }
        }
		public static string GetGoldenBooks(BookShopContext context)
        {
            
            return string.Join(Environment.NewLine, context.Books.AsEnumerable().OrderBy(b => b.BookId).Where(b => b.Copies < 5000 && b.EditionType.ToString()=="Gold").Select(b => $"{b.Title}").ToList());
        }
		public static string GetBooksByPrice(BookShopContext context)
        {
			return string.Join(Environment.NewLine, context.Books.OrderByDescending(b => b.Price).Where(b => b.Price > 40).Select(b => $"{b.Title} - " +
            $"${b.Price:f2}").ToList());
        }

		public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
			return string.Join(Environment.NewLine, context.Books.OrderBy(b => b.BookId).Where(b => b.ReleaseDate.Value.Year!=year).Select(b => $"{b.Title}").ToList());
		}
		public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] array=input.ToLower().Split(' ',StringSplitOptions.RemoveEmptyEntries);
			return string.Join(Environment.NewLine, context.BooksCategories.OrderBy(bc => bc.Book.Title).Where(bc =>array.Contains(bc.Category.Name.ToLower())).Select(bc => $"{bc.Book.Title}").ToList());
		}

		public static string GetBooksReleasedBefore(BookShopContext context, string date)
		{

			return string.Join(Environment.NewLine, context.Books.OrderByDescending(b => b.ReleaseDate).Where(b => b.ReleaseDate < DateTime.ParseExact(date, "dd-MM-yyyy",CultureInfo.InvariantCulture)).Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}").ToList());
		}

		public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
			return string.Join(Environment.NewLine, context.Authors.AsEnumerable().Where(a => a.FirstName.Substring(a.FirstName.Length-input.Length).ToString() == input).Select(a =>$"{a.FirstName} {a.LastName}").OrderBy(a => a).ToList());
		}
		public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
			return string.Join(Environment.NewLine, context.Books.OrderBy(b => b.Title).Where(b => b.Title.ToLower().Contains(input.ToLower())).Select(b => $"{b.Title}").ToList());
		}

		public static string GetBooksByAuthor(BookShopContext context, string input)
		{
			var books = context.Books
		   .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
		   .Select(b => new
		   {
			   b.Title,
			   AuthorName = b.Author.FirstName + " " + b.Author.LastName,
			   b.BookId
		   })
		   .OrderBy(b => b.BookId)
		   .ToArray();
			StringBuilder sb = new StringBuilder();
			foreach (var book in books)
			{
				sb.AppendLine($"{book.Title} ({book.AuthorName})");
			}
			return sb.ToString().TrimEnd();
		}

		public static int CountBooks(BookShopContext context, int lengthCheck)
		{
			return context.Books.Where(b=>b.Title.Count()>lengthCheck).Count();
		}
		public static string CountCopiesByAuthor(BookShopContext context)
		{

			return string.Join(Environment.NewLine, context.Authors.OrderByDescending(a=> a.Books.Sum(b => b.Copies)).Select(a=>$"{a.FirstName} {a.LastName} - {a.Books.Sum(b=>b.Copies)}").ToList());
		}

		public static string GetTotalProfitByCategory(BookShopContext context)
		{
			return string.Join(Environment.NewLine, context.Categories.OrderByDescending(c=>c.CategoryBooks.Sum(bc => bc.Book.Copies * bc.Book.Price)).ThenBy(c=>c.Name).Select(c => $"{c.Name} ${c.CategoryBooks.Sum(bc => bc.Book.Copies * bc.Book.Price):f2}").ToList());
		}

		public static string GetMostRecentBooks(BookShopContext context)
		{
			var categoriesInfo = context.Categories
			.AsNoTracking()
			.Select(c => new
			{
				CategoryName = c.Name,
				Books = c.CategoryBooks.Select(cb => new
				{
					BookName = cb.Book.Title,
					ReleaseDate = cb.Book.ReleaseDate
				})
				.OrderByDescending(b => b.ReleaseDate)
				.Take(3)
				.ToArray()
			})
			.OrderBy(c => c.CategoryName)
			.ToArray();

			StringBuilder sb = new StringBuilder();
			foreach (var category in categoriesInfo)
			{
				sb.AppendLine($"--{category.CategoryName}");

				foreach (var book in category.Books)
				{
					sb.AppendLine($"{book.BookName} ({book.ReleaseDate.Value.Year})");
				}
			}
			return sb.ToString().TrimEnd();
		}
		public static void IncreasePrices(BookShopContext context)
		{
			var books = context.Books
			.Where(b => b.ReleaseDate.Value.Year < 2010)
			.ToArray();

			foreach (var book in books)
			{
				book.Price += 5;
			}

			context.SaveChanges();

		}
		public static int RemoveBooks(BookShopContext context)
		{
			var booksCategoriesToRemove = context.BooksCategories
			.Where(bc => bc.Book.Copies < 4200)
			.ToArray();

			var booksToRemove = context.Books
				.Where(b => b.Copies < 4200)
				.ToArray();

			int removedBooks = booksToRemove.Count();


			context.BooksCategories.RemoveRange(booksCategoriesToRemove);
			context.Books.RemoveRange(booksToRemove);
			context.SaveChanges();

			return removedBooks;
		}
	}
}


