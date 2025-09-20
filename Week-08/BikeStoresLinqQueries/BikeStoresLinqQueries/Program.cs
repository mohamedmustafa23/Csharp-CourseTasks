using BikeStoresLinqQueries.Data;
using BikeStoresLinqQueries.Models;
using System.Diagnostics;

namespace BikeStoresLinqQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new BikeStoresContext();

            //1-List all customers' first and last names along with their email addresses.
            var customers = context.Customers.Select(c => new
            {
                c.FirstName,
                c.LastName,
                c.Email,
            });


            //2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).
            var orders = context.Orders.Where(o => o.StaffId == 3);

            //3- Get all products that belong to a category named "Mountain Bikes".
            var Products = context.Products.Where(p => p.Category.CategoryName == "Mountain Bikes");

            //4-Count the total number of orders per store.
            var CountOrdersPerStore = context.Orders.GroupBy(o => o.Store).Select(g => new
            {
                StoreId = g.Key,
                OrderCount = g.Count(),
            });

            //5- List all orders that have not been shipped yet (shipped_date is null).
            var ordersNotShipped = context.Orders.Where(o => o.ShippedDate == null);

            //6- Display each customer’s full name and the number of orders they have placed.
            var customersAndOrders = context.Customers.Select(c => new
            {
                FullName = c.FirstName + "" + c.LastName,
                ordersCount = c.Orders.Count(),
            });

            //7- List all products that have never been ordered (not found in order_items).
            var productsNotOrdered = context.Products.Where(p => !p.OrderItems.Any());

            //8- Display products that have a quantity of less than 5 in any store stock.
            var ProductsLess5 = context.Stocks.Where(s => s.Quantity < 5).Select(s => s.Product).Distinct();

            //9- Retrieve the first product from the products table.
            var firstProduct = context.Products.FirstOrDefault();

            //10- Retrieve all products from the products table with a certain model year.
            var productsInYear = context.Products.Where(p => p.ModelYear == 2017);

            //11- Display each product with the number of times it was ordered.
            var productOrders = context.Products.Select(p => new
            {
                ProductId = p.ProductId,
                OrderCount = p.OrderItems.Count(),
            });

            //12- Count the number of products in a specific category.
            var productsInCategory = context.Products.Where(p => p.CategoryId == 2);

            //13- Calculate the average list price of products.
            var avgPrice = context.Products.Average(p => p.ListPrice);

            //14- Retrieve a specific product from the products table by ID.
            var specificProduct = context.Products.Where(p => p.ProductId == 2);

            //15- List all products that were ordered with a quantity greater than 3 in any order.
            var productWithGreatQty = context.OrderItems.Where(o => o.Quantity > 3)
                .Select(o => o.Product).Distinct();

            //16- Display each staff member’s name and how many orders they processed.
            var staffOrders = context.Staffs.Select(s => new
            {
                MemberName = s.FirstName + " " + s.LastName,
                OrdersCount = s.Orders.Count(),
            });

            //17- List active staff members only (active = true) along with their phone numbers.
            var activeStaff = context.Staffs.Where(s => s.Active == 1).Select(s => new
            {
                s.FirstName,
                s.LastName,
                s.Phone,
            });

            //18- List all products with their brand name and category name.
            var productsWithDetails = context.Products.Select(p => new
            {
                p.ProductName,
                BrandName = p.Brand.BrandName,
                CategoryName = p.Category.CategoryName
            });

            //19- Retrieve orders that are completed.
            var completedOrders = context.Orders.Where(o => o.OrderStatus == 4);

            //20- List each product with the total quantity sold (sum of quantity from order_items).
            var productSales = context.Products.Select(p => new
            {
                p.ProductName,
                TotalSold = p.OrderItems.Sum(oi => (int?)oi.Quantity) ?? 0
            });

        }
    }
}
