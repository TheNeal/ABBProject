using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using DAL;
using BBL;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using System.Windows.Input;

namespace MyAABExample.ViewModel
{
    public class NavigationViewModel : BindableBase
    {
        private IRegionManager regionManager;
       
        public ICommand CatEdit { get; private set; }
        public ICommand CustEdit { get; private set; }
        public ICommand CompanyEdit { get; private set; }
        
        public NavigationViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            CatEdit = new DelegateCommand(LoadCategoryView);
            CustEdit = new DelegateCommand(LoadCustEdit);
            CompanyEdit = new DelegateCommand(LoadCompanyEdit);
        }
        private void LoadCategoryView()
        {
            regionManager.RequestNavigate(RegionNames.MainRegion, "CategoryView");

        }
        private void LoadCustEdit()
        {
            regionManager.RequestNavigate(RegionNames.MainRegion, "CustList");
        }
        private void LoadCompanyEdit()
        {
            regionManager.RequestNavigate(RegionNames.MainRegion, "CompanyView");
        }
    }
}
