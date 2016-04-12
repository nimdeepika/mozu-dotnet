
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
	public partial class CategoryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetCategories
        /// </summary>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCategoriesUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetChildCategories
        /// </summary>
        /// <param name="categoryId">Unique identifier of the category to modify.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetChildCategoriesUrl(int categoryId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/{categoryId}/children?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "categoryId", categoryId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetCategory
        /// </summary>
        /// <param name="categoryId">Unique identifier of the category to modify.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCategoryUrl(int categoryId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/{categoryId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "categoryId", categoryId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddCategory
        /// </summary>
        /// <param name="incrementSequence">If true, when adding a new product category, set the sequence number of the new category to an increment of one integer greater than the maximum available sequence number across all product categories. If false, set the sequence number to zero.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddCategoryUrl(bool? incrementSequence =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/?incrementSequence={incrementSequence}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "incrementSequence", incrementSequence);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateCategoryTree
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateCategoryTreeUrl()
		{
			var url = "/api/commerce/catalog/admin/categories/category-tree";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateDynamicExpression
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateDynamicExpressionUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/ValidateDynamicExpression?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateRealTimeDynamicExpression
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateRealTimeDynamicExpressionUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/ValidateRealTimeDynamicExpression?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateCategory
        /// </summary>
        /// <param name="cascadeVisibility">If true, when changing the display option for the category, change it for all subcategories also. The default value is false.</param>
        /// <param name="categoryId">Unique identifier of the category to modify.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateCategoryUrl(int categoryId, bool? cascadeVisibility =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/{categoryId}?cascadeVisibility={cascadeVisibility}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cascadeVisibility", cascadeVisibility);
			mozuUrl.FormatUrl( "categoryId", categoryId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteCategoryById
        /// </summary>
        /// <param name="cascadeDelete">Specifies whether to also delete all subcategories associated with the specified category.If you set this value is false, only the specified category is deleted.The default value is false.</param>
        /// <param name="categoryId">Unique identifier of the category to modify.</param>
        /// <param name="forceDelete">Specifies whether the category, and any associated subcategories, are deleted even if there are products that reference them. The default value is false.</param>
        /// <param name="reassignToParent">Specifies whether any subcategories of the specified category are reassigned to the parent of the specified category.This field only applies if the cascadeDelete parameter is false.The default value is false.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCategoryByIdUrl(int categoryId, bool? cascadeDelete =  null, bool? forceDelete =  null, bool? reassignToParent =  null)
		{
			var url = "/api/commerce/catalog/admin/categories/{categoryId}/?cascadeDelete={cascadeDelete}&forceDelete={forceDelete}&reassignToParent={reassignToParent}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cascadeDelete", cascadeDelete);
			mozuUrl.FormatUrl( "categoryId", categoryId);
			mozuUrl.FormatUrl( "forceDelete", forceDelete);
			mozuUrl.FormatUrl( "reassignToParent", reassignToParent);
			return mozuUrl;
		}

		
	}
}

