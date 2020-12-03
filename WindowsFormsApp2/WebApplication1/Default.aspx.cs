using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private MenuItemBusiness menuItemBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.menuItemBusiness = new MenuItemBusiness();

            List<DataAccessLayer.Models.MenuItem> pom = new List<DataAccessLayer.Models.MenuItem>();

            pom = menuItemBusiness.GetMenuItems();

            zekica.Items.Clear();

            foreach (DataAccessLayer.Models.MenuItem item in pom)
                zekica.Items.Add(item.ToString());
        }
    }
}