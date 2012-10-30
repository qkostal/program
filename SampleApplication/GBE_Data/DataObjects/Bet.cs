using System;

namespace GBE_Data.DataObjects
{
	public class Bet
	{
		private long _orderId;
		private long _marketId;
		private long _selectionId;
		private long _sequenceNo;
		private DateTime _issuedAt;
		private byte _polarity;
		private decimal _unmatchedStake;
		private decimal _requestedPrice;
		private decimal _matchedPrice;
		private decimal _matchedStake;
		private decimal _matchedAgainstStake;
		private OrderStatus _status;
		private bool _restrictOrderToBroker;

		public long OrderId
		{
			get { return _orderId; }
			set { _orderId = value; }
		}

		public long MarketId
		{
			get { return _marketId; }
			set { _marketId = value; }
		}

		public long SelectionId
		{
			get { return _selectionId; }
			set { _selectionId = value; }
		}

		public long SequenceNo
		{
			get { return _sequenceNo; }
			set { _sequenceNo = value; }
		}

		public DateTime IssuedAt
		{
			get { return _issuedAt; }
			set { _issuedAt = value; }
		}

		public byte Polarity
		{
			get { return _polarity; }
			set { _polarity = value; }
		}

		public decimal UnmatchedStake
		{
			get { return _unmatchedStake; }
			set { _unmatchedStake = value; }
		}

		public decimal RequestedPrice
		{
			get { return _requestedPrice; }
			set { _requestedPrice = value; }
		}

		public decimal MatchedPrice
		{
			get { return _matchedPrice; }
			set { _matchedPrice = value; }
		}

		public decimal MatchedStake
		{
			get { return _matchedStake; }
			set { _matchedStake = value; }
		}

		public decimal MatchedAgainstStake
		{
			get { return _matchedAgainstStake; }
			set { _matchedAgainstStake = value; }
		}

		public OrderStatus Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public bool RestrictOrderToBroker
		{
			get { return _restrictOrderToBroker; }
			set { _restrictOrderToBroker = value; }
		}
	}
}
