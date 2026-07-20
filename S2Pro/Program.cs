namespace S2Pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Create a Book class with a Title and Pages.
            // Create a Book object and store it in a variable of type object.
            // Print it.

            Book book = new Book()
            {
                Title = "C# Fundamentals",
                Pages = 464
            };

            object obj = book;
            Console.WriteLine(obj);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 2
            // Print ToString(), Equals(), GetHashCode(), GetType()

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 3
            // Fix the compile-time error

            int pages = 464;
            Console.WriteLine(pages);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 4
            // Divide by zero using try-catch-finally

            try
            {
                int x = 0;
                int y = 10;
                int result = y / x;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 5
            // Implicit Conversion

            int pages2 = 300;
            double pagesDouble = pages2;

            Console.WriteLine(pagesDouble);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 6
            // Explicit Conversion (Casting)

            double price = 49.99;
            int intPrice = (int)price;

            Console.WriteLine(intPrice);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 7
            // Convert

            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);

            Console.WriteLine(convertedPages);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Question 8
            // Parse & TryParse

            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";

            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            Console.WriteLine("--------------------------------");
        }
    }
}
