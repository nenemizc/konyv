using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv
{
	internal class Book
	{
		string title;
		string author;
		int pageCount;
		int releaseYear;

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string Title { get => title; }
		public string Author { get => author; }
		public int PageCount { get => pageCount; }
		public int ReleaseYear { get => releaseYear; }

		public string GetBookByTitle(Book[] books, string title) 
		{
			int asd = 0;
			for (int i = 0; i < books.Length; i++) 
			{
				if (books[i].Title == title)
				{
					return $"{books[i].Title} - {books[i].Author} - {books[i].PageCount} - {books[i].ReleaseYear}";
				}
				else
				{
					asd++;
				}
			}
			if (asd == books.Length) {
				return "nincs ilyen könyv";
			}
			return "";
		}

		public void EditBookData(string title = "", string author ="", int pageCount = 0, int releaseYear = 0)
		{
			if (title != "")
			{
				this.title = title; 
			}
			if (author != "")
			{
				this.author = author;
			}
            if (pageCount != 0)
            {
				this.pageCount = pageCount;
            }
			if (releaseYear != 0) 
			{
				this.releaseYear = releaseYear; 
			}
			Console.WriteLine($"Úk könyv adatok:\n{this.ToString()}");

		}
	}
}
