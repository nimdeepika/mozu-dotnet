
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Couponsets
{
	public partial class CouponUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAssignedDiscounts
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAssignedDiscountsUrl(string couponSetCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/assigneddiscounts";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetCoupon
        /// </summary>
        /// <param name="couponCode"></param>
        /// <param name="couponSetCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCouponUrl(string couponSetCode, string couponCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/coupons/{couponCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponCode", couponCode);
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetCoupons
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCouponsUrl(string couponSetCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/coupons?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetCouponSet
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCouponSetUrl(string couponSetCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AssignDiscount
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AssignDiscountUrl(string couponSetCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/assigneddiscounts";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddCoupons
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddCouponsUrl(string couponSetCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/coupons";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteCoupons
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCouponsUrl(string couponSetCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/coupons/remove";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateCouponSet
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateCouponSetUrl(string couponSetCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteCouponSet
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCouponSetUrl(string couponSetCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UnAssignDiscount
        /// </summary>
        /// <param name="couponSetCode"></param>
        /// <param name="discountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UnAssignDiscountUrl(string couponSetCode, int discountId)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/assigneddiscounts/{discountId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "discountId", discountId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteCoupon
        /// </summary>
        /// <param name="couponCode"></param>
        /// <param name="couponSetCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCouponUrl(string couponSetCode, string couponCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}/coupons/{couponCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponCode", couponCode);
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

		
	}
}

