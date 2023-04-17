using InventoryManagement.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.SerializerDeserializer
{
    public class ItemReader
    {
        public static Store ReadFile(string file)
        {
            Store readedStore = null;

            using (BinaryReader rd = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                //read store data
                string store_name = rd.ReadString();
                int store_count = rd.ReadInt32();
                readedStore = new Store(store_name);
                readedStore.Count = store_count;

                //read shelf data
                for (int i = 0; i < store_count; i++)
                {
                    string sf_id = rd.ReadString();
                    string sf_name = rd.ReadString();
                    int sf_count = rd.ReadInt32();
                    int sf_capacity = rd.ReadInt32();
                    Category sf_category = DeserializeCategory(rd.ReadInt32());

                    Shelf sf = new Shelf(sf_id, sf_name, sf_category, sf_capacity);
                    //read items data
                    for (int j = 0; j < sf_count; j++)
                    {
                        string it_id = rd.ReadString();
                        string it_name = rd.ReadString();
                        int it_price = rd.ReadInt32();
                        int it_quantity = rd.ReadInt32();
                        Category it_ctg =
                            DeserializeCategory(rd.ReadInt32());
                        string it_descr = rd.ReadString();

                        Item it = new Item(it_id, it_name, it_ctg, it_price, it_quantity, it_descr);
                        sf.Add(it);
                    }
                    readedStore.AddShelf(sf);
                }

            }
            return readedStore;
        }

        private static Category DeserializeCategory(int category)
        {
            switch (category)
            {
                case 0: return Category.None;
                case 1: return Category.Meat;
                case 2: return Category.Fish;
                case 3: return Category.Dairy;
                case 4: return Category.Vegetables;
                case 5: return Category.Fruits;
                case 6: return Category.Freezer;
                case 7: return Category.Alcohol;
                case 8: return Category.DriedGoods;
                case 9: return Category.Snacks;
                case 10: return Category.Care;
                default: return Category.None;
            }
        }
    }
}
