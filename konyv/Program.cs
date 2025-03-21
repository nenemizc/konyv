namespace konyv
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book b = new("konyv", "Béla", 320, 1912);
			Book b1 = new("Bible2", "István", 29, 1614);
			Book b2 = new("cim","Tóbiás",210,2020);

			Book[] books = [b, b1, b2];

			foreach (Book book in books)
			{
				Console.WriteLine();
				Console.WriteLine(book.ToString());
			}
            Console.WriteLine();

			Console.WriteLine($"'konyv' című könyv adatai: {b.GetBookByTitle(books,"konyv")}");
            Console.WriteLine();

            b2.EditBookData(title: "cim2", releaseYear: 456);
        }
	}
}
