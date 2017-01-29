using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlugInContract;

namespace EvideaWindowsFormSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<IMenuCreator> cmdList = PlugInStarter.PlugInStarter.Start();
            List<string> menuList = cmdList[0].MenuList;
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = "HumanResources";
            menuStrip1.Items.Insert(0,item);
            for (int i = 0; i < menuList.Count; i++)
            {
                item.DropDownItems.Add(menuList[i]);
            }
        }
    }
}
