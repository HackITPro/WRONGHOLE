using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Wronghole
{
    class resultParser
    {
        public class GetDrives
        {
            public string name { get; set; }
            public string drvType { get; set; }
            public string voLabel { get; set; }
            public string drvFormat { get; set; }
            public string totalFree { get; set; }
            public string totalSize { get; set; }
        }

        public string command { get; set; }
        
        public void parseCommand(string cmd)
        {
            switch (command)
            {
                case "drives":
                    getDrives(command);
                    break;
                default:
                    break;
            }
        }
        public void getDrives(string data)
        {
            Console.WriteLine(data);
        }
        public string Serialize(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }
        public Object DeSerialize(string json)
        {
            Object obj = JsonConvert.DeserializeObject(json);
            return obj;
        }
    }
}
