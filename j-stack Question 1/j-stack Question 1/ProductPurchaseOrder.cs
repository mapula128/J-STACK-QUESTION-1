using System;
using System.Collections.Generic;
using System.Text;

namespace j_stack_Question_1
{
    class ProductPurchaseOrder : Store
    {
        //member variables
        private int laptops;
        private int tablets;
        private int phones;

        //properties
        public int LaptopsInStore
        {
            get { return laptops; }
            set
            {
                if (value <= 0) throw new Exception("we dont have laptops in store,try us in few days");
                laptops = value;
            }
        }
        public int TabletsInStore
        {
            get { return tablets; }
            set
            {
                if (value <= 0) throw new Exception("we dont have tablets in store,try us in few days");

                tablets = value;
            }
        }
        public int PhonesInStore
        {
            get { return phones; }
            set
            {
                if (value <= 0) throw new Exception("we dont have phones in store,try us in few days");

                phones = value;
            }
        }
        public ProductPurchaseOrder()
        {
            Console.WriteLine("We have greate deals instore");

        }
        public void AddProductsToInventory()
        {

            int productsInStock = 0; ;
            int productsToSell = 0;
            int numOfItemsPerPurchase = 0;
            double pricePerProduct = 0;
            double costPerProduct = 0;
            int totalItemsSold = 0;

            string Day = DateTime.Today.ToString("hh:mm:ss");

            var currentDay = DateTime.Now.ToString("hh:mm:ss");




            Console.Write("Please Enter Product Type:");



            //products type in my store
            string[] productType;
            productType = new string[3] { "Laptops", "Tablets", "Phones" };

            //using foreach loop to loop throw the product type in  the array and switch statement to switch throw product type
            foreach (var item in productType)
            {
                switch (item)
                {
                    case "Laptops":

                        //date to determine current date for the price of items in store/since price differe in days

                        if (Day == currentDay)
                        {
                            //checking if number of product in store is => product customer wants 
                            if ((productsInStock == 1) && (productsToSell >= 2))
                            {
                                Console.WriteLine("We out of stock ,come another day");
                            }
                            else
                            {
                                Console.WriteLine("we only have one item left in store that you can purchase in our  store");
                            }
                            //checking number of items in store and calculating cost of each items/number of items sold
                            if ((LaptopsInStore > 0) && (productsInStock >= productsToSell))
                            {
                                costPerProduct = numOfItemsPerPurchase * pricePerProduct;
                                Console.WriteLine("cost of the products purchased is:", costPerProduct);
                                totalItemsSold += numOfItemsPerPurchase;
                            }
                            else
                            {
                                Console.WriteLine("We  out of stock check with us some other time  ");
                            }
                        }

                        break;
                    case "Tablets":
                        if (Day == currentDay)
                        {
                            //checking if number of product in store is => product customer wants 
                            if ((productsInStock == 1) && (productsToSell >= 2))
                            {
                                Console.WriteLine("We out of stock ,come another day");
                            }
                            else
                            {
                                Console.WriteLine("we only have one item left in store that you can purchase in our  store");
                            }
                            //checking number of items in store and calculating cost of each items/number of items sold
                            if ((TabletsInStore > 0) && (productsInStock >= productsToSell))
                            {
                                costPerProduct = numOfItemsPerPurchase * pricePerProduct;
                                Console.WriteLine("cost of the products purchased is:", costPerProduct);
                                totalItemsSold += numOfItemsPerPurchase;
                            }
                            else
                            {
                                Console.WriteLine("We  out of stock check with us some other time  ");
                            }
                        }

                        break;
                    case "Phones":

                        if (Day == currentDay)
                        {
                            //checking if number of product in store is => product customer wants 
                            if ((productsInStock == 1) && (productsToSell >= 2))
                            {
                                Console.WriteLine("We out of stock ,come another day");
                            }
                            else
                            {
                                Console.WriteLine("we only have one item left in store that you can purchase in our  store");
                            }
                            //checking number of items in store and calculating cost of each items/number of items sold
                            if ((PhonesInStore > 0) && (productsInStock >= productsToSell))
                            {
                                costPerProduct = numOfItemsPerPurchase * pricePerProduct;
                                Console.WriteLine("cost of the products purchased is:", costPerProduct);
                                totalItemsSold += numOfItemsPerPurchase;

                            }
                            else
                            {
                                Console.WriteLine("We out of stock check with us some other time   ");
                            }
                        }


                        break;

                    default:
                        Console.WriteLine("we out of  stock of all product");
                        break;

                }




            }


            //current items in store

            Store Laptops = new Store()
            {
                ItemName = "Acer",
                pricePerProduct = 3000,
                NumItems = 13



            };
            Store Tablets = new Store()
            {

                ItemName = "Mobicel",
                pricePerProduct = 1000,
                NumItems = 20

            };
            Store Phones = new Store()
            {


                ItemName = "IPhone7",
                pricePerProduct = 15000,
                NumItems = 9


            };



            //products to add in store for future date
            List<Store> products = new List<Store>(2);
            products.Add(Laptops);
            products.Add(Tablets);
            products.Add(Phones);

            Store laptop = products[0];
            Console.WriteLine("ItemName={0}, pricePerProduct={1}, NumItems={2}", laptop.ItemName, laptop.pricePerProduct, laptop.NumItems);

            Store tablet = products[1];
            Console.WriteLine("Itemame={0}, pricePerProduct={1}, NumItems={2}", tablet.ItemName, tablet.pricePerProduct, tablet.NumItems);
            Store phone = products[2];
            Console.WriteLine("ItemName={0}, pricePerProduct={1}, NumItems={2}", phone.ItemName, phone.pricePerProduct, phone.NumItems);
            Console.WriteLine("We Are going to have more Phones ,Laptops & Tablets in our Store");





        }

    }


}
