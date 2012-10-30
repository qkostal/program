using System;
using GBE_Data.DataObjects;
using GBE_Data.GBE_API;

namespace GBE_Data.DataObjectConverters
{
	/// <summary>
	/// Handles conversions between the web service's MarketType type and our local Market type.
	/// Also handling conversions of the MarketTypeWithPrices type.
	/// </summary>
	public class MarketConverter
	{
		public static Market[] ConvertMarketTypeCollection(MarketType[] remoteMarkets)
		{
			Market[] localMarkets = new Market[remoteMarkets.Length];

			for (int j = 0 ; j < remoteMarkets.Length ; j++)
			{
				MarketType remoteMarket = remoteMarkets[j];

				localMarkets[j] = new Market();
				localMarkets[j].MarketId = remoteMarket.Id;
				localMarkets[j].Name = remoteMarket.Name;
				localMarkets[j].MarketType = remoteMarket.Type;
				localMarkets[j].MarketStatus = remoteMarket.Status;
				localMarkets[j].NoOfWinningSelections = remoteMarket.NumberOfWinningSelections;
				localMarkets[j].StartTime = remoteMarket.StartTime;
				localMarkets[j].WithdrawalSeqNo = remoteMarket.WithdrawalSequenceNumber;
				localMarkets[j].DisplayOrder = remoteMarket.DisplayOrder;
				localMarkets[j].IsEnabledForMultiples = remoteMarket.IsEnabledForMultiples;
				localMarkets[j].IsInRunningAllowed = remoteMarket.IsInRunningAllowed;
				localMarkets[j].ManagedWhenInRunning = remoteMarket.IsManagedWhenInRunning;
				localMarkets[j].InRunningDelaySeconds = remoteMarket.InRunningDelaySeconds;

				// This field is not currently implemented properly.
				localMarkets[j].IsCurrentlyInRunning = remoteMarket.IsCurrentlyInRunning;

				if (remoteMarket.Selections != null)
					localMarkets[j].Selections = SelectionConverter.ConvertSelectionTypeCollection(remoteMarket.Selections);
			}

			return localMarkets;
		}


		public static Market[] ConvertMarketTypeWithPricesCollection(MarketTypeWithPrices[] remoteMarkets)
		{
			Market[] localMarkets = new Market[remoteMarkets.Length];

			for (int j = 0 ; j < remoteMarkets.Length ; j++)
			{
				MarketTypeWithPrices remoteMarket = remoteMarkets[j];

				localMarkets[j] = new Market();
				localMarkets[j].MarketId = remoteMarket.Id;
				localMarkets[j].Name = remoteMarket.Name;
				localMarkets[j].MarketType = remoteMarket.Type;
				localMarkets[j].MarketStatus = remoteMarket.Status;
				localMarkets[j].NoOfWinningSelections = remoteMarket.NumberOfWinningSelections;
				localMarkets[j].StartTime = remoteMarket.StartTime;
				localMarkets[j].WithdrawalSeqNo = remoteMarket.WithdrawalSequenceNumber;
				localMarkets[j].DisplayOrder = remoteMarket.DisplayOrder;
				localMarkets[j].IsEnabledForMultiples = remoteMarket.IsEnabledForMultiples;				

				if (remoteMarket.Selections != null)
					localMarkets[j].Selections = SelectionConverter.ConvertSelectionTypeWithPricesCollection(remoteMarket.Selections); 
			}

			return localMarkets;
		}
	}
}
