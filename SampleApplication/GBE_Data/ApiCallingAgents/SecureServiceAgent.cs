using System;
using System.Data;
using GBE_Data.DataObjectConverters;
using GBE_Data.GBE_API;
using GBE_Data.DataObjects;

namespace GBE_Data
{
	/// <summary>
	/// Provides a wrapper for all calls to the Secure web service.
	/// </summary>
	public class SecureServiceAgent
	{
		private SecureService _proxy = null;


		public SecureServiceAgent(string url, string username, string password)
		{
			SetupSecureServiceProxy(url, username, password);
		}


		private void SetupSecureServiceProxy(string url, string username, string password)
		{
			_proxy = new SecureService();
			_proxy.Url = url;


			ExternalApiHeader header = new ExternalApiHeader();
			header.version = Config.Version;
			header.username = username;
			header.password = password;
			header.languageCode = Config.LanguageCode;
			_proxy.ExternalApiHeaderValue = header;
		}


		public AccountBalances GetAccountBalances()
		{
			GetAccountBalancesResponse response = _proxy.GetAccountBalances(new GetAccountBalancesRequest()); 
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			AccountBalances balances = new AccountBalances();
			balances.Currency = response.Currency;
			balances.AvailableFunds = response.AvailableFunds;
			balances.Balance = response.Balance;
			balances.Credit = response.Credit;
			balances.Exposure = response.Exposure;
			return balances;
		}


		public long[] PlaceOrdersNoReceipt(long selectionId, byte polarity, decimal amount
			, decimal odds, byte resetCount)
		{
			SimpleOrderRequest order = new SimpleOrderRequest();
			order.SelectionId = selectionId;
			order.Polarity = polarity;
			order.Stake = amount;
			order.Price = odds;
			order.ExpectedSelectionResetCount = resetCount;


			PlaceOrdersNoReceiptRequest request = new PlaceOrdersNoReceiptRequest();
			request.Orders = new SimpleOrderRequest[1] {order};


			PlaceOrdersNoReceiptResponse response = _proxy.PlaceOrdersNoReceipt(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			return response.OrderHandles;
		}

		public long[] PlaceOrdersNoReceipt(DataTable betsToPlaceData, bool wantAllOrNothing, byte withdrawSeqNo)
		{
			// First, put together collection of orders.
			SimpleOrderRequest[] orders = new SimpleOrderRequest[betsToPlaceData.Rows.Count];

			int counter = 0;
			foreach (DataRow thisBetRow in betsToPlaceData.Rows)
			{
				SimpleOrderRequest thisOrder = new SimpleOrderRequest();

				thisOrder.SelectionId = long.Parse(thisBetRow["Selection Id"].ToString());
				thisOrder.Polarity = byte.Parse(thisBetRow["Polarity"].ToString());
				thisOrder.Stake = decimal.Parse(thisBetRow["Amount"].ToString());
				thisOrder.Price = decimal.Parse(thisBetRow["Odds"].ToString());
				thisOrder.ExpectedSelectionResetCount = byte.Parse(thisBetRow["ResetCount"].ToString());
				thisOrder.ExpectedWithdrawalSequenceNumber = withdrawSeqNo;
				
				orders[counter++] = thisOrder;
			}


			// Add the orders to the request object.
			PlaceOrdersNoReceiptRequest request = new PlaceOrdersNoReceiptRequest();
			request.Orders = orders;
			request.WantAllOrNothingBehaviour = wantAllOrNothing;
			
			
			


			// Finally, call the API and return the results if successful.
			PlaceOrdersNoReceiptResponse response = _proxy.PlaceOrdersNoReceipt(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			return response.OrderHandles;
		}


		public void CancelAllOrders()
		{
			CancelAllOrdersResponse response = _proxy.CancelAllOrders(new CancelAllOrdersRequest());
		}


		public void CancelOrders(long[] orderIdsToCancel)
		{
			CancelOrdersRequest request = new CancelOrdersRequest();
			request.OrderHandle = orderIdsToCancel;


			CancelOrdersResponse response = _proxy.CancelOrders(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);
		}

		
		
		// Todo: consider changing maxSequenceNo to member variable for this class instead of out param?
		public Bet[] ListBootstrapOrders(out long maxSequenceNo)
		{
			ListBootstrapOrdersRequest request = new ListBootstrapOrdersRequest();
			ListBootstrapOrdersResponse response;
			long lastSeqNoReceived = -1;
			Bet[] betsToReturn = null;
			

			// Keep calling until:
			//  receive an order with a squence number equal to the MaximumSequenceNumber,
			//  or stop receiving any orders (this one is unfortunate since it requires an extra wasted call),
			//  may be worth looking into whether reliable enough to assume reached limit when number 
			//  returned is less than the max that can be returned with each call (usually 500).
			do
			{
				request.SequenceNumber = lastSeqNoReceived;
				response = _proxy.ListBootstrapOrders(request);
				if (response.ReturnStatus.Code != 0)
					throw new Exception(response.ReturnStatus.Description);


				// This is an important check for breaking out of the loop
				//  in situations where the orders never reach the MaximumSequenceNumber.
				if (response.Orders == null || response.Orders.Length == 0)
					break;


				Bet[] bets = OrderConverter.ConvertOrderCollection(response.Orders);
				betsToReturn = OrderConverter.CombineTwoBetArrays(betsToReturn, bets);


				lastSeqNoReceived = response.Orders[response.Orders.Length - 1].SequenceNumber;
			}
			while (lastSeqNoReceived < response.MaximumSequenceNumber);


			maxSequenceNo = response.MaximumSequenceNumber;
			return betsToReturn;
		}


		// Todo: need to add code to handle looping through multiple calls to API.
		public Bet[] ListOrdersChangedSince(long seqNo)
		{
			ListOrdersChangedSinceRequest request = new ListOrdersChangedSinceRequest();
			request.SequenceNumber = seqNo;


			ListOrdersChangedSinceResponse response = _proxy.ListOrdersChangedSince(request);
			if (response.ReturnStatus.Code != 0)
				throw new Exception(response.ReturnStatus.Description);


			Bet[] betsToReturn = OrderConverter.ConvertOrderCollection(response.Orders);
			return betsToReturn;
		}

			
		
	}
}
