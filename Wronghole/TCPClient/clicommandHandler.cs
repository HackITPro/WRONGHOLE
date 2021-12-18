using System;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace TCPClient
{
    class clicommandHandler
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
        public string CommandInput { get; set; }
        public OperatingSystem getOS()
        {
            return Environment.OSVersion;
        }

        public NetworkInterface[] getIPAddr()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            return interfaces;
        }

        public string getDrives()
        {
            //GetDrives drive = (GetDrives)DeSerialize(json);
            List<GetDrives> drives = new List<GetDrives>();
            int i = 0;
            foreach(DriveInfo d in DriveInfo.GetDrives())
            {
                if(d.IsReady == true)
                {
                    drives.Add(new GetDrives());
                    drives[i].name = d.Name;
                    drives[i].drvType = d.DriveType.ToString();
                    drives[i].voLabel = d.VolumeLabel;
                    drives[i].drvFormat = d.DriveFormat;
                    drives[i].totalFree = d.TotalFreeSpace.ToString();
                    drives[i].totalSize = d.TotalSize.ToString();
                }
            }
            return Serialize(drives);
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
        public string FindCommand(string cmd)
        {
            switch (cmd)
            {
                case "drives":
                    return getDrives();
                default:
                    return "Not Valid";
            }
        }

    }
}
