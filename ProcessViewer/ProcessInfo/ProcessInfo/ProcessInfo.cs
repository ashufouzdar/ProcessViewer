/***********************************************************************************************
 * File Name	: ProcessInfo.cs
 * Description	: This class demonstrates the use of WMI.
 *				  It provides a static method to query the list of running processes.
 *				  And it provides two events to delegate when an application has been started.
 * 
 * Author		: Ashutosh Fouzdar, Software Engineer Ness Technologies India Ltd.
 * Date			: 08-June-2007
 * ***********************************************************************************************/
 
using System;
using System.Data;
using System.Management;
using System.Diagnostics;

namespace Win32Process
{
	/// <summary>
	/// ProcessInfo class.
	/// </summary>
	public class ProcessInfo
	{
		// defenition of the delegates
		public delegate void StartedEventHandler(object sender, EventArgs e);
		public delegate void TerminatedEventHandler(object sender, EventArgs e);
		
		// events to subscribe
        public event StartedEventHandler Started = null;
        public event TerminatedEventHandler Terminated = null; 
		

		// WMI event watcher
		private ManagementEventWatcher watcher;
		
        //Application.exe to watch
        public String AppName = null;
        //machine name to notify
        public String MachineName = null;
		// The constructor uses the application name like notepad.exe
		// And it starts the watcher
		public ProcessInfo(string appName,string machineName)
		{
			// querry every 2 seconds
			string pol = "2"; 

			string queryString = 
				"SELECT *" +
				"  FROM __InstanceOperationEvent " + 
				"WITHIN  " + pol +
				" WHERE TargetInstance ISA 'Win32_Process' "  + 				
				"   AND TargetInstance.Name = '" + appName + "'";
            AppName = appName;
            MachineName = machineName;	
			// You could replace the dot by a machine name to watch to that machine
			string scope = @"\\.\root\CIMV2";
			
			// create the watcher and start to listen
			watcher  = new ManagementEventWatcher(scope, queryString);
			watcher.EventArrived += new EventArrivedEventHandler(this.OnEventArrived);			
			watcher.Start();
		}
		public void Dispose()
		{
			watcher.Stop();
			watcher.Dispose();
		}
		private void OnEventArrived(object sender, System.Management.EventArrivedEventArgs e)
		{
			try 
			{
				string eventName = e.NewEvent.ClassPath.ClassName;

				if (eventName.CompareTo("__InstanceCreationEvent")==0)
				{
					// Started
					if (Started!=null) 
						Started(this, e);
				}
				else if (eventName.CompareTo("__InstanceDeletionEvent")==0)
				{
					// Terminated
					if (Terminated!=null) 
						Terminated(this, e);

				}				
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}
		}
        public static DataTable LoadProcess()
	    {
		Process[] prList = Process.GetProcesses();
		DataTable result = new DataTable();

		result.Columns.Add("ProcessId", Type.GetType("System.Int32"));
		result.Columns.Add("Name", Type.GetType("System.String"));
		result.Columns.Add("WorkingSet", Type.GetType("System.String"));
		result.Columns.Add("PrivateMemory", Type.GetType("System.String"));
		result.Columns.Add("ProcessorTime", Type.GetType("System.String"));
		result.Columns.Add("Threads", Type.GetType("System.String"));
		result.Columns.Add("IsResponding", Type.GetType("System.String"));
		result.Columns.Add("StartTime", Type.GetType("System.String"));

		try {
			foreach (Process pr in prList) {
				DataRow row = result.NewRow();
				row["ProcessId"] = pr.Id;
				row["Name"] = pr.ProcessName;
				row["WorkingSet"]=pr.WorkingSet64.ToString();
				row["PrivateMemory"]=pr.PrivateMemorySize64.ToString();
				row["ProcessorTime"]=pr.PrivilegedProcessorTime.TotalSeconds;
				row["Threads"]=pr.Threads.Count.ToString();
				row["IsResponding"]=pr.Responding.ToString();
				row["StartTime"] = pr.StartTime.ToString();
				result.Rows.Add(row);
			}
		}
		catch (Exception ex) {
			Console.WriteLine(ex.Message);
		}
		return result;
	}
	
  }
}
