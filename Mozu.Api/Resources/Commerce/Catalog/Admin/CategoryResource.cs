
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Categories resource to organize products and control where they appear on the storefront. Create and maintain a hierarchy of categories and subcategories where the site will store properties.
	/// </summary>
	public partial class CategoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CategoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CategoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CategoryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection GetCategories(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetCategoriesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = await category.GetCategoriesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection> GetCategoriesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetCategoriesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the list of subcategories within a category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = category.GetChildCategories( categoryId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.CategoryCollection GetChildCategories(int categoryId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetChildCategoriesClient( categoryId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of subcategories within a category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = await category.GetChildCategoriesAsync( categoryId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.CategoryCollection> GetChildCategoriesAsync(int categoryId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetChildCategoriesClient( categoryId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.GetCategory( categoryId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Category GetCategory(int categoryId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetCategoryClient( categoryId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = await category.GetCategoryAsync( categoryId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Category> GetCategoryAsync(int categoryId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetCategoryClient( categoryId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a new category to the site's category hierarchy. Specify a ParentCategoryID to determine where to place the category in the hierarchy. If no ParentCategoryID is specified, the new category is a top-level category.
		/// </summary>
		/// <param name="incrementSequence">If true, when adding a new product category, set the sequence number of the new category to an increment of one integer greater than the maximum available sequence number across all product categories. If false, set the sequence number to zero.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="category">A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.AddCategory( category,  incrementSequence,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Category AddCategory(Mozu.Api.Contracts.ProductAdmin.Category category, bool? incrementSequence =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.AddCategoryClient( category,  incrementSequence,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds a new category to the site's category hierarchy. Specify a ParentCategoryID to determine where to place the category in the hierarchy. If no ParentCategoryID is specified, the new category is a top-level category.
		/// </summary>
		/// <param name="incrementSequence">If true, when adding a new product category, set the sequence number of the new category to an increment of one integer greater than the maximum available sequence number across all product categories. If false, set the sequence number to zero.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="category">A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = await category.AddCategoryAsync( category,  incrementSequence,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Category> AddCategoryAsync(Mozu.Api.Contracts.ProductAdmin.Category category, bool? incrementSequence =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.AddCategoryClient( category,  incrementSequence,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Modifies the sequence and hierarchy of multiple categories in a category tree in one operation. This is better for moving a category to a different location in the tree and adjusting the order of multiple categories than doing individual category updates.
		/// </summary>
		/// <param name="categorySequencies">Mozu.ProductAdmin.Contracts.CategorySequenceCollection ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   category.UpdateCategoryTree( categorySequencies);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void UpdateCategoryTree(Mozu.Api.Contracts.ProductAdmin.CategorySequenceCollection categorySequencies)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.UpdateCategoryTreeClient( categorySequencies);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Modifies the sequence and hierarchy of multiple categories in a category tree in one operation. This is better for moving a category to a different location in the tree and adjusting the order of multiple categories than doing individual category updates.
		/// </summary>
		/// <param name="categorySequencies">Mozu.ProductAdmin.Contracts.CategorySequenceCollection ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   await category.UpdateCategoryTreeAsync( categorySequencies);
		/// </code>
		/// </example>
		public virtual async Task UpdateCategoryTreeAsync(Mozu.Api.Contracts.ProductAdmin.CategorySequenceCollection categorySequencies)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.UpdateCategoryTreeClient( categorySequencies);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Validates the precomputed dynamic category expression.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dynamicExpressionIn">Mozu.ProductAdmin.Contracts.DynamicExpression ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DynamicExpression"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var dynamicExpression = category.ValidateDynamicExpression( dynamicExpressionIn,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.DynamicExpression ValidateDynamicExpression(Mozu.Api.Contracts.ProductAdmin.DynamicExpression dynamicExpressionIn, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.ValidateDynamicExpressionClient( dynamicExpressionIn,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Validates the precomputed dynamic category expression.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dynamicExpressionIn">Mozu.ProductAdmin.Contracts.DynamicExpression ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DynamicExpression"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var dynamicExpression = await category.ValidateDynamicExpressionAsync( dynamicExpressionIn,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> ValidateDynamicExpressionAsync(Mozu.Api.Contracts.ProductAdmin.DynamicExpression dynamicExpressionIn, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.ValidateDynamicExpressionClient( dynamicExpressionIn,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Validates the realtime dynamic expression.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dynamicExpressionIn">Mozu.ProductAdmin.Contracts.DynamicExpression ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DynamicExpression"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var dynamicExpression = category.ValidateRealTimeDynamicExpression( dynamicExpressionIn,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.DynamicExpression ValidateRealTimeDynamicExpression(Mozu.Api.Contracts.ProductAdmin.DynamicExpression dynamicExpressionIn, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.ValidateRealTimeDynamicExpressionClient( dynamicExpressionIn,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Validates the realtime dynamic expression.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dynamicExpressionIn">Mozu.ProductAdmin.Contracts.DynamicExpression ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DynamicExpression"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var dynamicExpression = await category.ValidateRealTimeDynamicExpressionAsync( dynamicExpressionIn,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> ValidateRealTimeDynamicExpressionAsync(Mozu.Api.Contracts.ProductAdmin.DynamicExpression dynamicExpressionIn, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.ValidateRealTimeDynamicExpressionClient( dynamicExpressionIn,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the properties of a defined category or move it to another location in the category hierarchy. Because this operation replaces the defined resource,include all the information to maintain for the category in the request.
		/// </summary>
		/// <param name="cascadeVisibility">If true, when changing the display option for the category, change it for all subcategories also. The default value is false.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="category">A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.UpdateCategory( category,  categoryId,  cascadeVisibility,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Category UpdateCategory(Mozu.Api.Contracts.ProductAdmin.Category category, int categoryId, bool? cascadeVisibility =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.UpdateCategoryClient( category,  categoryId,  cascadeVisibility,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Update the properties of a defined category or move it to another location in the category hierarchy. Because this operation replaces the defined resource,include all the information to maintain for the category in the request.
		/// </summary>
		/// <param name="cascadeVisibility">If true, when changing the display option for the category, change it for all subcategories also. The default value is false.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="category">A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = await category.UpdateCategoryAsync( category,  categoryId,  cascadeVisibility,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Category> UpdateCategoryAsync(Mozu.Api.Contracts.ProductAdmin.Category category, int categoryId, bool? cascadeVisibility =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.UpdateCategoryClient( category,  categoryId,  cascadeVisibility,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the category specified by its category ID.
		/// </summary>
		/// <param name="cascadeDelete">Specifies whether to also delete all subcategories associated with the specified category.If you set this value is false, only the specified category is deleted.The default value is false.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="forceDelete">Specifies whether the category, and any associated subcategories, are deleted even if there are products that reference them. The default value is false.</param>
		/// <param name="reassignToParent">Specifies whether any subcategories of the specified category are reassigned to the parent of the specified category.This field only applies if the cascadeDelete parameter is false.The default value is false.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   category.DeleteCategoryById( categoryId,  cascadeDelete,  forceDelete,  reassignToParent);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCategoryById(int categoryId, bool? cascadeDelete =  null, bool? forceDelete =  null, bool? reassignToParent =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.DeleteCategoryByIdClient( categoryId,  cascadeDelete,  forceDelete,  reassignToParent);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the category specified by its category ID.
		/// </summary>
		/// <param name="cascadeDelete">Specifies whether to also delete all subcategories associated with the specified category.If you set this value is false, only the specified category is deleted.The default value is false.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="forceDelete">Specifies whether the category, and any associated subcategories, are deleted even if there are products that reference them. The default value is false.</param>
		/// <param name="reassignToParent">Specifies whether any subcategories of the specified category are reassigned to the parent of the specified category.This field only applies if the cascadeDelete parameter is false.The default value is false.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   await category.DeleteCategoryByIdAsync( categoryId,  cascadeDelete,  forceDelete,  reassignToParent);
		/// </code>
		/// </example>
		public virtual async Task DeleteCategoryByIdAsync(int categoryId, bool? cascadeDelete =  null, bool? forceDelete =  null, bool? reassignToParent =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.DeleteCategoryByIdClient( categoryId,  cascadeDelete,  forceDelete,  reassignToParent);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


