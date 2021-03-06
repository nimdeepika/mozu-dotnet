
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

namespace Mozu.Api.Urls.Commerce.Catalog.Storefront
{
	public partial class PriceListUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPriceList
        /// </summary>
        /// <param name="priceListCode"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPriceListUrl(string priceListCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/pricelists/{priceListCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "priceListCode", priceListCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetResolvedPriceList
        /// </summary>
        /// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetResolvedPriceListUrl(int? customerAccountId =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/pricelists/resolved?customerAccountId={customerAccountId}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "customerAccountId", customerAccountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

								
	}
}

