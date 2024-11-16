using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class JewelleryUtility:Jewellery
    {




        public Dictionary<int, Jewellery> AddNewJewellery(Jewellery toadd)
        {

            int cnt=Program.jewellerydetails.Count;
            
            Program.jewellerydetails.Add(cnt + 1, toadd);
            
            
            return Program.jewellerydetails;


        }
        public Dictionary<int, Jewellery> UpdateJewelleryDetails(string id,Jewellery toupdate)
        {

            //Dictionary<string, string> newdict = new Dictionary<string, string>();


            string s = null;
            for (int i = 0; i < Program.jewellerydetails.Count; i++)
            {
                foreach (KeyValuePair<int, Jewellery> item in Program.jewellerydetails)
                {
                    if (item.Value.Id == id)
                    {
                        //s = string.Concat(item.Value.Material, "_", item.Value.Type);
                        item.Value.Id=toupdate.Id;
                        item.Value.Material = toupdate.Material; 
                        item.Value.Price = toupdate.Price;
                        item.Value.Type = toupdate.Type;



                    }

                }
                
                
            }
            return Program.jewellerydetails;


        }



        public void SortData()
        {
            //var data = from p in Program.jewellerydetails
            //           group p by p.Value.Material;

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Key.ToString());
            //    Console.WriteLine("--------------------");

            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1.Value.Type);
            //        Console.WriteLine(item1.Value.Id);
            //        Console.WriteLine(item1.Value.Price);
            //        Console.WriteLine(item1.Value.Material);
            //        Console.WriteLine();
            //    }
            //}


            //var d=Program.jewellerydetails.OrderBy(j=>j.Value.Id);
             //var d=Program.jewellerydetails.Values.OrderBy(j => j.Id);
            var d = Program.jewellerydetails.Values.OrderByDescending(j => j.Id);
            foreach (var item in d)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Material);
                Console.WriteLine(item.Price);
                Console.WriteLine(  );
            }



            //var d=from d1 in Program.jewellerydetails.Values
            //      orderby d1.Id
            //      select d1;

            //foreach (var item in d)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Material);
            //    Console.WriteLine(item.Type);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine(  );
            //}




        }




    


        public Dictionary<string, string> GetJewelleryDetails(string id)
        {

            Dictionary<string, string> newdict = new Dictionary<string, string>();

          
            string s = null;
           for (int i = 0;i<Program.jewellerydetails.Count;i++)
            {
                foreach (KeyValuePair<int, Jewellery> item in Program.jewellerydetails)
                {
                    if (item.Value.Id == id)
                    {
                         s = string.Concat(item.Value.Material, "_", item.Value.Type);
                      
                       
                    }
                    
                }
                newdict.Clear();                
                newdict.Add(id, s);
            }
            return newdict;


        }

        
    }
    



   public class Jewellery
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public int Price { get; set; }


    }


}
