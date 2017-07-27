using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Player
    {
        private Inventory inventory;

        public Player()
        {
            inventory = new Inventory() { Name = "Inventory" };
            var weapons = new Inventory() { Name = "Weapons" };
            inventory.AddItem(weapons);

            var gems = new Inventory() { Name = "Gems" };
            inventory.AddItem(gems);

            var rubies = new Inventory() { Name = "Rubies" };
            gems.AddItem(rubies);
        }

        public void AddInventory(IInventory item, string path)
        {
            var parent = inventory.Items.FirstOrDefault(i => i.Name == path);
            if( parent != null) parent.AddItem(item);
        }

        public void AddInventory(IInventory item)
        {
            IInventory list = null;

            if(item is IWeapon)
            {
                list = inventory.Items.FirstOrDefault(i => i.Name == "Weapons");
            }

            if (item is IRuby)
            {
                var gems = inventory.Items.FirstOrDefault(i => i.Name == "Gems");
                if(gems != null)
                {
                    list = gems.Items.FirstOrDefault(i => i.Name == "Rubies");
                }
            }

            if (list != null)
            {
                list.AddItem(item);
            }
        }
    }
}
