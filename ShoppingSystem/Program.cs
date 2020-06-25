using System;
using System.Collections.Generic;

namespace ShoppingSystem
{
    class Program
    {
        
         List<Customer> customers = new List<Customer>();
        //List<Customer> login = new List<Customer>();

            //Customer c1 = new Customer();
        public bool loginn;
        public void Register()
        {
            Console.WriteLine("Enter fullname \n password\n email\n phonenum \n address\n ");
            string fullname = Console.ReadLine();
            string password = Console.ReadLine();
            string email = Console.ReadLine();
            int phone = Convert.ToInt32(Console.ReadLine());
            string address = Console.ReadLine();

            Customer customer1 = new Customer(fullname, password, email, phone, address);

            customers.Add(customer1);

            // cusCount = customers.Count;
            foreach (Customer c in customers)
            {
                Console.WriteLine("FullName-{0}, Password-{1}, email-{2}, phone-{3}, address-{4}"
                    , c.FullName, c.Password, c.Email, c.PhoneNumber, c.BillingAddress);
            }

        }

        public void Login()
        {

            Console.WriteLine("Enter the username and password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            //Customer c1 = new Customer(username, password);
            int count = 0;
            foreach (Customer c in customers)
            {
                if ((username == c.GetFullName()) && (password == c.GetPassword()))
                {
                    loginn = true;
                    count++;
                    Console.WriteLine("Login Successful");
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Login Failed");
            }

        }

        public void ChangeInfo()
        {
            if (customers.Count != 0)
            {
                Console.WriteLine("Enter the username and password to change info");
                string name = Console.ReadLine();
                string pass = Console.ReadLine();

                foreach (Customer c in customers)
                {
                    if ((name == c.GetFullName()) && (pass == c.GetPassword()))
                    {
                        Console.WriteLine("Enter the details you want to update it");
                        Console.WriteLine("Enter the phone number \n address to be updated");
                        int phno = Convert.ToInt32(Console.ReadLine());
                        string address = Console.ReadLine();
                        c.SetPhoneNum(phno);
                        c.SetAddress(address);

                    }

                }
            }
            else
            {
                Console.WriteLine("No account registered to change info");
            }

        }

        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            MarketingStaff ms = new MarketingStaff();
            //SalesStaff ss = new SalesStaff();
            ms.DisplayProducts();
            //Product p = new Product(123,"Laptop", 1000);
            //ms.UpdateProduct(1, p);
            //ms.DisplayProducts();
            //Console.WriteLine(ms.GetProduct(1));
            //ms.DeleteProduct(2);
            //ms.DisplayProducts();
            ShoppingCart shopping = new ShoppingCart();
            shopping.GetTotalCost();

            Program p1 = new Program();
            CourierCompany courier = new CourierCompany();
            for (; ; )
            {
                Console.WriteLine("Enter the choice:\n 1.Login \n 2.Register\n 3.Add to cart \n " +
                    "4.view cart \n 5.Place order \n 6.Change Info \n 7.return item \n 8.Deletecart \n 9.Check status \n 10.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                bool e;
                switch (choice)
                {

                    case 1:
                        p1.Login();
                        break;
                    case 2:
                        p1.Register();
                        break;
                    case 3:
                        if (p1.loginn)
                        {
                            c1.AddCart();
                        }
                        else
                        {
                            Console.WriteLine("can't add to cart");
                        }
                        break;
                    case 4:
                        c1.Display();
                        break;
                    case 5: 
                        c1.PlaceOrder();
                        break;
                    case 6:
                        p1.ChangeInfo();
                        break;
                    case 7:
                        c1.Damage();
                        break;
                    case 8:
                        c1.DeleteItem();
                        break;
                    case 9:

                        if (c1.po == true)
                        {
                            courier.OrderDelivery();
                        }
                        else
                        {
                            Console.WriteLine("First place the order");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

    }
}

