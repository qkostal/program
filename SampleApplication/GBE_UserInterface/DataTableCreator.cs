using System;
using System.Data;
using GBE_Data.DataObjects;

namespace GBE_UserInterface
{
	/// <summary>
	/// Creates the DataTables used to populate the DataGrids on the form.
	/// </summary>
	public class DataTableCreator
	{
		#region Selections table

		public static DataTable CreateAndPopulateSelectionsTable(Selection[] selections)
		{
			DataTable selectionsTable = new DataTable();

			selectionsTable.Columns.Add("Back 3");
			selectionsTable.Columns.Add("Back 2");
			selectionsTable.Columns.Add("Back 1");

			selectionsTable.Columns.Add("Name");
			selectionsTable.Columns.Add("Id");

			selectionsTable.Columns.Add("Lay 1");
			selectionsTable.Columns.Add("Lay 2");
			selectionsTable.Columns.Add("Lay 3");


			foreach (Selection subSelection in selections)
			{
				DataRow newRow = selectionsTable.NewRow();

				// Show the for prices.
				if (subSelection.PricesFor != null)
					for (int i = 0 ; i < 3 ; i++)
					{
						// Have to use annoying little algo, so that can do stuff like place the 
						//  3rd price in the 1st column, 2nd price in 2nd col, 1st price in 3rd column.
						// So, first time through this loop, check if there is a 3rd price and if so place in first column.
						if (subSelection.PricesFor.Length >= (3-i))
						{
							// E.g. "$32 at 2.5".
							// Obviously need to handle currency symbol properly.
							string priceOddsText = string.Format("${0} at {1}", subSelection.PricesFor[2-i].Stake, subSelection.PricesFor[2-i].Odds);
							newRow[i] = priceOddsText;
						}
						else
							// If there is no price then just empty string.
							newRow[i] = "";
					}


				// In between the for prices and against prices want to place the selection details.
				newRow[3] = subSelection.Name;
				newRow[4] = subSelection.Id;
				
				

				// Show the against prices.
				if (subSelection.PricesAgainst != null)
					for (int i = 0 ; i < 3 ; i++)
					{
						// Against prices go in regular order, but starting in column 5 makes more annoying.
						// So, 1st price goes in 5th column, 2nd in 6th, 3rd in 6th.
						if (subSelection.PricesAgainst.Length >= (i+1))
						{
							// As above.
							string priceOddsText = string.Format("${0} at {1}", subSelection.PricesAgainst[i].Stake, subSelection.PricesAgainst[i].Odds);
							newRow[5+i] = priceOddsText;
						}
						else
							// If there is no price then just empty string.
							newRow[5+i] = "";
					}

				
				selectionsTable.Rows.Add(newRow);
			}


			return selectionsTable;
		}

		#endregion


		#region Bets table

		public static DataTable CreateAndPopulateBetsTable(Bet[] bets)
		{
			if (bets == null)
				return null;

			DataTable betsTable = CreateBetsTable();
			PopulateBetsTable(bets, betsTable);

			return betsTable;
		}


		public static void PopulateBetsTable(Bet[] bets, DataTable betsTable)
		{
			foreach (Bet thisBet in bets)
			{
				DataRow newRow = betsTable.NewRow();

				newRow[0] = thisBet.OrderId;
				newRow[1] = thisBet.IssuedAt.ToShortDateString();
				newRow[2] = thisBet.Status.ToString();
				newRow[3] = String.Format("{0:#,##0.00;(#,##0.00);}", thisBet.RequestedPrice);
				newRow[4] = String.Format("{0:#,##0.00;(#,##0.00);}", thisBet.MatchedPrice);
				newRow[5] = String.Format("{0:$#,##0.00;($#,##0.00);}", thisBet.UnmatchedStake);
				newRow[6] = String.Format("{0:$#,##0.00;($#,##0.00);}", thisBet.MatchedStake);
				Polarity polarity = (Polarity) thisBet.Polarity;
				newRow[7] = polarity.ToString();

				betsTable.Rows.Add(newRow);
			}
		}

		private static DataTable CreateBetsTable()
		{
			DataTable betsTable = new DataTable();
	
			betsTable.Columns.Add("Bet Id");
			betsTable.Columns.Add("Issued At");
			betsTable.Columns.Add("Status");
			betsTable.Columns.Add("Requested Price");
			betsTable.Columns.Add("Matched Price");
			betsTable.Columns.Add("Unmatched Stake");
			betsTable.Columns.Add("Matched Stake");
			betsTable.Columns.Add("Polarity");

			return betsTable;
		}

		#endregion


		#region Multiple bets table

		public static DataTable CreateAndPopulateMultipleBetsTable(MultipleBet[] bets)
		{
			if (bets == null)
				return null;

			DataTable multipleBetsTable = CreateMultipleBetsTable();
			PopulateMultipleBetsTable(bets, multipleBetsTable);

			return multipleBetsTable;
		}


		private static DataTable CreateMultipleBetsTable()
		{
			DataTable multipleBetsTable = new DataTable();
	
			multipleBetsTable.Columns.Add("Multiple Bet Id");
			multipleBetsTable.Columns.Add("Placed At");
			multipleBetsTable.Columns.Add("Status");
			multipleBetsTable.Columns.Add("Average Matched Price");
			multipleBetsTable.Columns.Add("TotalMatchedStake");
			multipleBetsTable.Columns.Add("TotalMaxUpside");

			return multipleBetsTable;
		}

		
		public static void PopulateMultipleBetsTable(MultipleBet[] bets, DataTable betsTable)
		{
			foreach (MultipleBet thisBet in bets)
			{
				DataRow newRow = betsTable.NewRow();

				newRow[0] = thisBet.OrderId;
				newRow[1] = thisBet.PlacedAt;
				newRow[2] = thisBet.Status.ToString();
				newRow[3] = String.Format("{0:#,##0.00;(#,##0.00);}", thisBet.AverageMatchedPrice);
				newRow[4] = String.Format("{0:$#,##0.00;($#,##0.00);}", thisBet.TotalMatchedStake);
				newRow[5] = String.Format("{0:$#,##0.00;($#,##0.00);}", thisBet.TotalMaxUpside);

				betsTable.Rows.Add(newRow);
			}
		}

		#endregion

		public static DataTable CreateBetsToPlaceTable()
		{
			DataTable betsToPlaceTable = new DataTable();
	
			betsToPlaceTable.Columns.Add("Selection Id");
			betsToPlaceTable.Columns.Add("Polarity");
			betsToPlaceTable.Columns.Add("Amount");
			betsToPlaceTable.Columns.Add("Odds");
			betsToPlaceTable.Columns.Add("ResetCount");
			betsToPlaceTable.Columns.Add("Selection Name");

			return betsToPlaceTable;
		}

		
		public static void AddToBetsToPlaceTable(long selId, byte polarity, decimal amount
			, decimal odds, byte resetCount, string selName, DataTable betsToPlaceTable)
		{
			DataRow newRow = betsToPlaceTable.NewRow();

			newRow[0] = selId;
			newRow[1] = polarity;
			newRow[2] = amount;
			newRow[3] = odds;
			newRow[4] = resetCount;
			newRow[5] = selName;

			betsToPlaceTable.Rows.Add(newRow);
		}
	}
}
