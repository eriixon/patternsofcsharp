using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //public interface IInventory
    //{
    //    void AddItem(IInventory item);
    //    void Remove(IInventory item);
    //    IInventory GetItem(int index);
    //    List<IInventory> Items { get; set; }
    //    string Name { get; set; }
    //}
    public interface IInventory
    {
        List<IInventory> Items { get; set; }
        string Name { get; set; }
        int Count { get; }
        void AddItem(IInventory item);
        void AddItem(string path, IInventory item);
        void RemoveItem(IInventory item);
        void RemoveItem(string path, IInventory item);
        IInventory GetItem(string name);
        IList<IInventory> GetItems();
        IList<IInventory> GetItems(string path);
    }
}
