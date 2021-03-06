
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Refunds
{
		///
		///	Mozu.CommerceRuntime.Contracts.Refunds.Refund ApiType DOCUMENT_HERE 
		///
		public class Refund
		{
			///
			///Amount refunded.
			///
			public decimal Amount { get; set; }

			///
			///Basic audit info about the object, including date, time, and user account. Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///Unique identifier of the order associated with the payment.
			///
			public string OrderId { get; set; }

			///
			///The payment associated with this refund (if applicable).
			///
			public Payment Payment { get; set; }

			///
			///The reason description for an action, including item return, coupon not valid, and item is taxed. 
			///
			public string Reason { get; set; }

		}

}