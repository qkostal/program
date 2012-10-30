using System;

namespace GBE_Data.DataObjects
{
	/// <summary>
	/// Simple class for holding data about a price and stake for a selection.
	/// </summary>
	public class Price
	{
		private decimal _odds;
		private decimal _stake;

		public decimal Odds
		{
			get { return _odds; }
			set { _odds = value; }
		}

		public decimal Stake
		{
			get { return _stake; }
			set { _stake = value; }
		}
	}
}
