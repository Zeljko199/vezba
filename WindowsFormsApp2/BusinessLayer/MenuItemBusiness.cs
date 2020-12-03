using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessLayer
{
    class MenuItemBusiness
    {
        private readonly MenuItemRepository menuItemRepository;
        public MenuItemBusiness()
        {
            this.menuItemRepository = new MenuItemRepository();
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItemRepository.GetAllMenuItems();
        }
        public List<MenuItem> GetMenuItemsPrice(double min, double max)
        {
            return menuItemRepository.GetAllMenuItems().Where(m => m.Price > min && m.Price < max).ToList();
        }

        public int addMenuItem(MenuItem item)
        {
            return menuItemRepository.InsertMenuItem(item);
        }

    }
}
