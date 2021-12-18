using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;


namespace Wronghole
{
    class CommandHandler
    {
        public string CommandInput { get; set; }
        public Boolean CommandValidation()
        {
            //Command list array, add new commands here
            string[] commandArray = { "processlist", "netstat", "drives"};

            //Verify command is a builtin, compares to commandArray
            if (commandArray.Contains(CommandInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FindCommand(string cmd, string result, resultParser parser)
        {
            switch(cmd)
            {
                case "drives":
                    parser.getDrives(result);
                    break;
                default:
                    break;
            }
        }

    }         
}
