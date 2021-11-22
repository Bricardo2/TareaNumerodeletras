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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = this.txtcaracteres.Text;
            int cont = 0;
            char es = ' ';

            for (int i = 0; i < palabra.Length; i++)
            {

                if ((palabra[i] == ' ' && es != ' ') || (i == palabra.Length - 1 && palabra[i] != ' '))
                {


                    cont++;

                }
                es = palabra[i];
            }
            this.txtCantidad.Text = cont.ToString();

        }
    }
}
