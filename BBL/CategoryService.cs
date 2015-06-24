using System;
using System.Collections.Generic;
using DAL;
using System.Collections.ObjectModel;


namespace BBL
{
    public class CategoryService
    {
        public static ObservableCollection<Category> GetAllCategories(int id)
        {
            return new ObservableCollection<Category>(CategoryProvider.GetCategory(id));
        }
        public static int AddUpdateCategory(Category ob)
        {
            return CategoryProvider.AddUpDateCategory(ob);
        }
    }
}
