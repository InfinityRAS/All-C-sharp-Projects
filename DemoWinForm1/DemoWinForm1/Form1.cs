using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForm1
{
    public partial class DemoWinForm : Form
    {
        public DemoWinForm()
        {
            InitializeComponent();
        }

        private void Form1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
