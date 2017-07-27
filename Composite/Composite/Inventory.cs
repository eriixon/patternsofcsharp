using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Inventory : IInventory
    {
        public string Name { get; set; }
        public List<IInventory> Items { get; set; }
        public int Count {
            get
            {
                var count = 0;
                foreach (var item in Items)
                {
                    var itemCount = item.Count;
                    count += itemCount > 0 ? itemCount : 1;
                }
                return count;
            }
        }

        public Inventory()
        {
            Items = new List<IInventory>();
        }

        public void AddItem(IInventory item)
        {
            Items.Add(item);
        }

        public void AddItem(string path, IInventory item)
        {
            IInventory currentInventory = this;
            if (path.Length > 0)
            {
                string[] subpaths = path.Split('/');
                foreach (var subpath in subpaths)
                {
                    var child = currentInventory.GetItem(subpath);
                    if (child == null) currentInventory.AddItem(new Inventory() { Name = subpath });
                    currentInventory = currentInventory.Items.FirstOrDefault(i=>i.Name == subpath);
                }
            }
            currentInventory.AddItem(item);
        }

        public IInventory GetItem(string name)
        {
            IInventory needed = null;
            if (Items.Count > 0 && name != null)
            {
                return Items.FirstOrDefault(item => item.Name == name);
            }
            return needed;
        }

        public IList<IInventory> GetItems()
        {
            return Items;
        }

        public IList<IInventory> GetItems(string path)
        {
            IInventory currentInventory = this;
            if (path.Length > 0)
            {
                string[] subpaths = path.Split('/');
                foreach (var subpath in subpaths)
                {
                    var child = currentInventory.GetItem(subpath);
                    if (child == null) return new List<IInventory>();
                }
            }
            return currentInventory.GetItems();
        }

        public void RemoveItem(IInventory item)
        {
            Items.Remove(item);
        }

        public void RemoveItem(string path, IInventory item)
        {
            IInventory inventory = this;

                var subpaths = path.Split('/');
                foreach (var subpath in subpaths)
                {
                    inventory = inventory.GetItem(subpath);
                    if (inventory == null) return;
                }

            inventory.RemoveItem(item);
        }
    }
}
