using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemProvider
    {
        public static List<Item> GetItem(int ItemID)
        {
            List<Item> _item = null;
            using (ABBEntities db = new ABBEntities())
            {
                _item = (from u in db.Items where ((ItemID == null) | (u.ItemId == ItemID) | (ItemID == 0)) select u).ToList();
            }
            return _item;
        }

        public static int AddUpDateItem(Item ob)
        {
            int itemid = 0;
            using (ABBEntities db = new ABBEntities())
            {
                if (ob.ItemId > 0)
                {
                    Item ExistingItem = db.Items.Where(u => u.ItemId == ob.ItemId).FirstOrDefault();
                    if (ExistingItem != null)
                    {
                        ExistingItem.CategoryId = ob.CategoryId;
                        ExistingItem.ItemName = ob.ItemName;
                        ExistingItem.ItemId = ob.ItemId;
                    }
                }
                else
                {
                    db.Items.Add(ob);
                }
                int saved = db.SaveChanges();
                if (saved > 0)
                {
                    itemid = ob.ItemId;
                }
                return itemid;
            }
        }
    }
}
