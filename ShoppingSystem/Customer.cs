using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    class Customer
    {
        public string FullName;
        public string Password;
        public string Email;
        public int PhoneNumber;
        public string BillingAddress;
        public bool po;

        //MarketingStaff ms = new MarketingStaff();
        //List<Customer> customers = new List<Customer>();
        ShoppingCart sc = new ShoppingCart();
        //List<Customer> login = new List<Customer>();
        SalesStaff ss = new SalesStaff();
        public Customer()
        {

        }
        public Customer(string fullname, string password, string email, int phoneNumber, string billingAddress)
        {
            this.FullName = fullname;
            this.Password = password;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.BillingAddress = billingAddress;

        }
        public Customer(string UserName, string Password)
        {
            this.FullName = UserName;
            this.Password = Password;
        }

        public string GetFullName()
        {
            return FullName;
        }
        public void SetFullName(string fullname)
        {
            this.FullName = fullname;
        }

        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public int GetPhonenum()
        {
            return PhoneNumber;
        }
        public void SetPhoneNum(int phno)
        {
            this.PhoneNumber = phno;
        }
        public string GetAddress()
        {
            return BillingAddress;
        }
        public void SetAddress(string address)
        {
            this.BillingAddress = address;
        }
        //public void Register()
        //{
        //    Console.WriteLine("Enter fullname \n password\n email\n phonenum \n address\n ");
        //    string fullname = Console.ReadLine();
        //    string password = Console.ReadLine();
        //    string email = Console.ReadLine();
        //    int phone = Convert.ToInt32(Console.ReadLine());
        //    string address = Console.ReadLine();

        //    Customer customer1 = new Customer(fullname,password,email,phone,address);


        //    customers.Add(customer1);

        //    foreach(Customer c in customers)
        //    {
        //        Console.WriteLine("FullName-{0}, Password-{1}, email-{2}, phone-{3}, address-{4}"
        //            ,c.FullName,c.Password,c.Email,c.PhoneNumber,c.BillingAddress);
        //    }


        //}
        //public void Login()
        //{

        //    Console.WriteLine("Enter the username and password");
        //    string username = Console.ReadLine();
        //    string password = Console.ReadLine();
        //    Customer c1 = new Customer(username, password);

        //    foreach (Customer c in customers)
        //    {
        //        if ((username == c.GetFullName()) && (password == c.GetPassword()))
        //        {
        //            login.Add(c1);
        //            Console.WriteLine("Login Successful");
        //        }
        //    }
        //    if (customers.Count == 0)
        //    {
        //        Console.WriteLine("login failed.....first Create an account");
        //    }

        //}

        public void AddCart()
        {
            sc.AddToCart();

        }
        public void Display()
        {
            sc.ViewCart();
        }
        public void DeleteItem()
        {
            sc.DeleteCart();
        }
        
        public bool PlaceOrder()
        {
            //ShoppingCart shoppi = new ShoppingCart();
            //Customer require to login to System i.e by using Login();
            //create an account if he not yet have one i.e by using Register() method
            int a1 = sc.cart.Count;
            if (a1 != 0)
            {
                Console.WriteLine("do u want to place order.....if yes enter yes... if not enter no");
                string result = Console.ReadLine();
                if (result == "yes")
                {
                    ss.ProcessOrder();
                    po = true;
                    return true;
                }
                else
                {
                    Console.WriteLine("Can't process order");
                    return false;
                }
                
            }
            else
            {
                Console.WriteLine("Can't place order due to no items in cart");
                return false;
            }
        }
        public void Damage()
        {
            if (po == true)
            {
                Console.WriteLine("If there is damage in item ....enter yes..if not no");
                string damage = Console.ReadLine();
                if (damage == "yes")
                {
                    ss.Refund();

                }
                else
                {
                    Console.WriteLine("No damage ..so cant return money");

                }
            }
            else
            {
                Console.WriteLine("First place order to return item");
            }
        }

    }
}
