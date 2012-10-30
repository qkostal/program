using System;
using GBE_Data.DataObjects;
using GBE_Data.GBE_API;

namespace GBE_Data.DataObjectConverters
{
	/// <summary>
	/// Handles conversions between the web service's Order type and our local Bet type.
	/// </summary>
	public class OrderConverter
	{
		public static Bet[] ConvertOrderCollection(Order[] remoteOrders)
		{
			if (remoteOrders == null
				|| remoteOrders.Length == 0)
				return null;


			Bet[] localOrders = new Bet[remoteOrders.Length];

			for (int j = 0 ; j < remoteOrders.Length ; j++)
			{
				Order remotePrice = remoteOrders[j];

				localOrders[j] = new Bet();
				localOrders[j].OrderId = remotePrice.Id;
				localOrders[j].MarketId = remotePrice.MarketId;
				localOrders[j].SelectionId = remotePrice.SelectionId;
				localOrders[j].SequenceNo = remotePrice.SequenceNumber;
				localOrders[j].IssuedAt = remotePrice.IssuedAt;
				localOrders[j].Polarity = remotePrice.Polarity;
				localOrders[j].UnmatchedStake = remotePrice.UnmatchedStake;
				localOrders[j].RequestedPrice = remotePrice.RequestedPrice;
				localOrders[j].MatchedPrice = remotePrice.MatchedPrice;
				localOrders[j].MatchedStake = remotePrice.MatchedStake;
				localOrders[j].MatchedAgainstStake = remotePrice.MatchedAgainstStake;
				localOrders[j].Status = (OrderStatus) remotePrice.Status;
				localOrders[j].RestrictOrderToBroker = remotePrice.RestrictOrderToBroker;
			}

			return localOrders;
		}


		public static Bet[] CombineTwoBetArrays(Bet[] firstArray, Bet[] secondArray)
		{
			// If they are both null, then will return null;
			if (secondArray == null)
				return firstArray;
			if (firstArray == null)
				return secondArray;


			Bet[] newBets = new Bet[firstArray.Length + secondArray.Length];

			Array.Copy(firstArray, 0, newBets, 0, firstArray.Length);
			Array.Copy(secondArray, 0, newBets, firstArray.Length, secondArray.Length);

			return newBets;
		}


		public static long GetMaxSequenceNoFromListOfBets(Bet[] bets)
		{
			if (bets == null)
				return 0;

			return bets[bets.Length - 1].SequenceNo;
		}
	}
}
