using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratingPage
{
    internal class GenericJsonFilehandler<T>
    {
        public T Data { get; set; } = default;
        public string Filename { get; set; } = "";

        public void Save()
        {
            File.WriteAllText(
                Filename + ".json",
                JsonConvert.SerializeObject(Data, Formatting.Indented,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                })
                );
        }

        public void Load()
        {
            string data = string.Empty;
            if (File.Exists(Filename + ".json"))
            {
                try
                {
                    data = File.ReadAllText(Filename + ".json");
                }
                catch (Exception ex) 
                {
                    Debug.WriteLine(ex.Message);
                    data = "{}";
                }
            }
            try
            {
                Data = JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
