using System;
using GBE_Data.DataObjectConverters;
using GBE_Data.DataObjects;
using GBE_Data.GBE_API;

namespace GBE_Data
{
	/// <summary>
	/// Provides a wrapper for all calls to the Readonly web service.
	/// </summary>
	public class ReadonlyServiceAgent
	{
		private ReadOnlyService _proxy = null;


		public ReadonlyServiceAgent(string url, string username)
		{
			SetupReadOnlyService(url, username);
		}

		
		private void SetupReadOnlyService(string url, string username)
		{
			_proxy = new ReadOnlyService();
			_proxy.Url = url;


			ExternalApiHeader header = new ExternalApiHeader();
			header.version = Config.Version;
			header.username = username;
			header.languageCode = Config.LanguageCode;
			_proxy.ExternalApiHeaderValue = header;
		}


		public Event[] GetTopLevelEvents()
		{
			ListTopLevelEventsResponse response = _proxy.ListTopLevelEvents(new ListTopLevelEventsRequest());
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);

 
			Event[] topLvlEvents = EventConverter.ConvertEventClassifierTypeCollection(response.EventClassifiers);
			return topLvlEvents;
		}


		public Event GetEventSubTreeNoSelections(long eventId)
		{
			GetEventSubTreeNoSelectionsRequest request = new GetEventSubTreeNoSelectionsRequest();
			request.EventClassifierIds = new long[] {eventId};


			GetEventSubTreeNoSelectionsResponse response = _proxy.GetEventSubTreeNoSelections(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			// Since only receive one eventId as param then can assume will always be just one event returned.
			Event[] eventsTreeToReturn = EventConverter.ConvertEventClassifierTypeCollection(response.EventClassifiers);
			return eventsTreeToReturn[0];
		}


		public Market GetMarketInformation(long marketId)
		{
			GetMarketInformationRequest request = new GetMarketInformationRequest();
			request.MarketIds = new long[] {marketId};


			GetMarketInformationResponse response = _proxy.GetMarketInformation(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			// Since only receive one marketId as param then can assume will always be just one market returned.
			Market[] marketToReturn = MarketConverter.ConvertMarketTypeCollection(response.Markets);
			return marketToReturn[0];
		}


		public Market GetPrices(long marketId)
		{
			GetPricesRequest request = new GetPricesRequest();
			request.MarketIds = new long[] {marketId};
			request.NumberAgainstPricesRequired = 3;
			request.NumberForPricesRequired = 3;


			GetPricesResponse response =_proxy.GetPrices(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			// Since only receive one marketId as param then can assume will always be just one market returned.
			Market[] marketToReturn = MarketConverter.ConvertMarketTypeWithPricesCollection(response.MarketPrices);
			return marketToReturn[0];
		}
		
	}
}
