
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Properties of a payment transaction submitted for an order.
		///
		public class Payment
		{
			///
			///The total monetary amount collected in this payment transaction for the order.
			///
			public decimal AmountCollected { get; set; }

			///
			///If the payment transaction is a shopper store credit, the total monetary amount credited in this payment transaction for the order.
			///
			public decimal AmountCredited { get; set; }

			///
			///The total amount originally requested for this payment.
			///
			public decimal AmountRequested { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Available actions you can complete for an order. These actions may differ depending on the status of the order, such as actions required to enter a payment, return of a package, and fulfillment of a shipment.
			///
			public List<string> AvailableActions { get; set; }

			///
			///Properties for the customer's billing information associated with an order or specific payment.
			///
			public BillingInfo BillingInfo { get; set; }

			///
			///Collection (list or paged) of change messages logged for each modification made by a shopper to their carts, wishlists, orders, package, payment, pickup, and returns. Change log messages are system-supplied based on shopper actions and read only.
			///
			public List<ChangeMessage> ChangeMessages { get; set; }

			public string ExternalTransactionId { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///Container for the interactions associated with the payment, which includes details for each action performed for the payment.
			///
			public List<PaymentInteraction> Interactions { get; set; }

			///
			///Indicates if the product in a cart, order, or wish list is purchased on a recurring schedule. If true, the item can be purchased or fulfilled at regular intervals, such as a monthly billing cycle. For example, digital or physical product subscriptions are recurring cart items. This property is not used at this time and is reserved for future functionality.
			///
			public bool IsRecurring { get; set; }

			///
			///Unique identifier of the order associated with the payment.
			///
			public string OrderId { get; set; }

			///
			///The transaction ID supplied by the payment service to associate with this order payment.
			///
			public string PaymentServiceTransactionId { get; set; }

			///
			///The type of payment, such as credit card, check, or PayPal Express. Additional payment types will be supported in future releases.
			///
			public string PaymentType { get; set; }

			public string PaymentWorkflow { get; set; }

			///
			///The current status of an object. This status is specific to the object including payment (New, Authorized, Captured, Declined, Failed, Voided, Credited, CheckRequested, or RolledBack), discount (Active, Scheduled, or Expired), returns (ReturnAuthorized), tenant, package (Fulfilled or NotFulfilled), application, master and product catalogs, orders (Pending, Submitted, Processing, Pending Review, Closed, or Canceled), and order validation results (Pass, Fail, Error, or Review).
			///
			public string Status { get; set; }

		}

}