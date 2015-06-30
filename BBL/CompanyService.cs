using System;
using System.Collections.Generic;
using DAL;
using System.Collections.ObjectModel;


namespace BBL
{
    public class CompanyService
    {
        public static ObservableCollection<Company> GetAllCompanies(int id)
        {
            return new ObservableCollection<Company>(CompanyProvider.GetCompany(id));
        }
        public static int AddUpdateCompany(Company ob)
        {
            return CompanyProvider.AddUpDateCompany(ob);
        }
    }
}
