using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Windows;
using BBL;
using DAL;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;


namespace MyAABExample.ViewModel
{
    public class CompanyViewModel : BindableBase, INavigationAware
    {
        #region Fields and Properties
        public ICommand AddCompanyButton { get; private set; }
        private ObservableCollection<Company> _companies;
        private Company _selectedCompany;
        private string _btnAddCompanyContent;

        public ObservableCollection<Company> Companies
        {
            get { return _companies; }
            set { SetProperty(ref _companies, value); }
        }
        public Company SelectedCompany
        {
            get { return _selectedCompany; }
            set
            {
                if (_selectedCompany != value)
                {
                    SetProperty(ref _selectedCompany, value);
                }
                if (_selectedCompany.CompanyID > 0)
                {
                    btnAddCompanyContent = "Update Company";
                }
                else
                {
                    btnAddCompanyContent = "Add Company";
                }
            }
        }

        public string btnAddCompanyContent
        {
            get { return _btnAddCompanyContent; }
            set {SetProperty(ref _btnAddCompanyContent,value);}
        }
        #endregion

        #region Constructor
        public CompanyViewModel()
        {
            _companies = CompanyService.GetAllCompanies(0);
            AddCompanyButton = new DelegateCommand(AddCompanyHandler);
            btnAddCompanyContent = "Add Company";
        }
        #endregion

        #region Button Handlers
        public void AddCompanyHandler()
        {
            if (SelectedCompany != null)
            {
                int id = CompanyService.AddUpdateCompany(SelectedCompany);
                Companies = CompanyService.GetAllCompanies(0);
            }
            else
            {
                MessageBox.Show(" You must create a new customer first!");
            }
        }
        #endregion

        #region Navigation
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
        #endregion 
    }
}
