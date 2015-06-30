using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using DAL;
using BBL;
using Microsoft.Practices.Prism.Regions;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System;

namespace MyAABExample.ViewModel
{
    public class CustomerAddUpdateViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager regionManager;
        public ICommand Save_Button { get; private set; }
        public ICommand Cancel_Button { get; private set; }
        private IList<Customer> _customer;
        private int rowIndex;
       
               
        public Customer SelectedCustomer
        {
            get { return this._customer[rowIndex]; }
            
        }

        public CustomerAddUpdateViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this._customer = CustomerService.GetAllCustomers(1);
            Save_Button = new DelegateCommand(SaveButtonHandler);
            Cancel_Button = new DelegateCommand(CancelButtonHandler);
            
        }
        #region Navigation
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }
        public void OnNavigatedFrom(NavigationContext navigationContext)
        { }
        
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            object id = navigationContext.Parameters["id"];
            if (Convert.ToInt32(id) > -1 )
            {
                this._customer = CustomerService.GetAllCustomers(Convert.ToInt32(id));
                rowIndex=0;
            }
            else
            {
                this._customer.Add(new Customer());
                rowIndex=this._customer.Count - 1;
                
            }
         }
        #endregion

        #region ButtonHandlers
        public void SaveButtonHandler()
        {
            int id = CustomerService.AddUpdateCustomer(SelectedCustomer);
            regionManager.RequestNavigate(RegionNames.MainRegion, "CustList");
        }
        public void CancelButtonHandler()
        {
            regionManager.RequestNavigate(RegionNames.MainRegion, "CustList");
        }
        #endregion
    }
}
