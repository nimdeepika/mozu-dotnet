
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Discounts
{
		///
		///	Discount applied to the order, which is a negative number, which is to be subtracted from the original price to get the final price for a particular line item. If multiple discounts for the order exist, this is the value most advantageous to the shopper.
		///
		public class AppliedLineItemProductDiscount
		{
			///
			///Determines if the discount applies to the sale price of the order.
			///
			public bool? AppliesToSalePrice { get; set; }

			///
			///Alphanumeric code associated with the coupon or promotion that results in a discounted price.
			///
			public string CouponCode { get; set; }

			///
			///Name of the discount added and applied to a shopping cart and order for a shopper's purchase. 
			///
			public Discount Discount { get; set; }

			///
			///The number of the line items that are used for this particular discount.
			///
			public int DiscountQuantity { get; set; }

			///
			///Indicates if a discount is not used for the product or product line item in an order. If true, the system ignores this discount when pricing the order.
			///
			public bool? Excluded { get; set; }

			///
			///The value of the discount applied to the cart or order, represented as a negative currency amount to apply to the original price.
			///
			public decimal? Impact { get; set; }

			///
			///The impact of a discount for each discount quantity. 
			///
			public decimal? ImpactPerUnit { get; set; }

			///
			///Quantity of products priced. This is always one unless calculating pricing on the order or cart.
			///
			public int? ProductQuantity { get; set; }

		}

}