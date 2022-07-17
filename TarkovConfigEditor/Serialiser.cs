using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovConfigEditor
{
    public class Serialiser
    {
        public static T Deserialise<T>(string text)
        {
            return (T)JsonConvert.DeserializeObject<T>(text);
        }

        public static string Serialise<T>(T item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}
