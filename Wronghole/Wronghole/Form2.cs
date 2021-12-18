using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wronghole
{
    public partial class Form2 : Form
    {
        //Console prompt string
        private string ConsolePrompt = String.Format("user@WRONGHOLE <{0}>: ", DateTime.Now.ToString("h:mm:ss tt"));
        //private object TCPIPServer = null;
        SslTcpServer CurrentSession;
        private char[] trim = { '<', 'E', 'O', 'F', '>' };
        public Form2(SslTcpServer session)
        {
            InitializeComponent();
            richCommandOutPutBox.Text = ConsolePrompt;
            CurrentSession = session;
        }

        //new CommandHandler object
        CommandHandler commandExecute = new CommandHandler();
        resultParser parser = new resultParser(); 
        private void CommandBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            //Check for enter key to execute command
            if (e.KeyCode == Keys.Enter)
            {
                //Supress audible chime on "Enter"
                e.SuppressKeyPress = true;
                commandExecute.CommandInput = commandBox.Text;

                //Validate command user input
                if (commandExecute.CommandValidation())
                {
                    //Output prompt and entered command to console window
                    richCommandOutPutBox.AppendText("\n\n" + ConsolePrompt + commandBox.Text);

                    //Package command after validation
                    CurrentSession.SendMessage(commandExecute.CommandInput);
                    richCommandOutPutBox.AppendText("\n\n" + ConsolePrompt + "Sending " + commandExecute.CommandInput +" command to client.");

                    /*Testing output of object
                    Object data = commandExecute.DeSerialize(CurrentSession.ReadObject());
                    parser.command = commandExecute.CommandInput;
                    parser.objct = data;
                    parser.parseCommand();
                    */
                    string data = CurrentSession.ReadMessage();
                    commandExecute.FindCommand(commandExecute.CommandInput, data, parser);
                    richCommandOutPutBox.AppendText("\n\n" + ConsolePrompt + data.TrimEnd(trim));
                }
                else
                {
                    //If command returns false, print error
                    richCommandOutPutBox.AppendText("\n\n" + ConsolePrompt + "Invalid command.");
                }
                 
                //Clear commandBox user input
                commandBox.Clear();
            }
        }
    }
}
