using System;

namespace j_stack_Question_1
{
    class Program
    {


     


        static void Main(string[] args)
        {
            
            Store Laptops = new Store()
            {
                 ItemName = "Acer",
                pricePerProduct = 3000,
                   NumItems = 13
               
                
            
        };
            Store Tablets = new Store(){

            ItemName = "Mobicel",
                pricePerProduct = 1000,
            NumItems = 20

        };
            Store Phones = new Store() {


                ItemName = "IPhone7",
                pricePerProduct = 15000,
                NumItems = 9


            };

           

            //creating objects and calling functions

            InventoryItemSummary itemSummary = new InventoryItemSummary();
            itemSummary.GetInventoryItemSummary();
            InventorySummary totalSummary = new InventorySummary();
            totalSummary.GetInventorySummary();
            ProductPurchaseOrder productPurchase = new ProductPurchaseOrder();
            productPurchase.AddProductsToInventory();
            ProductSellOder sellOrder = new ProductSellOder();
            sellOrder.SellProductsFromInventory();

            Console.WriteLine("Please enter Item you like to purchase");


            string ProductName = Console.ReadLine();

            Console.WriteLine("Name Product to purchase is :" + ProductName);

            Console.WriteLine("Please enter number items to purchase"); ;

            int numItem =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Number of item to buy are:" + numItem);

            Console.ReadKey();
        }
    }



    public class Store
    {

        public string ItemName { get; set; }
        public double pricePerProduct { get; set; }
        public int NumItems { get; set; }


        //member variables
        private int laptops;
        private int tablets;
        private int phones;
        //properties
        public int Laptops
        {
            get { return laptops; }
            set
            {
                if (value <= 0) throw new Exception("we dont have laptops in store,try us in few days");
                laptops = value;
            }
        }
        public int Tablets
        {
            get { return tablets; }
            set
            {
                if (value <= 0) throw new Exception("we dont have tablets in store,try us in few days");

                tablets = value;
            }
        }
        public int Phones
        {
            get { return phones; }
            set
            {
                if (value <= 0) throw new Exception("we dont have phones in store,try us in few days");

                phones = value;
            }
        }


    }
}
