
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.PaymentService
{
		///
		///	Properties of the credential fields associated with the payment gateway.
		///
		public class GatewayCredentialFieldDefinition
		{
			///
			///The sequential display order of the gateway in Mozu Admin.
			///
			public int AdminDisplayOrder { get; set; }

			///
			///The name that displays for the payment gateway.
			///
			public string DisplayName { get; set; }

			///
			///The localizable name of the payment gateway.
			///
			public string Name { get; set; }

			public string VolusionStoreName { get; set; }

		}

}