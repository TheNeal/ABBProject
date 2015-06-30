using System;
using System.Collections.Generic;
using DAL;
using System.Collections.ObjectModel;


namespace BBL
{
    public class ItemService
    {
        public static ObservableCollection<Item> GetAllItems(int id)
        {
            return new ObservableCollection<Item>(ItemProvider.GetItem(id));
        }
        public static int AddUpdateItem(Item ob)
        {
            return ItemProvider.AddUpDateItem(ob);
        }
    }
}
