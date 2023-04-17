using InventoryManagement.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.SerializerDeserializer
{
    public class ItemWriter
    {
        public static void WriteToFile(Store store, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, false))
                {
                    //write store data
                    bw.Write(store.Name);
                    bw.Write(store.Count);

                    foreach (Shelf sf in store.GetAll())
                    {
                        //write shelf data
                        bw.Write(sf.Id);
                        bw.Write(sf.Name);
                        bw.Write(sf.ItemsCount);
                        bw.Write(sf.Capacity);
                        bw.Write(SerializeCategory(sf.shelfCategory));
                        foreach (Item it in sf.GetAll())
                        {
                            //write item data
                            bw.Write(it.Id);
                            bw.Write(it.Name);
                            bw.Write(it.Price);
                            bw.Write(it.Quantity);
                            bw.Write(SerializeCategory(it.Category));
                            bw.Write(it.Description);
                        }
                    }
                }
            }
        }
        private static int SerializeCategory(Category ct)
        {
            switch (ct)
            {
                case Category.None: return 0;
                case Category.Meat: return 1;
                case Category.Fish: return 2;
                case Category.Dairy: return 3;
                case Category.Vegetables: return 4;
                case Category.Fruits: return 5;
                case Category.Freezer: return 6;
                case Category.Alcohol: return 7;
                case Category.DriedGoods: return 8;
                case Category.Snacks: return 9;
                case Category.Care: return 10;
                default: return 0;
            }
        }
    }
}
