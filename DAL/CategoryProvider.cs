using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryProvider
    {
        public static List<Category> GetCategory(int CategoryID)
        {
            List<Category> _category = null;
            using (ABBEntities db = new ABBEntities())
            {
                _category = (from u in db.Categories where ((CategoryID == null) | (u.CategoryId == CategoryID) | (CategoryID == 0)) select u).ToList();
            }
            return _category;
        }

        public static int AddUpDateCategory(Category ob)
        {
            int categoryid = 0;
            using (ABBEntities db = new ABBEntities())
            {
                if (ob.CategoryId>0)
                {
                    Category ExistingCat = db.Categories.Where(u => u.CategoryId == ob.CategoryId).FirstOrDefault();
                    if (ExistingCat!=null)
                    {
                        ExistingCat.CategoryId = ob.CategoryId;
                        ExistingCat.CategoryName = ob.CategoryName;
                    }
                }
                else 
                {
                    db.Categories.Add(ob);
                }
                int saved = db.SaveChanges();
                if (saved > 0)
                {
                    categoryid = ob.CategoryId;
                }
                return categoryid;
            }
        }
        
 
    }
}
