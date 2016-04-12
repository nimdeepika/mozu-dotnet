
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class LocationInventoryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetLocationInventory
        /// </summary>
        /// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationInventoryUrl(string locationCode, string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}/{productCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLocationInventories
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationInventoriesUrl(string locationCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddLocationInventory
        /// </summary>
        /// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
        /// <param name="performUpserts">Query string parameter lets the service perform an update for a new or existing record. When run, the update occurs without throwing a conflict exception that the record exists. If true, the updates completes regardless of the record currently existing. By default, if no value is specified, the service assumes this value is false.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddLocationInventoryUrl(string locationCode, bool? performUpserts =  null)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}?performUpserts={performUpserts}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "performUpserts", performUpserts);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateLocationInventory
        /// </summary>
        /// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocationInventoryUrl(string locationCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteLocationInventory
        /// </summary>
        /// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteLocationInventoryUrl(string locationCode, string productCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}/{productCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		
	}
}

