using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ExtProcess
{
	class ProcessRunner
	{
		private string m_CommandLine = string.Empty;
		public string CommandLine
		{
			get
			{
				//throw new System.NotImplementedException();
				return m_CommandLine;
			}
			set
			{
				m_CommandLine = value;
			}
		}

		public int Exec()
		{
			//throw new System.NotImplementedException();
			//How to Wait for a Shelled Process to Finish
			//Get the path to the system folder.
			string sysFolder =
			Environment.GetFolderPath(Environment.SpecialFolder.System);
			//Create a new process info structure.
			ProcessStartInfo pInfo = new ProcessStartInfo();
			//Set the file name member of the process info structure.
			pInfo.FileName = m_CommandLine; //@"\eula.txt";
			//Start the process.
			Process p = Process.Start(pInfo);
			//Wait for the window to finish loading.
			p.WaitForInputIdle();
			//Wait for the process to end.
			//p.WaitForExit();
			//MessageBox.Show("Code continuing...");
			return p.Id;
		}

		public void Kill()
		{
			throw new System.NotImplementedException();
		}

		public bool IsRunning(int pId)
		{
			//throw new System.NotImplementedException();
			try
			{
				Process p = Process.GetProcessById(pId);
			}
			catch (ArgumentException a)
			{
				Console.WriteLine(a.Message);
				if (a.Message == "Process with an Id of " + pId + " is not running.")
				{ return false; }
				else { throw; }
			}
			return true;
		}
	}
}
