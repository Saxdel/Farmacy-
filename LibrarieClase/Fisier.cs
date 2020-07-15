using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Hincu Andrei grupa 3122A
namespace LibrarieClase
{
    public class Fisier : IStocareDate
    {
       

        Farmacie IStocareDate.Cautare(string nume, List<Farmacie> lst)      // cautare in fisier dupa nume
        {
            foreach (var item in lst)
            {
                if (nume == item.MedNume)
                    return item;
            }
            return null;
        }

       

        public void CitireFisier(string numefis, List<Farmacie> lst)        //citire date din fisier si punere in lista
        {
            using (StreamReader sr = new StreamReader(numefis))
            {
                while(!sr.EndOfStream)
                {
                    lst.Add(new Farmacie(sr.ReadLine()));
                }
            }
           
        }

        public void Editare(string nume, Farmacie f, List<Farmacie> lst)  // editare date din fisier in functie de nume
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (nume == lst[i].MedNume)
                    lst[i] = f;
            }
           

        }

        public void Stergere(string nume, Farmacie f, List<Farmacie> lst)  //stergere date din fisier in functie de nume
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (nume == lst[i].MedNume)
                {
                    lst.RemoveAt(i);
                    break;
                }
            }


        }


        public void ScrieFisier(string numefis, List<Farmacie> lst)   // scrie toate elemntele din lista in fisier
        {
            using (StreamWriter sw = new StreamWriter(numefis))
            {
                foreach (var item in lst)
                {
                    sw.Write(item.ToString());
                }
               
            }
        }

        
    }
}
