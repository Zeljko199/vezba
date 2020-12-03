using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly MenuItemBusiness menuItemBusiness;

        public Form1()
        {
            InitializeComponent();
            this.menuItemBusiness = new MenuItemBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DataAccessLayer.Models.MenuItem> pom = new List<DataAccessLayer.Models.MenuItem>();

            pom = menuItemBusiness.GetMenuItems();

            listBoxIspis.Items.Clear();

            foreach(DataAccessLayer.Models.MenuItem item in pom)
                listBoxIspis.Items.Add(item.ToString());
        }
    }
}