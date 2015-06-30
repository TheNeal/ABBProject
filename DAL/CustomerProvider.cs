using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerProvider
    {
        public static List<Customer> GetCustomers(int CustID)
        {
            List<Customer> _customers = null;
            using (ABBEntities db = new ABBEntities())
            {
               _customers = (from u in db.Customers where ((CustID == null) | (u.CustomerID == CustID) | (CustID == 0)) select u).ToList();
            }
            return _customers;
        }

        public static int AddUpdateCustomer(Customer ob)
        {
            int customerid = 0;
            using (ABBEntities db = new ABBEntities())
            {
                if (ob.CustomerID>0)
                {
                    Customer checkifexist = db.Customers.Where(u => u.CustomerID == ob.CustomerID).FirstOrDefault();
                    if (checkifexist != null)
                    {
                        checkifexist.CustomerID = ob.CustomerID;
                        checkifexist.CustomerFirstName = ob.CustomerFirstName;
                        checkifexist.CustomerLastName = ob.CustomerLastName;                      
                        checkifexist.PhoneNumber = ob.PhoneNumber;
                        checkifexist.Address = ob.Address;
                        checkifexist.City = ob.City;
                        checkifexist.St = ob.St;
                        checkifexist.Zip = ob.Zip;
                        checkifexist.Country = ob.Country;
                     }
                }
                else
                {
                    db.Customers.Add(ob);
                }
                int saved = db.SaveChanges();
                if(saved > 0)
                {
                    customerid = ob.CustomerID;
                }
            }
            return customerid;
        }
    }
}
