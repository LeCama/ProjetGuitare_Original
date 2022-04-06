using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IHM_GUITARE_CLIENT.COORDINATION
{
    public class C_NOTIFIABLE : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Signale_Changement([CallerMemberName] string P_Nom = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(P_Nom));
        }

        public void Signale_Changement(object P_Objet, [CallerMemberName] string P_Nom = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(P_Objet, new PropertyChangedEventArgs(P_Nom));
        }
    }
}
