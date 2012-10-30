using System;
using System.Configuration;

namespace GBE_Data
{
	/// <summary>
	/// This Class have properties to get the appSettings from the GBE_UserInterface app.config
	/// </summary>
	class Config
	{
		/// <summary>
		/// Get the LanguageCode of the app.config
		/// </summary>
		public static string LanguageCode
		{
			get { return  ConfigurationSettings.AppSettings["LanguageCode"]; }
		}

		/// <summary>
		/// Get the Version of the app.config
		/// </summary>
		public static decimal Version
		{
			get { return decimal.Parse(ConfigurationSettings.AppSettings["version"]); }
		}
	}
}
