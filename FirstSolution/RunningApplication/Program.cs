using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunningApplication
{
    class Program
    {
        public void enterCustomer(List<customer> clist,customer c)
        {
            Validate v = new Validate();
            Console.WriteLine("----Add Customer----");
            Console.WriteLine("Enter Customer ID");
            Boolean checkcustomer = true;
            while (checkcustomer == true)
            {
                c.cid = int.Parse(Console.ReadLine());
                if (!clist.Any())
                {
                    checkcustomer = false;
                }
                else
                {
                    for (int i = 0; i < clist.Count; i++)
                    {
                        if (clist.ElementAt(i).cid == c.cid)
                        {
                            checkcustomer = true;
                            break;
                        }
                        else
                        {
                            checkcustomer = false;
                        }
                    }
                }
                if (checkcustomer == true)
                {
                    Console.WriteLine("CustomerID is existed!");
                    Console.WriteLine("Please enter again!");
                }
            }
            Console.WriteLine("Enter Customer Name");
            c.cname = Console.ReadLine();
            Console.WriteLine("Enter Customer DOB");
            while (true)
            {
                string date = Console.ReadLine();
                if (v.IsValidDateFormat(date))
                {
                    c.dob = DateTime.Parse(date);
                    break;
                }
            }
            clist.Add(c);
        }

        public void enterProduct(List<product> plist,product p)
        {
            Console.WriteLine("----Add Product----");
            Console.WriteLine("Enter Product ID");
            Boolean checkproduct = true;
            while (checkproduct == true)
            {
                p.pid = int.Parse(Console.ReadLine());
                if (!plist.Any())
                {
                    checkproduct = false;
                }
                else
                {
                    for (int i = 0; i < plist.Count; i++)
                    {
                        if (plist.ElementAt(i).pid == p.pid)
                        {
                            checkproduct = true;
                            break;
                        }
                        else
                        {
                            checkproduct = false;
                        }
                    }
                }
                if (checkproduct == true)
                {
                    Console.WriteLine("ProductID is existed!");
                    Console.WriteLine("Please enter again!");
                }
            }
            Console.WriteLine("Enter Product Name");
            p.pname = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            p.price = double.Parse(Console.ReadLine());
            plist.Add(p);
        }

        public void enterOrder(List<customer> clist, List<product> plist, List<order> olist, order o, int orderID)
        {
            Console.WriteLine("----Add Order----");
            Console.WriteLine("Enter Customer ID");
            Boolean check = true;
            int customerId = 0;
            while (check == true)
            {
                customerId = int.Parse(Console.ReadLine());
                for (int i = 0; i < clist.Count; i++)
                {
                    if (clist.ElementAt(i).cid == customerId)
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("CustomerID is not existed!!");
                }
            }
            String checkMore = "Y";
            while (checkMore.Equals("Y") || checkMore.Equals("y"))
            {
                check = true;
                Console.WriteLine("Enter Product ID");
                while (check == true)
                {
                    o = new order();
                    o.pid = int.Parse(Console.ReadLine());
                    for (int i = 0; i < plist.Count; i++)
                    {
                        if (plist.ElementAt(i).pid == o.pid)
                        {
                            check = false;
                        }
                    }
                    if (check == true)
                    {
                        Console.WriteLine("ProductID is not existed!!");
                    }
                }
                Console.WriteLine("Enter Quantity");
                o.quantity = int.Parse(Console.ReadLine());
                o.oid = orderID;
                o.cid = customerId;
                olist.Add(o);
                Console.WriteLine("More ?(Y/N)");
                checkMore = Console.ReadLine();
            }
        }

        public void orderDetail(List<customer> clist, List<product> plist, List<order> olist, order o)
        {
            Console.WriteLine("----Order Detail----");
            Console.WriteLine("Enter Order ID");
            bool check = true;
            double price = 0;
            string name = null;
            int a = 0;
            List<double> pricelist = new List<double>();
            while (check == true)
            {
                o.oid = int.Parse(Console.ReadLine());
                for (int i = 0; i < olist.Count; i++)
                {
                    if (olist.ElementAt(i).oid == o.oid)
                    {
                        for (int j = 0; j < clist.Count; j++)
                        {
                            if (clist.ElementAt(j).cid == olist.ElementAt(i).cid)
                            {
                                name = clist.ElementAt(j).cname;
                            }
                        }
                        for (int j = 0; j < plist.Count; j++)
                        {
                            if (plist.ElementAt(j).pid == olist.ElementAt(i).pid)
                            {
                                price = olist.ElementAt(i).quantity * plist.ElementAt(j).price;
                                pricelist.Add(price);
                            }
                        }
                        check = false;
                    }
                }
                if (check == false)
                {
                    Console.WriteLine("OrderID: " + o.oid);
                    Console.WriteLine("Customer Name: " + name);
                    Console.WriteLine("{0,10}{1,10}{2,10}", "ProductID  |", "   Quantity  |", "   Price");
                    foreach (order o1 in olist)
                    {
                        if (o1.oid == o.oid)
                        {
                            Console.WriteLine("{0,5}{1,15}{2,15}", o1.pid, o1.quantity, pricelist.ElementAt(a));
                            a++;
                        }
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("Order is not existed!");
                }
            }
        }

        static void Main(string[] args)
        {
            Validate v = new Validate();
            List<order> olist = new List<order>();
            List<product> plist = new List<product>();
            List<customer> clist = new List<customer>();
            int orderID = 1;
            while (true)
            {
                customer c = new customer();
                product p = new product();
                order o = new order();
                Program pro = new Program();
                Console.WriteLine("\n------Menu------");
                Console.WriteLine("1. Enter Customer");
                Console.WriteLine("2. Enter Product");
                Console.WriteLine("3. Enter Order");
                Console.WriteLine("4. Order Details");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");
                int choice = v.checkInput(1, 5);
                switch (choice)
                {
                    case 1:
                        pro.enterCustomer(clist, c);
                        break;
                    case 2:
                        pro.enterProduct(plist, p);
                        break;
                    case 3:
                        pro.enterOrder(clist, plist, olist, o, orderID);
                        orderID++;
                        break;
                    case 4:
                        pro.orderDetail(clist, plist, olist, o);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
