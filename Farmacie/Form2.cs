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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)  // la click pe admin programul se duce in formul login admin
        {
            this.Hide();
            Form3 f3 = new Form3();
            var a = f3.ShowDialog();

            this.Show();
            
        }

        private void buttonClient_Click(object sender, EventArgs e)  // la click programul se duce pe formul client
        {
            this.Hide();
            Form4 f4 = new Form4();
            var a = f4.ShowDialog();
            this.Show();
        }
    }
}
