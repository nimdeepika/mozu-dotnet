
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.PricingRuntime.ThirdParty
{
		public class TaxContext
		{
			public string CustomerId { get; set; }

			public string TaxContextId { get; set; }

			public string TaxExemptId { get; set; }

			public bool? TaxShipping { get; set; }

			public Address DestinationAddress { get; set; }

			public Address OriginAddress { get; set; }

		}

}