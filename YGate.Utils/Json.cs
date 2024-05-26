using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Utils
{
    public static class Json
    {
        public static T Deserialized<T>(string Obj)
        {
            return JsonConvert.DeserializeObject<T>(Obj);
        }

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
