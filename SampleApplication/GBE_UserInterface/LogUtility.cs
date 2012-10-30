using System;
using System.Windows.Forms;

namespace GBE_UserInterface
{
	/// <summary>
	/// Handles the writing to log. Eventually intend that it will write to both
	/// text box and file OR just to text box, depending on parameter.
	/// Currently writes log to a label, and status msgs in status bar.
	/// When constructing instance can set either to null if don't want to output.
	/// </summary>
	public class LogUtility
	{
		private Control _statusOutputControl = null;
		private Control _logOutputControl = null;
		private DateTime _startTime;


		public LogUtility(Control logOutputControl, Control statusOutputControl)
		{
			_logOutputControl = logOutputControl;
			_statusOutputControl = statusOutputControl;
		}


		// Consider changing to an enum param instead of string.
		public void BeginCall(string apiName)
		{
			_startTime = DateTime.Now;

			string msg = string.Format("Processing: {0}.", apiName);
			WriteToStatusControl(msg);
		}


		public void EndCall(string apiName)
		{
			// Eventually if have multithreaded app will need to keep
			//  track of all running apps, will need to receive value 
			//  here to tell which call to match against. To do this 
			//  could have BeginCall generate a unique identifier,
			//  which EndCall will receive and use to find the request.
			
			DateTime endTime = DateTime.Now;
			TimeSpan timeDiff = endTime - _startTime;
			string msg = string.Format("End of call: {0}. Milliseconds taken: {1}"
				, apiName, timeDiff.TotalMilliseconds);

			WriteToLogControl(msg);
			WriteToStatusControl(msg);
		}


		public void FailCall(string apiName, string errorMsg)
		{			
			string msg = string.Format("Failed calling: {0}. {1}"
				, apiName, errorMsg);

			WriteToLogControl(msg);
			WriteToStatusControl(msg);
		}


		public void WriteToLogControl(string msgToWrite)
		{
			// Typically log output will be a label that displays log msgs,
			//  but could be changed to anything else with a Text property,
			//  I guess a multi line textbox would be the other main option.
			// New entry displayed at top as there is no way to scroll down for labels.

			System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();			
			if (_logOutputControl != null)
				_logOutputControl.Text =  msgToWrite + "\r\n" + _logOutputControl.Text;
		}


		public void WriteToStatusControl(string msgToWrite)
		{
			// Typically status output will be a status bar.

			if (_statusOutputControl != null)
				_statusOutputControl.Text = msgToWrite;
		}
	}
}
