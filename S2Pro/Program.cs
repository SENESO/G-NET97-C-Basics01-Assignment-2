
using S2Pro;

namespace S2Pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            
/*
            Book book = new Book()
            {
                Title = "C# Fundamentals",
                Pages = 464
            };

            object obj = book;
            Console.WriteLine(obj);
*/
            #endregion

            

            #region Question 2
            // Print ToString(), Equals(), GetHashCode(), GetType()
/*
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
*/
            #endregion

            

            #region Question 3
            // Fix the compile-time error
/*
            int pages = 464;
            Console.WriteLine(pages);
*/
            #endregion

            

            #region Question 4
            // Divide by zero using try-catch-finally
/*
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
*/
            #endregion

            

            #region Question 5
            // Implicit Conversion
/*
            int pages2 = 300;
            double pagesDouble = pages2;

            Console.WriteLine(pagesDouble);
*/
            #endregion

            

            #region Question 6
            // Explicit Conversion (Casting)
/*
            double price = 49.99;
            int intPrice = (int)price;

            Console.WriteLine(intPrice);
*/
            #endregion

            

            #region Question 7
  /*          // Convert

            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);

            Console.WriteLine(convertedPages);
  */
            #endregion

            

            #region Question 8
            // Parse & TryParse
/*
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
*/
            #endregion

            

            #region Question 9
            // ToString()
 /*
            int pages = 464;
            string pagesText = pages.ToString();
            Console.WriteLine(pagesText.GetType());   // System.String
 */
            #endregion

            

            #region Question 10
/*
            int copies = 100;
            object boxed = copies;          // boxing
            int unboxed = (int)boxed;       // unboxing
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
*/
            #endregion
            

            #region Question 11
            int? year = null;
            Console.WriteLine(year.HasValue);   
            year = 2023;
            Console.WriteLine(year.Value);      
            #endregion
            
            #region Question 12
            string? reviewer = null;
            Console.WriteLine($"Is null: {reviewer == null}");
            #endregion
            #region Question 13
            Book? book = null;
            string? title = book?.Title;
            Console.WriteLine(title);   // prints nothing (null), no crash
            #endregion
            #region Question 14
            Console.WriteLine(title ?? "Untitled");   // "Untitled"

            title ??= "Untitled";
            Console.WriteLine(title);                 // "Untitled"
            #endregion
            #region Question 15
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
            #endregion


        }
    }
}
