using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void TopLevelButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(topLevelMenu.Text))
            {
                ToolStripItem mainMenuItem = new ToolStripDropDownButton(topLevelMenu.Text);
                menuStrip.Items.Add(mainMenuItem);
            }
        }

        private void SubItemButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(subItem.Text))
            {
                foreach (ToolStripDropDownButton item in menuStrip.Items)
                {
                    if (item.Text == topLevelMenu.Text)
                        item.DropDownItems.Add(subItem.Text);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
