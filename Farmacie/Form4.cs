using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieClase;
//Hincu Andrei grupa 3122A
namespace Farmacie
{
    public partial class Form4 : Form
    {
        private List<LibrarieClase.Farmacie> farmacies = new List<LibrarieClase.Farmacie>();
        private IStocareDate stocare = new Fisier();
        public Form4()               // fac legatura cu cu datele din fisier si le pun pe dataGridView
        {
            InitializeComponent();
            stocare.CitireFisier("Data.txt", farmacies);
            foreach (var far in farmacies)
            {


            dataGridViewAfisare.Rows.Add(far.MedNume, far.MedPret, far.MedNr, far.EfecteSecundare1, far.Prescriptie1);

            }
        }

        private void buttonCumpara_Click(object sender, EventArgs e)                                                                                        // la click pe buton cauta medicamentul in fisier si i se  scade cantitatea, iar la final actualizez datele din fisier
        {
            LibrarieClase.Farmacie f = stocare.Cautare(textBoxNume.Text, farmacies);
            f.MedNr -= int.Parse(textBoxCantitate.Text);
            stocare.Editare(f.MedNume, f, farmacies);
            dataGridViewAfisare.Rows.Clear();
            textBoxNume.Text = String.Empty;
            textBoxCantitate.Text = String.Empty;
            foreach (var far in farmacies)
            {


                dataGridViewAfisare.Rows.Add(far.MedNume, far.MedPret, far.MedNr, far.EfecteSecundare1, far.Prescriptie1);

            }
            stocare.ScrieFisier("Data.txt",farmacies);
        }
        private void dataGridViewAfisare_MouseClick(object sender, MouseEventArgs e)            //la click pe linie dau fill la campurile din stanga
        {
            if (dataGridViewAfisare.SelectedRows.Count < 1)
                return;

            textBoxNume.Text = (string)dataGridViewAfisare.SelectedRows[0].Cells[0].Value;
            
            textBoxCantitate.Text = ((int)dataGridViewAfisare.SelectedRows[0].Cells[2].Value).ToString();
           

            
        }
        
    }
}
