using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Hincu Andrei grupa 3122A
namespace Farmacie
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonLogin1_Click(object sender, EventArgs e)                 // verifica userul si parola
        {
            if (textBoxUser.Text == "admin" && textBoxParola.Text == "admin")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nume sau parola gresita!");    
                return;
            }
        }



        private void textBoxUser_KeyDown(object sender, KeyEventArgs e) //validare prin enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxUser.Text == "admin" && textBoxParola.Text == "admin")
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nume sau parola gresita!");
                    return;
                }
            }
        }
    }
}
