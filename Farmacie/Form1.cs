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

    public partial class Form1 : Form 
 
    {
        private List<LibrarieClase.Farmacie> farmacies= new List<LibrarieClase.Farmacie>();
        private IStocareDate stocare = new Fisier();
        public Form1()                                                                              //Initializeaza componente , citeste din fisier si seteza campurile 
        {
            InitializeComponent();
           
            stocare.CitireFisier("Data.txt",farmacies);
            checkBoxEfecteSecundare.SetItemChecked(0, true);
            radioButtonCu.Checked = false;
            radioButtonFara.Checked = true;

           
            comboBoxFiltru.Items.Add(LibrarieClase.Farmacie.EfecteSecundare.Nimic);
            comboBoxFiltru.Items.Add(LibrarieClase.Farmacie.EfecteSecundare.Varsaturi);
            comboBoxFiltru.Items.Add(LibrarieClase.Farmacie.EfecteSecundare.Mancarimi);
            comboBoxFiltru.Items.Add(LibrarieClase.Farmacie.EfecteSecundare.Eruptii);

            comboBoxFiltru.Items.Add("All");
            comboBoxFiltru.SelectedIndex = comboBoxFiltru.Items.Count-1;
        }

       

       

        private void adaugare_click(object sender, EventArgs e) //se valideaza la inceput daca exista medicamentul pe stoc , in caz contrar adauga elemente in fisier iar la final se reseteaza campurile
        {
            foreach (var item in farmacies) 
            {
                if(item.MedNume.Equals(textBoxNume.Text))
                {
                    MessageBox.Show("Medicamentul este deja pe stoc");
                    return; 
                }

            }
            if(textBoxNume.Text.Equals(String.Empty))
            {
                MessageBox.Show("Nume camp obligatoriu");
                return;
            }
            if (textBoxPret.Text.Equals(String.Empty))
            {
                MessageBox.Show("Pret camp obligatoriu");
                return;
            }
            if (textBoxNumarul.Text.Equals(String.Empty))
            {
                MessageBox.Show("Numar camp obligatoriu");
                return;
            }

            LibrarieClase.Farmacie farmacie = new LibrarieClase.Farmacie();
            farmacie.MedNume = textBoxNume.Text;
            
            farmacie.MedPret = int.Parse(textBoxPret.Text);
            farmacie.MedNr = int.Parse(textBoxNumarul.Text);
            if (radioButtonCu.Checked)
                farmacie.Prescriptie1 = LibrarieClase.Farmacie.Prescriptie.Cu;
            else
                farmacie.Prescriptie1 = LibrarieClase.Farmacie.Prescriptie.Fara;
            farmacie.EfecteSecundare1 = LibrarieClase.Farmacie.EfecteSecundare.Nimic;
           
            if(checkBoxEfecteSecundare.GetItemChecked(1))
                {
                farmacie.EfecteSecundare1 |= LibrarieClase.Farmacie.EfecteSecundare.Mancarimi;            //Se impacheteaza bitii
                }
            if (checkBoxEfecteSecundare.GetItemChecked(2))
            {
                farmacie.EfecteSecundare1 |= LibrarieClase.Farmacie.EfecteSecundare.Varsaturi;
            }
            if (checkBoxEfecteSecundare.GetItemChecked(3))
            {
                farmacie.EfecteSecundare1 |= LibrarieClase.Farmacie.EfecteSecundare.Eruptii;
            }

            farmacies.Add(farmacie);

            stocare.ScrieFisier("Data.txt", farmacies);

            textBoxNume.Text = string.Empty;
            textBoxPret.Text = string.Empty;
            textBoxNumarul.Text = string.Empty;
            radioButtonCu.Checked = false;
            radioButtonFara.Checked = true;
            checkBoxEfecteSecundare.SetItemChecked(0, true);
            checkBoxEfecteSecundare.SetItemChecked(1, false);
            checkBoxEfecteSecundare.SetItemChecked(2, false);
            checkBoxEfecteSecundare.SetItemChecked(3, false);
            stocare.ScrieFisier("Data.txt", farmacies);
        }

        private void editare_click(object sender, EventArgs e) // se editeaza datele din fisier in functie de nume si se reseteaza campurile dupa utilizarea acestora
        {
            bool exista=false;
            foreach (var item in farmacies)
            {
                if (item.MedNume.Equals(textBoxNume.Text))
                {
                    exista = true;
                }
                
            }
            if(exista==false)
            {
                MessageBox.Show("Medicamentul  nu exista in stoc");
                return;
            }
           
            if (textBoxPret.Text.Equals(String.Empty))
            {
                MessageBox.Show("Pret camp obligatoriu");
                return;
            }
            if (textBoxNumarul.Text.Equals(String.Empty))
            {
                MessageBox.Show("Numar camp obligatoriu");
                return;
            }

            LibrarieClase.Farmacie farmacie = new LibrarieClase.Farmacie();

            farmacie.MedNume = textBoxNume.Text;

            farmacie.MedPret = int.Parse(textBoxPret.Text);
            farmacie.MedNr = int.Parse(textBoxNumarul.Text);
            if (radioButtonCu.Checked)
                farmacie.Prescriptie1 = LibrarieClase.Farmacie.Prescriptie.Cu;
            else
                farmacie.Prescriptie1 = LibrarieClase.Farmacie.Prescriptie.Fara;
            farmacie.EfecteSecundare1 = LibrarieClase.Farmacie.EfecteSecundare.Nimic;

            if (checkBoxEfecteSecundare.GetItemChecked(1))
            {
                farmacie.EfecteSecundare1 |= LibrarieClase.Farmacie.EfecteSecundare.Mancarimi;
            }
            if (checkBoxEfecteSecundare.GetItemChecked(2))
            {
                farmacie.EfecteSecundare1 |= LibrarieClase.Farmacie.EfecteSecundare.Varsaturi;
            }
            if (checkBoxEfecteSecundare.GetItemChecked(3))
            {
                farmacie.EfecteSecundare1 |= LibrarieClase.Farmacie.EfecteSecundare.Eruptii;
            }

           

            stocare.Editare(farmacie.MedNume,farmacie,farmacies);

            textBoxNume.Text = string.Empty;
            textBoxPret.Text = string.Empty;
            textBoxNumarul.Text = string.Empty;
            radioButtonCu.Checked = false;
            radioButtonFara.Checked = true;
            checkBoxEfecteSecundare.SetItemChecked(0, true);
            checkBoxEfecteSecundare.SetItemChecked(1, false);
            checkBoxEfecteSecundare.SetItemChecked(2, false);
            checkBoxEfecteSecundare.SetItemChecked(3, false);
            stocare.ScrieFisier("Data.txt", farmacies);
        }

        private void stergere_click(object sender, EventArgs e)                              // sterge un element din fisier in functie de nume
        {
            stocare.Stergere(textBoxNume.Text, new LibrarieClase.Farmacie(), farmacies);
            stocare.ScrieFisier("Data.txt", farmacies);
        }

        private void buttonAfisare_Click(object sender, EventArgs e)  //afiseaza in dataGridView elementele din fisier
        {
            dataGridViewAfisare.Rows.Clear();
            if(comboBoxFiltru.SelectedItem.Equals("All"))
            {
                foreach (var far in farmacies)
                {
                    

                        dataGridViewAfisare.Rows.Add(far.MedNume, far.MedPret, far.MedNr, far.EfecteSecundare1, far.Prescriptie1);
                    
                }
                return;
            }
            LibrarieClase.Farmacie.EfecteSecundare es;
            Enum.TryParse<LibrarieClase.Farmacie.EfecteSecundare>(comboBoxFiltru.SelectedItem.ToString(), out es);           // transforma elementul din filtru selectat in enumeratie de tip efecte secundare
            foreach (var far in farmacies )
            {
               if(far.EfecteSecundare1==LibrarieClase.Farmacie.EfecteSecundare.Nimic && es==LibrarieClase.Farmacie.EfecteSecundare.Nimic || 
                    (es&far.EfecteSecundare1)!=LibrarieClase.Farmacie.EfecteSecundare.Nimic)                                // & bitii se suprapun si cauta daca au efecte secundare comune(pe acelasi bit)
                    

                dataGridViewAfisare.Rows.Add( far.MedNume, far.MedPret, far.MedNr, far.EfecteSecundare1, far.Prescriptie1);

            }
        }

        private void textBoxPret_KeyPress(object sender, KeyPressEventArgs e)   //verifica daca tasta apasata este cifra sau tasta de control
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumarul_KeyPress(object sender, KeyPressEventArgs e) // la fel ca sus doar ca e vorba de numar
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBoxEfecteSecundare_Click(object sender, EventArgs e) //verifica daca elementul 0 e selectat(Nimic), daca da se deselecteaza restul itemelor altfel se deselecteaza nimic
        {
            CheckedListBox clb = (CheckedListBox)sender;
            if (clb.SelectedIndex == 0)
            {
                for (int i = 1; i < clb.Items.Count; i++)
                {
                    clb.SetItemChecked(i, false);
                }
            }
            else
            {
                clb.SetItemChecked(0, false);
            }
        }

        private void dataGridViewAfisare_MouseClick(object sender, MouseEventArgs e) //Selecteaza o linie si completeaza campurile din stanga
        {
            if (dataGridViewAfisare.SelectedRows.Count< 1)
                return;

            textBoxNume.Text= (string)dataGridViewAfisare.SelectedRows[0].Cells[0].Value;
            textBoxPret.Text= ((int)dataGridViewAfisare.SelectedRows[0].Cells[1].Value).ToString();
            textBoxNumarul.Text= ((int)dataGridViewAfisare.SelectedRows[0].Cells[2].Value).ToString();
            radioButtonCu.Checked = ((LibrarieClase.Farmacie.Prescriptie)dataGridViewAfisare.SelectedRows[0].Cells[4].Value) == LibrarieClase.Farmacie.Prescriptie.Cu;
            radioButtonFara.Checked = ((LibrarieClase.Farmacie.Prescriptie)dataGridViewAfisare.SelectedRows[0].Cells[4].Value) == LibrarieClase.Farmacie.Prescriptie.Fara;
           
            LibrarieClase.Farmacie.EfecteSecundare efecteSecundare = (LibrarieClase.Farmacie.EfecteSecundare)dataGridViewAfisare.SelectedRows[0].Cells[3].Value;



            for (int i = 0; i < checkBoxEfecteSecundare.Items.Count; i++)
            {
                checkBoxEfecteSecundare.SetItemChecked(i, false);
            }
            if (efecteSecundare == LibrarieClase.Farmacie.EfecteSecundare.Nimic)
            {
                checkBoxEfecteSecundare.SetItemChecked(0, true);
            }
            if ((efecteSecundare & LibrarieClase.Farmacie.EfecteSecundare.Mancarimi ) != LibrarieClase.Farmacie.EfecteSecundare.Nimic)  //verifica daca au bit comun pe efectul secundar(Mancarimi)
            {
                checkBoxEfecteSecundare.SetItemChecked(1, true);

            }
            if ((efecteSecundare & LibrarieClase.Farmacie.EfecteSecundare.Varsaturi) != LibrarieClase.Farmacie.EfecteSecundare.Nimic)
            {
                checkBoxEfecteSecundare.SetItemChecked(2, true);

            }
            if ((efecteSecundare & LibrarieClase.Farmacie.EfecteSecundare.Eruptii) != LibrarieClase.Farmacie.EfecteSecundare.Nimic)
            {
                checkBoxEfecteSecundare.SetItemChecked(3, true);

            }
        }

        
    }
}
