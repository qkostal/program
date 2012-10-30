using System;

namespace GBE_Data.DataObjects
{
	// Common enums used by the web service.
	// Note, the web service simply returns values, it is up to the client 
	//  to translate to an enum or use lookup tables.


	public enum OrderStatus
	{
		Unmatched = 1,
		Matched = 2,
		Cancelled = 3,
		Settled = 4,
		Void = 5, 
		Suspended = 6
	}


	public enum Polarity
	{
		For = 1,
		Against = 2
	}

	
	public enum MultipleBetStatus
	{
		Active = 1,
		Voided = 2,
		SettledFor = 3,
		SettledAgainst = 4
	}
}