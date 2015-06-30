using System;
using System.Collections.Generic;
using DAL;
using System.Collections.ObjectModel;

namespace BBL
{
    public class CustomerService
    {
        public static ObservableCollection<Customer> GetAllCustomers(int id)
        {
            return new ObservableCollection<Customer>(CustomerProvider.GetCustomers(id));
        }
        public static int AddUpdateCustomer(Customer ob)
        {
            return CustomerProvider.AddUpdateCustomer(ob);
        }
        

       
    }
}
