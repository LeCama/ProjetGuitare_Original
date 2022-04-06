using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_Base;

namespace Test_Lib_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            C_BASE La_base = new C_BASE();
            var Liste_Materiaux = La_base.Get_Materiaux();
            Console.WriteLine(Liste_Materiaux.Count);
            foreach (Materiel/**/ Un_Materiel in Liste_Materiaux)
            {
                Console.WriteLine($"{Un_Materiel.Nom}");
            }
            
        }
    }
}
