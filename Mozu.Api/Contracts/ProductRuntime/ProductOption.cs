
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
		///	Properties of the product option to create such as attribute detail, fully qualified name, and list of product option values.
		///
		public class ProductOption
		{
			///
			///Detail data for a product or product options attribute. This acts as a wrapper for the properties to configure or generate from the system in the product Admin. Properties may include namespace, attribute code, attribute sequence, site group ID, input type, and value.
			///
			public AttributeDetail AttributeDetail { get; set; }

			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///Indicates if the object has or can have multiple properties or values. If true, the object can have more than one value, selectable by shoppers through the storefront or configurable through the catalogs. 
			///
			public bool? IsMultiValue { get; set; }

			///
			///Indicates if the property, attribute, product option, or product extra is required. If true, the object must have a defined value.
			///
			public bool? IsRequired { get; set; }

			///
			///List of value data for objects.
			///
			public List<ProductOptionValue> Values { get; set; }

		}

}