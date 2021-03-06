
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
	/// Allows you to create and manage products that you will offer on your storefront. You can create products with options that a shopper configures (such as a T-shirt color and size). You can set discounts and sale prices for your products, manage product inventory, and more.
	/// </summary>
	public partial class PriceListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PriceListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PriceListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PriceListResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// admin-pricelists Get GetPriceLists description DOCUMENT_HERE 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceListCollection = pricelist.GetPriceLists( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceListCollection GetPriceLists(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.GetPriceListsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-pricelists Get GetPriceLists description DOCUMENT_HERE 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceListCollection = await pricelist.GetPriceListsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceListCollection> GetPriceListsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.GetPriceListsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-pricelists Get GetPriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = pricelist.GetPriceList( priceListCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceList GetPriceList(string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.GetPriceListClient( priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-pricelists Get GetPriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.GetPriceListAsync( priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceList> GetPriceListAsync(string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.GetPriceListClient( priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-pricelists Post AddPriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="priceList">Mozu.ProductAdmin.Contracts.PriceList ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = pricelist.AddPriceList( priceList,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceList AddPriceList(Mozu.Api.Contracts.ProductAdmin.PriceList priceList, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.AddPriceListClient( priceList,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-pricelists Post AddPriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="priceList">Mozu.ProductAdmin.Contracts.PriceList ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.AddPriceListAsync( priceList,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceList> AddPriceListAsync(Mozu.Api.Contracts.ProductAdmin.PriceList priceList, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.AddPriceListClient( priceList,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-pricelists Put UpdatePriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="priceList">Mozu.ProductAdmin.Contracts.PriceList ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = pricelist.UpdatePriceList( priceList,  priceListCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceList UpdatePriceList(Mozu.Api.Contracts.ProductAdmin.PriceList priceList, string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.UpdatePriceListClient( priceList,  priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-pricelists Put UpdatePriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="priceList">Mozu.ProductAdmin.Contracts.PriceList ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.UpdatePriceListAsync( priceList,  priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceList> UpdatePriceListAsync(Mozu.Api.Contracts.ProductAdmin.PriceList priceList, string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.UpdatePriceListClient( priceList,  priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-pricelists Delete DeletePriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="cascadeDeleteEntries"></param>
		/// <param name="priceListCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   pricelist.DeletePriceList( priceListCode,  cascadeDeleteEntries);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeletePriceList(string priceListCode, bool? cascadeDeleteEntries =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.DeletePriceListClient( priceListCode,  cascadeDeleteEntries);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// admin-pricelists Delete DeletePriceList description DOCUMENT_HERE 
		/// </summary>
		/// <param name="cascadeDeleteEntries"></param>
		/// <param name="priceListCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   await pricelist.DeletePriceListAsync( priceListCode,  cascadeDeleteEntries);
		/// </code>
		/// </example>
		public virtual async Task DeletePriceListAsync(string priceListCode, bool? cascadeDeleteEntries =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.DeletePriceListClient( priceListCode,  cascadeDeleteEntries);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


