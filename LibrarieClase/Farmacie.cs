using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hincu Andrei grupa 3122A
namespace LibrarieClase
{
    public class Farmacie
    {
        public enum Prescriptie   //enumeratie cu sau fara prescriptie
        {
            Cu,Fara


        }
        [Flags]
        public enum EfecteSecundare                         //enumeratie cu flag ce imi permite sa impachetez efectele secundare pe biti
        {
         Mancarimi=1,Varsaturi=2,Eruptii=4,Nimic=0
                


        }

       
        private int medID;
        private string medNume;
        private int medPret;
        private int medNr;
        private Prescriptie prescriptie;
        private EfecteSecundare efecteSecundare;
        private int x;


        public Farmacie()                     //constructor default
        {
           
            MedNume = null;
            MedPret = 0;
            MedNr = 0;
            prescriptie =Prescriptie.Fara;
            efecteSecundare = EfecteSecundare.Nimic;


        }
        public Farmacie(int id, string nume, int pret, int numar,Prescriptie pr,EfecteSecundare ef)  //constructor cu parametrii
        {
            MedID = id;
            MedNume = nume;
            MedPret = pret;
            MedNr = numar;
            prescriptie = pr;
            efecteSecundare = ef;
        }
        public Farmacie(string linie)     //constructor cu linie de fisier text separate prin ,
        {
            string[] componente = linie.Split(',');
            medNume =componente[0];
            medPret = int.Parse(componente[1]);
            medNr = int.Parse(componente[2]);
            prescriptie = (Prescriptie) int.Parse(componente[3]);
            efecteSecundare= (EfecteSecundare)int.Parse(componente[4]);

        }


        public int MedID { get => medID; set => medID = value; }   
        public string MedNume { get => medNume; set => medNume = value; }
        public int MedPret { get => medPret; set => medPret = value; }
        public int MedNr { get => medNr; set => medNr = value; }
        public int X { get => x; set => x = value; }
        public Prescriptie Prescriptie1 { get => prescriptie; set => prescriptie = value; }
        public EfecteSecundare EfecteSecundare1 { get => efecteSecundare; set => efecteSecundare = value; }

        public override string ToString()                                                                                       //transforma obiectul in linie de fisier text cu elementele separate prin ,
        {
            return  MedNume + ',' + MedPret + ',' + medNr + ',' + (int)Prescriptie1 + ',' + (int)EfecteSecundare1 + '\n';
        }
       

    }
}
