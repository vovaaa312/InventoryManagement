

namespace InventoryManagement.Items
{
    public class Store
    {
        private ObjectLinkedList shelves;
        public string Name { get; set; }
        public int Count { get; set; } = 0;

        public Shelf this[int index]
        {
            get
            {
                if (shelves.Count == 0) return null;
                if (index < 0 || index >= shelves.Count) return null;
                if (shelves?[index] == null) return null;
                return (Shelf)shelves[index];
            }
        }

        public bool IsEmpty()
        {
            if (Count == 0) return true;
            bool emptyShelfs = true;
            foreach (Shelf sf in shelves)
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
            this.shelves = new ObjectLinkedList();
            this.Name = name;
        }

        public void AddShelf(Shelf item)
        {

            shelves.Add(item);
            Count = shelves.Count;
        }
        public void DeleteShelf(int index)
        {
            
            shelves.RemoveAt(index);
            Count = shelves.Count;
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
