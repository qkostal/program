using System;

namespace GBE_Data.DataObjects
{
	/// <summary>
	/// Simple class for holding data about an event.
	/// </summary>
	public class Event
	{
		private long _eventId;
		private string _name;
		private short _displayOrder;
		private bool _isEnabledForMultiples;
		private Market[] _markets;
		private Event[] _events;

		public long EventId
		{
			get { return _eventId; }
			set { _eventId = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
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

		public Market[] Markets
		{
			get { return _markets; }
			set { _markets = value; }
		}

		public Event[] Events
		{
			get { return _events; }
			set { _events = value; }
		}
	}
}
