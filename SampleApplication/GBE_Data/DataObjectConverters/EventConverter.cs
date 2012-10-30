using System;
using GBE_Data.DataObjects;
using GBE_Data.GBE_API;

namespace GBE_Data.DataObjectConverters
{
	/// <summary>
	/// Handles conversions between the web service's EventClassifierType type and our local Event type.
	/// </summary>
	public class EventConverter
	{
		public static Event[] ConvertEventClassifierTypeCollection(EventClassifierType[] remoteEvents)
		{
			Event[] localCopyOfEvents = new Event[remoteEvents.Length]; 
			
			for (int i = 0 ; i < localCopyOfEvents.Length ; i++)
			{
				localCopyOfEvents[i] = new Event();
				localCopyOfEvents[i].EventId = remoteEvents[i].Id;
				localCopyOfEvents[i].Name = remoteEvents[i].Name;
				localCopyOfEvents[i].DisplayOrder = remoteEvents[i].DisplayOrder;
				localCopyOfEvents[i].IsEnabledForMultiples = remoteEvents[i].IsEnabledForMultiples;


				// Is it possible to have an event 
				//  with sub-events and collection of markets.
				if (remoteEvents[i].EventClassifiers != null)
					localCopyOfEvents[i].Events = ConvertEventClassifierTypeCollection(remoteEvents[i].EventClassifiers);
				
				
				// Just in case it is possible don't use an else.
				if (remoteEvents[i].Markets != null)
					localCopyOfEvents[i].Markets = MarketConverter.ConvertMarketTypeCollection(remoteEvents[i].Markets);
			}

			return localCopyOfEvents;
		}
	}
}
