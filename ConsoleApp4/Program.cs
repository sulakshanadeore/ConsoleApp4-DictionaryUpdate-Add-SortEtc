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

            JewelleryUtility u= new JewelleryUtility(); 
            u.SortData();   





            //   FindJewellery();
            //UpdateDictionary();
            //AddJewellery();

            Console.ReadLine();
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
