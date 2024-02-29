using Sales.Data;
using Sales.Models;
using System.Diagnostics;

namespace Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SeedData();
        }


        public static  void SeedData()
        {
            SalesContext context = new SalesContext();

            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
            List<Store> stores = new List<Store>();
            List<Sale>sales = new List<Sale>();
            for (int i = 0; i<5;i++)
            {
                customers.Add(new Customer() {Name=$"Customer_{i}" ,Email=$"Email{i}@gmail.com",CreaditCardNumber="123-345"});
                products.Add(new Product() { Name = $"Product_{i}", Quantity = i * 10, Price = (i + 1) * 1000 });

                stores.Add(new Store() { Name = $"Store_{i}" });
                Store  store= new Store() { Name = $"Store_{i}" };

            }

            context.Customers.AddRange(customers);
            context.Products.AddRange(products);
            context.Stores.AddRange(stores);

            sales.Add(new Sale() {Customer=context.Customers.Find(2), Store = context.Stores.Find(2),Products = products});

            context.Sales.AddRange(sales);

            context.SaveChanges();

        }
    }
}
