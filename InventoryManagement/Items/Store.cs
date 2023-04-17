

namespace InventoryManagement.Items
{
    public class Store
    {
        private ObjectLinkedList shelfs;
        public string Name { get; set; }
        public int Count { get; set; } = 0;

        public Shelf this[int index]
        {
            get
            {
                if (shelfs.Count == 0) return null;
                if (index < 0 || index >= shelfs.Count) return null;
                if (shelfs?[index] == null) return null;
                return (Shelf)shelfs[index];
            }
        }

        public bool IsEmpty()
        {
            if (Count == 0) return true;
            bool emptyShelfs = true;
            foreach (Shelf sf in shelfs)
            {
                if (!sf.IsEmpty())
                {
                    emptyShelfs = false;
                    break;
                }
            }
            return emptyShelfs;
        }
        public Store(string name)
        {
            this.shelfs = new ObjectLinkedList();
            this.Name = name;
        }

        public void AddShelf(Shelf item)
        {

            shelfs.Add(item);
            Count = shelfs.Count;
        }
        public void DeleteShelf(int index)
        {
            shelfs.RemoveAt(index);
            Count = shelfs.Count;
        }

        public ObjectLinkedList GetAll()
        {
            ObjectLinkedList shelfs = new ObjectLinkedList();
            for (int i = 0; i < Count; i++)
            {
                shelfs.Add(this[i]);
            }
            return shelfs;
        }

        public void StoreInfo()
        {
            Console.WriteLine(this.Name + ", " + this.Count);
            for (int i = 0; i < Count; i++)
            {
                Shelf shelf = this[i];
                Console.WriteLine($"{shelf.Id} {shelf.Name} {shelf.ItemsCount} {shelf.Capacity} {shelf.shelfCategory} ");
                for (int j = 0; j < shelf.ItemsCount; j++)
                {
                    Item it = shelf[j];
                    Console.WriteLine(it.ToString());
                }
            }
        }
    }
}
