using System;

namespace GBE_Data.DataObjects
{
	/// <summary>
	/// Simple class for holding data about a selection.
	/// Note: although the web service uses two classes SelectionType and SelectionTypeWithPrices,
	///  going to use this one class locally, and just leave certain fields empty when necessary,
	///  e.g. the Prices property wont be used when converting the SelectionType.
	/// </summary>
	public class Selection
	{
		private long _id;
		private string _name;
		private short _status;
		private short _resetCount;
		private decimal _deductionFactor;
		private Price[] _pricesFor;
		private Price[] _pricesAgainst;

		public long Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public short Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public short ResetCount
		{
			get { return _resetCount; }
			set { _resetCount = value; }
		}

		public decimal DeductionFactor
		{
			get { return _deductionFactor; }
			set { _deductionFactor = value; }
		}

		public Price[] PricesFor
		{
			get { return _pricesFor; }
			set { _pricesFor = value; }
		}

		public Price[] PricesAgainst
		{
			get { return _pricesAgainst; }
			set { _pricesAgainst = value; }
		}
	}
}
