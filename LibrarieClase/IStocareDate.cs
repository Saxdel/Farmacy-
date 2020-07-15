using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hincu Andrei grupa 3122A
namespace LibrarieClase
{
    public interface IStocareDate       // interfata care defineste functiile care se ocupa cu lucrul datelor externe
    {
        Farmacie Cautare(string nume, List<Farmacie> lst);
        void Editare(string nume, Farmacie f, List<Farmacie> lst);
        void CitireFisier(string numefis, List<Farmacie> lst);
        void ScrieFisier(string numefis, List<Farmacie> lst);
        void Stergere(string nume, Farmacie f, List<Farmacie> lst);

    }
}
