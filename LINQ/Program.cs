using System;
using System.Linq;        
 namespace LINQ
 {
      internal class Program
      {
            static void Main(string[] args)
            {
                Console.WriteLine("Vali meetod:");
                Console.WriteLine("1 - ProductsOver50 // Where");
                Console.WriteLine("2 - ClientsFromTallinn //Where");
                Console.WriteLine("3 - SortProductsByPrice // OrderBy");
                Console.WriteLine("4 - SortClientsByCityAndName // OrderBy ja ThenBy");
                Console.WriteLine("5 - SelectClientNames // Select");
                Console.WriteLine("6 - Skip // jäta 3 toodet vahele //  SkipProducts");
                Console.WriteLine("7 - SkipWhile // hind alla 20€ // SkipWhileProducts");
                Console.WriteLine("8 - SelectProductNames // Select");
                Console.WriteLine("9 - SelectClients // Select");
                Console.WriteLine("10 -  TakeWhileUnder100");
                Console.WriteLine("11 -  TakeWhileUnder50");
                Console.WriteLine("12 -  FirstProduct");
                Console.WriteLine("13 -  FindClientId");
                Console.WriteLine("14 - Average");
                Console.WriteLine("15 -  Sum");
                Console.WriteLine("16 -  Min");
                Console.WriteLine("17 -  Any");
                Console.WriteLine("18 -  All");
                



            int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                     case 1:
                     ProductsOver50();
                     break;

                     case 2:
                     ClientsFromTallinn();
                     break;

                     case 3:
                     SortProductsByPrice();
                     break;

                     case 4:
                     SortClientsByCityAndName();
                     break;

                     case 5:
                     SelectClientNames();
                     break;

                     case 6:
                     SkipProducts();
                     break;

                     case 7:
                     SkipWhileProducts();
                     break;
                      
                     case 8:
                     SelectProductNames();
                     break;

                     case 9:
                     SelectClients();
                     break;  
                    
                     case 10:
                     TakeWhileUnder100();
                     break;

                     case 11:
                     TakeWhileUnder50();
                     break;

                     case 12:
                     FirstProduct();
                     break;

                     case 13:
                     FindClientId();
                     break;

                     case 14:
                     Average();
                     break;

                     case 15:
                     Sum();
                     break;

                     case 16:
                     Min();
                     break;

                     case 17:
                     Any();
                     break;
                     
                     case 18:
                     All();
                     break;

                    default:
                    Console.WriteLine("Vale valik");
                    break;
                }
            }

            // where leia kõik tooted, mille hind on üle 50€
            public static void ProductsOver50()
            {
                Console.WriteLine("------------Where Price > 50------------");

                var result = ProductData.products
                    .Where(x => x.Price > 50);

                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " - " + item.Price + "€");
                }
            }

            // Leia kõik kliendid, kes elavad Tallinnas
            public static void ClientsFromTallinn()
            {
                Console.WriteLine("------------Where City and Tallinn------------");

                var result = ClientData.clients
                    .Where(x => x.City == "Tallinn");

                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " - " + item.City);
                }
            }

            //OrderBy sorteerib tooted hinna järgi kasvavalt
            public static void SortProductsByPrice()
            {
                Console.WriteLine("------------OrderBy Price------------");

                var result = ProductData.products
                    .OrderBy(x => x.Price);

                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " - " + item.Price + "€");
                }
            }

            // Sorteerib kliendid linna ja seejärel nime järgi
            public static void SortClientsByCityAndName()
            {
                Console.WriteLine("------------OrderBy ja ThenBy------------");

                var result = ClientData.clients
                    .OrderBy(x => x.City)
                    .ThenBy(x => x.Name);

                foreach (var item in result)
                {
                    Console.WriteLine(item.City + " - " + item.Name);
                }
            }

            // select väljastab ainult kliendi nimed
            public static void SelectClientNames()
            {
                Console.WriteLine("------------Select client Names------------");

                var result = ClientData.clients
                    .Select(x => x.Name);

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }

            // skip jäta 3 toodet vahele
            public static void SkipProducts()
            {
                Console.WriteLine("------------Skip------------");

                var result = ProductData.products
                    .Skip(3);

                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " - " + item.Price + "€");
                }
            }

            // SkipWhile jäta vahele kuni hind on alla 20€
            public static void SkipWhileProducts()
            {
                Console.WriteLine("------------SkipWhile------------");

                var result = ProductData.products
                    .SkipWhile(x => x.Price < 20);

                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " - " + item.Price + "€");
                }            
            }
           public static void SelectProductNames()
           {
              Console.WriteLine("------------Select Product Names------------");

              var result = ProductData.products
                .Select(x => x.Name);

              foreach (var item in result)
              {
                Console.WriteLine(item);
              }
           }
          
          public static void SelectClients()
          {
            Console.WriteLine("------------Select Clients------------");

            var result = ClientData.clients
                .Select(x => x.Name);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
          }
          public static void TakeWhileUnder100()
          {
            Console.WriteLine("------------TakeWhile Price < 100------------");

            var result = ProductData.products
                .OrderBy(x => x.Price)
                .TakeWhile(x => x.Price < 100);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " - " + item.Price + "€");
            }
          }
          public static void TakeWhileUnder50()
          {
            Console.WriteLine("------------TakeWhile Price < 50------------");

            var result = ProductData.products
                .OrderBy(x => x.Price)
                .TakeWhile(x => x.Price < 50);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " - " + item.Price + "€");
            }
          }
          public static void FirstProduct()
          {
            Console.WriteLine("------------FirstOrDefault------------");

            var result = ProductData.products
                .FirstOrDefault(x => x.Category == "Electronics");

            if (result != null)
                Console.WriteLine(result.Name + " - " + result.Category);
            else
                Console.WriteLine("Kategooriat ei leitud");
          }
          public static void FindClientId()
          {
            Console.WriteLine("------------FirstOrDefault------------");

            var result = ClientData.clients
                .FirstOrDefault(x => x.Id == 3);

            if (result != null)
            {
                Console.WriteLine(result.Name + " - " + result.City);
            }
            else
            {
                Console.WriteLine("Klienti ei leitud");
            }               
          }

          public static void Average()
          {
            Console.WriteLine("------------Average Price------------");

            var avg = ProductData.products
                .Average(x => x.Price);

            Console.WriteLine("Toodete keskmine hind: " + avg + "€");
          }

          public static void Sum()
          {
            Console.WriteLine("------------Sum------------");

            var total = ProductData.products
                .Sum(x => x.Price * x.Amount);

            Console.WriteLine("Kogu laoväärtus: " + total + "€");
          }

          public static void Max()
          {
            Console.WriteLine("------------Max------------");

            var maxPrice = ProductData.products
                .Max(x => x.Price);

            var product = ProductData.products
                .First(x => x.Price == maxPrice);

            Console.WriteLine("Kõige kallim toode: " + product.Name + " - " + product.Price + "€");
          }

         public static void Min()
         {
            Console.WriteLine("------------Min------------");

            var minPrice = ProductData.products
                .Min(x => x.Price);

            var product = ProductData.products
                .First(x => x.Price == minPrice);

            Console.WriteLine("Kõige odavam toode: " + product.Name + " - " + product.Price + "€");
         }

        public static void Any()
        {
            Console.WriteLine("------------Any Price > 500------------");

            bool result = ProductData.products
                .Any(x => x.Price > 500);

            Console.WriteLine("toode maksab 500€: " + result);
        }

        public static void All()
        {
            Console.WriteLine("------------All Amount > 0------------");

            bool result = ProductData.products
                .All(x => x.Amount > 0);

            Console.WriteLine("JAH: " + result);
        }
      }
 }