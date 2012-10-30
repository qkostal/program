using System;
using GBE_Data.DataObjects;
using GBE_Data.GBE_API;

namespace GBE_Data.DataObjectConverters
{
	/// <summary>
	/// Handles conversions between the web service's SelectionType type and our local Selection type.
	/// </summary>
	public class SelectionConverter
	{
		public static Selection[] ConvertSelectionTypeCollection(SelectionType[] remoteSelections)
		{
			Selection[] localSelections = new Selection[remoteSelections.Length];

			for (int i = 0 ; i < remoteSelections.Length ; i++)
			{
				localSelections[i] = new Selection();
				localSelections[i].Id = remoteSelections[i].Id;
				localSelections[i].Name  = remoteSelections[i].Name;
				localSelections[i].Status  = remoteSelections[i].Status;
				localSelections[i].ResetCount  = remoteSelections[i].ResetCount;
				localSelections[i].DeductionFactor  = remoteSelections[i].DeductionFactor;
			}

			return localSelections;
		}


		public static Selection[] ConvertSelectionTypeWithPricesCollection(SelectionTypeWithPrices[] remoteSelections)
		{
			Selection[] localSelections = new Selection[remoteSelections.Length];

			for (int i = 0 ; i < remoteSelections.Length ; i++)
			{
				localSelections[i] = new Selection();
				localSelections[i].Id = remoteSelections[i].Id;
				localSelections[i].Name  = remoteSelections[i].Name;
				localSelections[i].Status  = remoteSelections[i].Status;
				localSelections[i].ResetCount  = remoteSelections[i].ResetCount;
				localSelections[i].DeductionFactor  = remoteSelections[i].DeductionFactor;

				if (remoteSelections[i].ForSidePrices != null)
					localSelections[i].PricesFor = PriceConverter.ConvertPricesTypeCollection(remoteSelections[i].ForSidePrices);

				if (remoteSelections[i].AgainstSidePrices != null)
					localSelections[i].PricesAgainst = PriceConverter.ConvertPricesTypeCollection(remoteSelections[i].AgainstSidePrices);
			}

			return localSelections;
		}
	}
}
