using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            int edad;
          
            edad = int.Parse(txtedad.Text);

            if (edad >= 18)
            {

                MessageBox.Show(("Es mayor de edad, y su edad es: ") + edad + " años ");

            }
            else
            {

                MessageBox.Show(("Es menor de edad, y su edad es: ") + edad + " años ");
            }

            }

        }
    }

