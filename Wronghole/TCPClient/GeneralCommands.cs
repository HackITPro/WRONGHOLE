using System.Diagnostics;

public class GeneralCommands
{
	private char Command = "";

	public GeneralCommands(char inputCommand) 
	{
		Command = inputCommand;
	}
	
	private void ProcesssList()
	{
        var allProcesses = Process.GetProcesses();
	}
		
	private void GetTcpConnections() 
	{
		

	}

};