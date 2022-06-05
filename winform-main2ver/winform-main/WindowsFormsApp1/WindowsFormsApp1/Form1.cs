using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.TabPages;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private UserControl1 userctrl ;

        public Form1()
        {
            InitializeComponent();
            userctrl = new UserControl1();
            this.tabPage1.Controls.Add(this.userctrl);
            userctrl.PropertyChanged += Userctrl_PropertyChanged;
        }

        private void Userctrl_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (e.PropertyName=="LabelInput")
            {
                this.OutputLabel.Text = userctrl.LabelInput;
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
