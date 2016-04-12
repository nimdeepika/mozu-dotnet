
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The properties of a product, referenced and used by carts, orders, wish lists, and returns.
		///
		public class Product
		{
			///
			///List of shipping discounts that can be applied to the configured product. These discounts are calculated and updated as shoppers add content to their cart and continue checkout steps to order submission.
			///
			public List<Discount> AvailableShippingDiscounts { get; set; }

			///
			///Properties of a collection of component products that make up a single product bundle with its own product code. Tenants can define product bundles for any product type that supports the Bundle product usage.
			///
			public List<BundledProduct> BundledProducts { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.Product catalogEndDate ApiTypeMember DOCUMENT_HERE 
			///
			public DateTime? CatalogEndDate { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.Product catalogStartDate ApiTypeMember DOCUMENT_HERE 
			///
			public DateTime? CatalogStartDate { get; set; }

			///
			///The list of all categories associated with the product. These categories contain products, can have discounts associated, and define the grouping of products to display on the storefront.
			///
			public List<Category> Categories { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public ProductContent Content { get; set; }

			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime CreateDate { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.Product dateFirstAvailableInCatalog ApiTypeMember DOCUMENT_HERE 
			///
			public DateTime? DateFirstAvailableInCatalog { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.Product daysAvailableInCatalog ApiTypeMember DOCUMENT_HERE 
			///
			public int? DaysAvailableInCatalog { get; set; }

			///
			///List of supported types of fulfillment  for the product or variation. The types include direct ship, in-store pickup, or both. 
			///
			public List<string> FulfillmentTypesSupported { get; set; }

			///
			///The type of goods in a bundled product. A bundled product is composed of products associated to sell together. Possible values include “Physical” and “DigitalCredit”. This comes from the `productType `of the product. Products are defaulted to a Physical `goodsType`. Gift cards have a `goodsType `of DigitalCredit.
			///
			public string GoodsType { get; set; }

			///
			///Properties and data of inventory information for configured and bundled products. If product stock is managed, the data specifies out of stock behavior.
			///
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///Indicates if the object or feature is active. This indicator is used for subscriptions (at the site or tenant level), customer accounts, products and variations.
			///
			public bool? IsActive { get; set; }

			///
			///Indicates if the product must be shipped alone in a container. This is used for products and products within a bundle. If true, this product cannot be shipped in a package with other items and must ship in a package by itself.
			///
			public bool? IsPackagedStandAlone { get; set; }

			///
			///Indicates if the product in a cart, order, or wish list is purchased on a recurring schedule. If true, the item can be purchased or fulfilled at regular intervals, such as a monthly billing cycle. For example, digital or physical product subscriptions are recurring cart items. This property is not used at this time and is reserved for future functionality.
			///
			public bool IsRecurring { get; set; }

			///
			///Indicates if the item is subject to taxation, used by products, options, extras, cart and order items, line items, and wish lists. If true, the entity is subject to tax based on the relevant tax rate and rules.
			///
			public bool IsTaxable { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

			///
			///The manufacturer's part number for the product.
			///
			public string MfgPartNumber { get; set; }

			///
			///The list of manufacturer part numbers defined for the product.
			///
			public List<string> MfgPartNumbers { get; set; }

			///
			///List of option attributes configured for an object. These values are associated and used by products, product bundles, and product types.
			///
			public List<ProductOption> Options { get; set; }

			///
			///Unit price that the tenant intends to sell the product if no sale price is set.
			///
			public ProductPrice Price { get; set; }

			///
			///For products with options that vary the cost of the product, the range between lowest and highest possible price of the product based on the current selection of options.
			///
			public ProductPriceRange PriceRange { get; set; }

			///
			///Properties that describe the behavior the system uses when determining the price of products.
			///
			public ProductPricingBehaviorInfo PricingBehavior { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///Integer that represents the sequential order of the product.
			///
			public int? ProductSequence { get; set; }

			///
			///The product type template associated with the product on the storefront.
			///
			public string ProductType { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.Product productTypeId ApiTypeMember DOCUMENT_HERE 
			///
			public int? ProductTypeId { get; set; }

			///
			///The usage type that applies to this product, which is Standard (a single product without configurable options), Configurable (a product that includes configurable option attributes), Bundle (a collection of products sold as a single entity), or Component (an invididual product that represents a component in a bundle).
			///
			public string ProductUsage { get; set; }

			///
			///Collection of property attributes defined for the object. Properties are associated to all objects within Mozu, including documents, products, and product types.
			///
			public List<ProductProperty> Properties { get; set; }

			///
			///The current state of the document or product definition. States for documents include Active, Draft, or Latest. Active documents are published and cannot be deleted. Querying Latest returns the most recent version of the document, regardless of whether it is published or a draft. States for product include New, Draft, or Live.
			///
			public string PublishState { get; set; }

			///
			///The current state of the configured product determines whether or not the product is eligible for purchase. Products with options are only purchasable if the shopper has selected all required options. If the product is not ready for purchase, a message lists missing options that are required.
			///
			public ProductPurchasableState PurchasableState { get; set; }

			///
			///The universal product code (UPC) is the barcode defined for the product. The UPC is unique across all sales channels. 
			///
			public string Upc { get; set; }

			///
			///The list of universal product codes defined for the product.
			///
			public List<string> UpCs { get; set; }

			///
			///Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.
			///
			public string VariationProductCode { get; set; }

			///
			///A summary of all variations that exist for the product.
			///
			public List<VariationSummary> Variations { get; set; }

		}

}