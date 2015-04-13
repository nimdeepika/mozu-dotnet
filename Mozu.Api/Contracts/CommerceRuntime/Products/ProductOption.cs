
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Products
{
		///
		///	An option attribute configured for a product on a storefront.
		///
		public class ProductOption
		{
			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///The data type of the source product property, typically of type Bool, DateTime, Number, or String.
			///
			public string DataType { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///The value a shopper entered for an attribute that requires additional input for the product on a storefront. This entered value is a selected option or entered content for an extra, such as selecting a color or entering content for a monogram.
			///
			public object ShopperEnteredValue { get; set; }

			///
			///If the object value is a String, this value provides that string value, used by vocabulary property values, products, and options.
			///
			public string StringValue { get; set; }

			///
			///The value of a property, used by numerous objects within Mozu including facets, attributes, products, localized content, metadata, capabilities (Mozu and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public object Value { get; set; }

		}

}