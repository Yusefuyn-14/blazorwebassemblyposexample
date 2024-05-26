using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Utils
{
    public static class UriHelpers
    {
        public static string GetValueInParameter(string Uri, string Parametername)
        { // https://www.google.com/blabla/hellword?ID=1&Product=2
            string returnedString = "";
            try
            {
                returnedString = Uri.Split('?')[1].Split('&').FirstOrDefault(xd => xd.Split('=')[0].Contains(Parametername)).Split('=')[1];
            }
            catch (Exception)
            {

            }
            return returnedString;
        }
    }
}
