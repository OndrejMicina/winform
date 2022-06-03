using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.TabPages
{
    public partial class UserControl1 : UserControl
    {
        public string text { get; set; }
        public UserControl1()
        {
            InitializeComponent();

            
        }


        public void button1_Click(object sender, EventArgs e)
        {
            text = this.NameLabel.Text;

        }


    }
}
