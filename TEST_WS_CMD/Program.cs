using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST_WS_CMD.NS_WS_GUITARE_LOCAl;

namespace TEST_WS_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            WS_GUITARESoapClient Le_WS = new WS_GUITARESoapClient();

            var message = Le_WS.Get_Date();
            Console.WriteLine(message);

           
            
        }
    }
}
