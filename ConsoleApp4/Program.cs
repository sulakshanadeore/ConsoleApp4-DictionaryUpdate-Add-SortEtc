using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static Dictionary<int, Jewellery> jewellerydetails = new Dictionary<int, Jewellery>();
          

        static void Main(string[] args)
        {
            jewellerydetails.Add(34, new Jewellery { Id = "JW04", Material = "Gold", Price = 12000, Type = "Chain" });
            jewellerydetails.Add(1, new Jewellery { Id = "JW02", Material = "Silver", Price = 1000, Type = "Bracelet" });
            jewellerydetails.Add(2, new Jewellery { Id = "JW01", Material = "Gold", Price = 2000, Type = "Chain" });
            jewellerydetails.Add(4, new Jewellery { Id = "JW03", Material = "Silver", Price = 11000, Type = "Bracelet" });

            //JewelleryUtility u= new JewelleryUtility(); 
            //u.SortData();   


            //List<string> list = new List<string>();
            //list.Add("Pranit");
            //list.Add("Sumit");

            //var n = from s in list
            //        from s1 in s
            //        select s1;

            //foreach (var item in n)
            //{
            //    Console.Write(item  + " ");
            //}



            //distinctDemo();

            List<List<string>> products = new List<List<string>>
{
    new List<string> { "Apple", "Banana", "Grapes" },
    new List<string> { "Coke", "Milk", "Fanta" },
    new List<string> { "Mobile", "TV", "Tablet","Laptop" }
 };
            List<string> allProducts = products.SelectMany(x => x).ToList();
            foreach (var item in allProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");

            //Or if we want we can project the inner list too, both are same
            List<string> selectmanyexample = products.SelectMany(x => x.Select(z => z)).ToList();

            foreach (var item in selectmanyexample)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }









            //   FindJewellery();
            //UpdateDictionary();
            //AddJewellery();

            Console.ReadLine();
        }

        private static void distinctDemo()
        {
            List<Jewellery> jlist = new List<Jewellery>();
            jlist.Add(new Jewellery { Id = "1", Material = "Alloy", Type = "ring", Price = 2000 });
            jlist.Add(new Jewellery { Id = "2", Material = "Gold", Type = "Bracelets", Price = 2000 });
            jlist.Add(new Jewellery { Id = "1", Material = "Alloy", Type = "ring", Price = 2000 });

            var allData = (from j in jlist
                           select new { j.Id }).Distinct().ToList();
            foreach (var item in allData)
            {
                Console.WriteLine(item.Id);
                //Console.WriteLine(item.Price);
                //Console.WriteLine(item.Material);
                //Console.WriteLine(item.Price);
                Console.WriteLine();
            }
        }

        private static void AddJewellery()
        {
            JewelleryUtility u = new JewelleryUtility();
            Jewellery j = new Jewellery();
            Console.WriteLine("Enter ID");
            j.Id = Console.ReadLine();
            Console.WriteLine("Enter Material");
            j.Material = Console.ReadLine();
            Console.WriteLine("Enter type");
            j.Type = Console.ReadLine();
            Console.WriteLine("Enter price");
            j.Price = Convert.ToInt32(Console.ReadLine());


            Program.jewellerydetails = u.AddNewJewellery(j);
            Console.WriteLine("After Adding.............");
            foreach (KeyValuePair<int, Jewellery> data in Program.jewellerydetails)
            {
                Console.WriteLine(data.Key);
                Console.WriteLine(data.Value.Id);
                Console.WriteLine(data.Value.Material);
                Console.WriteLine(data.Value.Price);
                Console.WriteLine(data.Value.Type);

            }
        }

        private static void UpdateDictionary()
        {
            Jewellery j = new Jewellery();
            Console.WriteLine("Enter ID");
            j.Id = Console.ReadLine();
            Console.WriteLine("Enter Material");
            j.Material = Console.ReadLine();
            Console.WriteLine("Enter type");
            j.Type = Console.ReadLine();
            Console.WriteLine("Enter price");
            j.Price = Convert.ToInt32(Console.ReadLine());

            JewelleryUtility utility = new JewelleryUtility();
            Program.jewellerydetails = utility.UpdateJewelleryDetails(j.Id, j);
            Console.WriteLine("After updating......................");
            
            foreach (KeyValuePair<int, Jewellery> data in Program.jewellerydetails)
            {
                Console.WriteLine(data.Key);
                Console.WriteLine(data.Value.Id);
                Console.WriteLine(data.Value.Material);
                Console.WriteLine(data.Value.Price);
                Console.WriteLine(data.Value.Type);

            }
        }

        private static void FindJewellery()
        {
            Console.WriteLine("Enter id to find");
            string find = Console.ReadLine();
            JewelleryUtility u = new JewelleryUtility();
            Dictionary<string, string> detailsFound = u.GetJewelleryDetails(find);
            if (detailsFound != null)
            {
                Console.WriteLine(detailsFound.ElementAtOrDefault(0).ToString());
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
