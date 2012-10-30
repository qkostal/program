using System;
using GBE_Data.DataObjects;
using GBE_Data.GBE_API;

namespace GBE_Data.DataObjectConverters
{
	/// <summary>
	/// Handles conversions between the web service's PricesType type and our local Price type.
	/// </summary>
	public class PriceConverter
	{
		public static Price[] ConvertPricesTypeCollection(PricesType[] remotePrices)
		{
			Price[] localPrices = new Price[remotePrices.Length];

			for (int j = 0 ; j < remotePrices.Length ; j++)
			{
				PricesType remotePrice = remotePrices[j];

				localPrices[j] = new Price();
				localPrices[j].Stake = remotePrice.Stake;
				localPrices[j].Odds = remotePrice.Price;
			}

			return localPrices;
		}
	}
}
