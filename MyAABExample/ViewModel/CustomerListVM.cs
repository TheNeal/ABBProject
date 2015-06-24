using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Commands;
using DAL;
using BBL;
using System.Windows.Input;
using Microsoft.Practices.Prism.Regions;
using MyAABExample.Views;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Collections.ObjectModel;


namespace MyAABExample.ViewModel
{
   public class CustomerListVM : BindableBase, INavigationAware
   {
       #region Fields
       public ICommand Add_Customer { get; private set; }

        private readonly IRegionManager regionManager;

        //this is the list of customers
        private ObservableCollection<Customer> _Customers;

        // this is the current customer highlighted in the list
        private Customer _selectedCustomer;
        #endregion

        #region Properties
        public ObservableCollection<Customer> Customers
        {
            get { return this._Customers; }
            set {SetProperty(ref this._Customers, value);}
            
                
        }
       public Customer SelectedCustomer
        {
            get { return this._selectedCustomer; }
           set
           {
               if(_selectedCustomer != value)
               {
                   SetProperty(ref this._selectedCustomer,value);
               }
           }
        }
        #endregion

       #region Constructor
       public CustomerListVM(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this._Customers = CustomerService.GetAllCustomers(0);
            Add_Customer = new DelegateCommand(AddCustomerHandler);
            
        }
        #endregion

        #region Methods
        public void AddCustomerHandler()
        {
            var q = new NavigationParameters();
            q.Add("id",-1);
            regionManager.RequestNavigate(RegionNames.MainRegion, "CustomerAddUpdateView" + q.ToString());
            

        }


        public void Edit()
        {
            if (SelectedCustomer != null )
            {
                
                var q = new NavigationParameters();
                q.Add("id", SelectedCustomer.CustomerID.ToString());
                regionManager.RequestNavigate(RegionNames.MainRegion, "CustomerAddUpdateView" + q.ToString());
                //regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(CustomerAddUpdateView));
            }
        }
        #endregion

        #region Navigation
        public void OnNavigatedTo(NavigationContext navigationContext)
        {

            this.Customers = CustomerService.GetAllCustomers(0);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true; 
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        #endregion
    }
}
