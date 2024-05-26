using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Utils
{
    public class ParameterUriConverter
    {
        public List<ParameterUri> parameters = null;
        public ParameterUriConverter() { parameters = new List<ParameterUri>(); }

        public ParameterUriConverter Add(ParameterUri parameterUri)
        {
            parameters.Add(parameterUri);
            return this;
        }

        public ParameterUriConverter Add(string para, string val)
        {
            parameters.Add(new ParameterUri(para, val));
            return this;

        }

        public ParameterUriConverter Add(int para, int val)
        {
            parameters.Add(new ParameterUri(para.ToString(), val.ToString()));
            return this;

        }

        public ParameterUriConverter Add(string para, int val)
        {
            parameters.Add(new ParameterUri(para.ToString(), val.ToString()));
            return this;

        }

        public ParameterUriConverter Add(int para, string val)
        {
            parameters.Add(new ParameterUri(para.ToString(), val.ToString()));
            return this;

        }

        public string Generate()
        {
            string returnedString = "";
            parameters.ForEach(xd =>
            {
                returnedString += $"{xd.Parameter}={xd.Value}&";
            });
            return returnedString.Substring(0, returnedString.Length - 1);
        }
    }

    public static class ParameterUriConverterExpansion
    {
        public static ParameterUriConverter Add(this ParameterUriConverter parauri, ParameterUri parameterUri)
        {
            parauri.parameters.Add(parameterUri);
            return parauri;
        }

        public static ParameterUriConverter Add(this ParameterUriConverter parauri, string para, string val)
        {
            parauri.parameters.Add(new ParameterUri(para, val));
            return parauri;
        }

        public static ParameterUriConverter Add(this ParameterUriConverter parauri, int para, int val)
        {
            parauri.parameters.Add(new ParameterUri(para.ToString(), val.ToString()));
            return parauri;
        }

        public static ParameterUriConverter Add(this ParameterUriConverter parauri, string para, int val)
        {
            parauri.parameters.Add(new ParameterUri(para.ToString(), val.ToString()));
            return parauri;
        }

        public static ParameterUriConverter Add(this ParameterUriConverter parauri, int para, string val)
        {
            parauri.parameters.Add(new ParameterUri(para.ToString(), val.ToString()));
            return parauri;
        }

        public static string Generate(this ParameterUriConverter parauri)
        {
            string returnedString = "";
            parauri.parameters.ForEach(xd =>
            {
                returnedString += $"{xd.Parameter}={xd.Value}&";
            });
            return returnedString.Substring(0, returnedString.Length - 1);
        }
    }

    public class ParameterUri
    {

        public ParameterUri()
        {

        }

        public ParameterUri(string Parayr, string valy)
        {
            Parameter = Parayr;
            Value = valy;
        }
        public string Parameter { get; set; }
        public string Value { get; set; }
    }
}
