
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
		///	The value selected for a facet when indexing a product search.
		///
		public class FacetValue
		{
			///
			///If applicable, the values of any subcategory facets in a hierarchy. Hierarchical facets only apply for product categories.
			///
			public List<FacetValue> ChildrenFacetValues { get; set; }

			///
			///The number of facet results for a product search.
			///
			public int Count { get; set; }

			///
			///Submits the selected facet value as a facet value filter.
			///
			public string FilterValue { get; set; }

			///
			///If true, the facet value is applied as a filter in the storefront product search.
			///
			public bool? IsApplied { get; set; }

			///
			///Indicates if the object is displayed on the storefront. If true, the admin product category is displayed in the store. If true, the category is not displayed.
			///
			public bool IsDisplayed { get; set; }

			///
			///Descriptive text used as a label for objects, such as field names, facets, date ranges, contact information, and package information.
			///
			public string Label { get; set; }

			///
			///If applicable, the values of any parent category facets in a hierarchy. Hierarchical facets only apply for product categories.
			///
			public string ParentFacetValue { get; set; }

			///
			///The maximum value selected or entered for the facet range query.
			///
			public string RangeQueryValueEnd { get; set; }

			///
			///The minimum value selected or entered for the facet range query.
			///
			public string RangeQueryValueStart { get; set; }

			///
			///The value of a property, used by numerous objects within Mozu including facets, attributes, products, localized content, metadata, capabilities (Mozu and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public string Value { get; set; }

		}

}