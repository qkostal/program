using System;

namespace GBE_Data.DataObjects
{
	/// <summary>
	/// Simple class for holding the data returned by GetAccountBalances.
	/// </summary>
	public class AccountBalances
	{
		private string _currency;
		private decimal _availableFunds;
		private decimal _balance;
		private decimal _credit;
		private decimal _exposure;


		#region Properties

		public string Currency
		{
			get { return _currency; }
			set { _currency = value; }
		}

		public decimal AvailableFunds
		{
			get { return _availableFunds; }
			set { _availableFunds = value; }
		}

		public decimal Balance
		{
			get { return _balance; }
			set { _balance = value; }
		}

		public decimal Credit
		{
			get { return _credit; }
			set { _credit = value; }
		}

		public decimal Exposure
		{
			get { return _exposure; }
			set { _exposure = value; }
		}

		#endregion
	}
}
