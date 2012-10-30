using System;

namespace GBE_Data.DataObjects
{
	/// <summary>
	/// Simple class for holding data about a market.
	/// Note: although the web service uses two classes MarketType and MarketTypeWithPrices,
	///  going to use this one class locally, and just leave certain fields empty when necessary.
	/// </summary>
	public class Market
	{
		private string _name;
		private long _marketId;
		private long _parentId;
		private short _marketType;
		private short _marketStatus;
		private short _noOfWinningSelections;
		private DateTime _startTime;
		private short _withdrawalSeqNo;
		private short _displayOrder;
		private bool _isEnabledForMultiples;
		private bool _isInRunningAllowed;
		private bool _managedWhenInRunning;
		private bool _isCurrentlyInRunning;
		private int _inRunningDelaySeconds;
		private Selection[] _selections;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public long MarketId
		{
			get { return _marketId; }
			set { _marketId = value; }
		}

		public short MarketType
		{
			get { return _marketType; }
			set { _marketType = value; }
		}

		public long ParentId
		{
			get { return _parentId; }
			set { _parentId = value; }
		}

		public short MarketStatus
		{
			get { return _marketStatus; }
			set { _marketStatus = value; }
		}

		public short NoOfWinningSelections
		{
			get { return _noOfWinningSelections; }
			set { _noOfWinningSelections = value; }
		}

		public DateTime StartTime
		{
			get { return _startTime; }
			set { _startTime = value; }
		}

		public short WithdrawalSeqNo
		{
			get { return _withdrawalSeqNo; }
			set { _withdrawalSeqNo = value; }
		}

		public short DisplayOrder
		{
			get { return _displayOrder; }
			set { _displayOrder = value; }
		}

		public bool IsEnabledForMultiples
		{
			get { return _isEnabledForMultiples; }
			set { _isEnabledForMultiples = value; }
		}

		public bool IsInRunningAllowed
		{
			get { return _isInRunningAllowed; }
			set { _isInRunningAllowed = value; }
		}

		public bool ManagedWhenInRunning
		{
			get { return _managedWhenInRunning; }
			set { _managedWhenInRunning = value; }
		}

		public bool IsCurrentlyInRunning
		{
			get { return _isCurrentlyInRunning; }
			set { _isCurrentlyInRunning = value; }
		}

		public int InRunningDelaySeconds
		{
			get { return _inRunningDelaySeconds; }
			set { _inRunningDelaySeconds = value; }
		}

		public Selection[] Selections
		{
			get { return _selections; }
			set { _selections = value; }
		}
	}
}
