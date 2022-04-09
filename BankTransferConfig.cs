using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302201132
{
    internal class BankTransferConfig
    {

        public dynamic ReadJson()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string fileName = "/bank_transfer_config.json";
            string jsonString = File.ReadAllText(path + fileName);

            dynamic conf = JsonConvert.DeserializeObject(jsonString);
            return conf;
        }
    }
}