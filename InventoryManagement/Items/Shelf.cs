

using System.Media;
using System.Numerics;

namespace InventoryManagement.Items
{
    public class Shelf
    {
        private ObjectLinkedList items;

        public string Id { get; set; }
        public string Name { get; set; }
        public int ItemsCount { get; set; } = 0;
        public int Capacity { get; set; }
        public Category shelfCategory { get; }

        public int ShelfLoad { get; set; } = 0;

        public Item this[int index]
        {
            get
            {
                if (items.Count == 0) return null;
                if (index < 0 || index >= items.Count) return null;
                if (items?[index] == null) return null;
                return (Item)items[index];
            }
            set
            {
                if (!(index < 0 || index >= items.Count)) items[index] = value;

            }
        }
        public bool IsEmpty()
        {
            return ItemsCount == 0;
        }
        public Shelf(string id, string name, Category category, int maxCapacity)
        {
            this.Id = id;
            this.items = new ObjectLinkedList();
            this.Name = name;
            this.shelfCategory = category;
            this.Capacity = maxCapacity;

        }

        public void Add(Item item)
        {
            if (ItemsCount == Capacity) return;
            if (Capacity < ShelfLoad + item.Quantity) return;
            if (this.shelfCategory != Category.None && item.Category != this.shelfCategory) return;
            items.Add(item);
            ItemsCount = items.Count;
            ShelfLoad += item.Quantity;
        }
        public void Delete(int index)
        {
            Item remove = (Item)items[index];
            items.RemoveAt(index);
            ItemsCount = items.Count;
            ShelfLoad -= remove.Quantity;
        }

        public void ReplaceItem(int index, Item item) 
        {
            Item old = (Item)items[index];
            ShelfLoad += item.Quantity - old.Quantity; ;
            items.RemoveAt(index);
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
            ItemsCount = 0;
        }

        public ObjectLinkedList GetAll()
        {
            ObjectLinkedList items = new ObjectLinkedList();
            for (int i = 0; i < ItemsCount; i++)
            {
                items.Add(this[i]);
            }
            return items;
        }


    }
}
