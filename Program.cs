using LINQ.DataSources;
using System.Drawing;
using System.Xml.Linq;
namespace AssignmentLinq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //var result = Source.ProductList
            //   .Where(p => p.Category == "Seafood")
            //  .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            #endregion
            #region Question2
           // 2.Get a list of only the product names from ProductList.Print each name.
            //var productNames = Source.ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            #region Question3
            // 3.Get all products where UnitPrice is between 10 and 30
             var result = Source.ProductList
              .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var product in result)
            {
                Console.WriteLine(product);
            }

            #endregion

        }
    }
}
