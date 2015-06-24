using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompanyProvider
    {
        public static List<Company> GetCompany(int CompanyID)
        {
            List<Company> _company = null;
            using (ABBEntities db = new ABBEntities())
            {
                _company = (from u in db.Companies where ((CompanyID == null) | (u.CompanyID == CompanyID) | (CompanyID == 0)) select u).ToList();
            }
            return _company;
        }

        public static int AddUpDateCompany(Company ob)
        {
            int companyid = 0;
            using (ABBEntities db = new ABBEntities())
            {
                if (ob.CompanyID > 0)
                {
                    Company ExistingCompany= db.Companies.Where(u => u.CompanyID == ob.CompanyID).FirstOrDefault();
                    if (ExistingCompany != null)
                    {
                        
                        ExistingCompany.CompanyName = ob.CompanyName;
                        ExistingCompany.CompanyID = ob.CompanyID;
                    }
                }
                else
                {
                    db.Companies.Add(ob);
                }
                int saved = db.SaveChanges();
                if (saved > 0)
                {
                    companyid = ob.CompanyID;
                }
                return companyid;
            }
        }
    }
}
