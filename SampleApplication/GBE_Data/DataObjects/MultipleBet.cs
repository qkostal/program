using System;

namespace GBE_Data.DataObjects
{
	public class MultipleBet
	{
		private long _orderId;
		private MultipleBetStatus _status;
		private decimal _requestedStake;
		private decimal _averageMatchedPrice;
		private decimal _effectivePrice;
		private decimal _totalMaxUpside;
		private DateTime _placedAt;
		private decimal _totalMatchedStake;
		private decimal _requestedPrice;
		private decimal _rolloverStake;
		private int _numberOfUnsettledSelections;
		private int _numberOfSelections; // ?
		private decimal _unsettledPrice;
		private decimal _commision;
		private bool _isSettled;
		private int _numberOfBetChunks;

		public long OrderId
		{
			get { return _orderId; }
			set { _orderId = value; }
		}

		public MultipleBetStatus Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public decimal RequestedStake
		{
			get { return _requestedStake; }
			set { _requestedStake = value; }
		}

		public decimal AverageMatchedPrice
		{
			get { return _averageMatchedPrice; }
			set { _averageMatchedPrice = value; }
		}

		public decimal EffectivePrice
		{
			get { return _effectivePrice; }
			set { _effectivePrice = value; }
		}

		public decimal TotalMaxUpside
		{
			get { return _totalMaxUpside; }
			set { _totalMaxUpside = value; }
		}

		public DateTime PlacedAt
		{
			get { return _placedAt; }
			set { _placedAt = value; }
		}

		public decimal TotalMatchedStake
		{
			get { return _totalMatchedStake; }
			set { _totalMatchedStake = value; }
		}

		public decimal RequestedPrice
		{
			get { return _requestedPrice; }
			set { _requestedPrice = value; }
		}

		public decimal RolloverStake
		{
			get { return _rolloverStake; }
			set { _rolloverStake = value; }
		}

		public int NumberOfUnsettledSelections
		{
			get { return _numberOfUnsettledSelections; }
			set { _numberOfUnsettledSelections = value; }
		}

		public int NumberOfSelections
		{
			get { return _numberOfSelections; }
			set { _numberOfSelections = value; }
		}

		public decimal UnsettledPrice
		{
			get { return _unsettledPrice; }
			set { _unsettledPrice = value; }
		}

		public decimal Commision
		{
			get { return _commision; }
			set { _commision = value; }
		}

		public bool IsSettled
		{
			get { return _isSettled; }
			set { _isSettled = value; }
		}

		public int NumberOfBetChunks
		{
			get { return _numberOfBetChunks; }
			set { _numberOfBetChunks = value; }
		}
	}
}
