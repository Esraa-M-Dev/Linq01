using LINQ.DataSources;
namespace AssignmentLinq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            var result = Source.ProductList
               .Where(p => p.Category == "Seafood")
              .Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var p in result)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            } 
            #endregion

        }
    }
}
