using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaNumerodeletras
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caracter = this.txtcaracter.ToString();
            
            string cont= "";
            for (int i = caracter.Length-1; i >= 0; i--)
            {
                cont = cont + caracter[i];
            }
            this.txtresul.Text = cont.ToString();
        }
    }
}
