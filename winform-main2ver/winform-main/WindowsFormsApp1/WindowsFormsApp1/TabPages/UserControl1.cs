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
        private string labelInput;

        public string LabelInput
        {
            get { return labelInput; }
            set
            {
                if (labelInput == value) return;
                labelInput = value;
                OnPropertyChanged(nameof(LabelInput));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public UserControl1()
        {
            InitializeComponent();

            
        }


        public void button1_Click(object sender, EventArgs e)
        {
            LabelInput = this.textBox1.Text;
        }


    }
}
