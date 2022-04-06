using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_Base
{
    //TODO : mettre nouvelle base Azure
    public class C_BASE
    {

        
        C_BASE_AZUR La_Base_Azure = new C_BASE_AZUR();
        public C_BASE()
        {
            La_Base_Azure.BoisCorps.ToList();
            La_Base_Azure.Materiels.ToList();
        }
        //--------------------------------

        /*
         * public List<C_Bois> Get_Bois()
         * {return La_Base.Les_Bois.Tolist()
         * 
         */


        public List<Materiel> Get_Materiaux()
        {
            return La_Base_Azure.Materiels.ToList();
        }

        public List<Client> Get_Client()
        {
            return La_Base_Azure.Clients.ToList();
        }

        public void Add_Materiel(string P_Nom)
        {
            Materiel New_Materiel = new Materiel() { Nom = P_Nom};
            La_Base_Azure.Materiels.Add(New_Materiel);
            La_Base_Azure.SaveChanges();

        }
        public List<Materiel> Find_Materiel(string P_Nom)
        {
           var Resultat= from un_materiel in La_Base_Azure.Materiels where un_materiel.Nom.Contains(P_Nom)select un_materiel;
            return Resultat.ToList();
        }
        /*
        public void Add_Materiel(C_Materiel P_Materiel)
        {

        }*/
    }
}
