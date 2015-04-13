
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


namespace Mozu.Api.Contracts.CommerceRuntime.Products
{
		///
		///	Details of a property attribute defined for a product.
		///
		public class ProductProperty
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
			///Indicates if the object has or can have multiple properties or values. If true, the object can have more than one value, selectable by shoppers through the storefront or configurable through the catalogs. 
			///
			public bool IsMultiValue { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///List of value data for objects.
			///
			public List<ProductPropertyValue> Values { get; set; }

		}

}