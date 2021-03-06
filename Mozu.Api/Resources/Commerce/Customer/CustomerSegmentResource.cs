
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

namespace Mozu.Api.Resources.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Segments resource to manage the segments that enable a client to manage groups of customers and target discounts for these segments. After a customer segment is defined, you can associate any number of customer accounts with it.
	/// </summary>
	public partial class CustomerSegmentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerSegmentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerSegmentResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerSegmentResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of defined customer segments according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegmentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegmentCollection = customersegment.GetSegments( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerSegmentCollection GetSegments(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.GetSegmentsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of defined customer segments according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegmentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegmentCollection = await customersegment.GetSegmentsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> GetSegmentsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.GetSegmentsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the customer segment specified in the request. This operation does not return a list of the customer accounts associated with the segment.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = customersegment.GetSegment( id,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerSegment GetSegment(int id, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.GetSegmentClient( id,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the customer segment specified in the request. This operation does not return a list of the customer accounts associated with the segment.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = await customersegment.GetSegmentAsync( id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegment> GetSegmentAsync(int id, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.GetSegmentClient( id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new customer segments. New customer segments do not have any associated customer accounts.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = customersegment.AddSegment( segment,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerSegment AddSegment(Mozu.Api.Contracts.Customer.CustomerSegment segment, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.AddSegmentClient( segment,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new customer segments. New customer segments do not have any associated customer accounts.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = await customersegment.AddSegmentAsync( segment,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegment> AddSegmentAsync(Mozu.Api.Contracts.Customer.CustomerSegment segment, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.AddSegmentClient( segment,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds one or more customer accounts to a defined customer segment.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="accountIds">List of customer account IDs to add to the customer segment specified in the request.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   customersegment.AddSegmentAccounts( accountIds,  id);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void AddSegmentAccounts(List<int> accountIds, int id)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.AddSegmentAccountsClient( accountIds,  id);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Adds one or more customer accounts to a defined customer segment.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="accountIds">List of customer account IDs to add to the customer segment specified in the request.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   await customersegment.AddSegmentAccountsAsync( accountIds,  id);
		/// </code>
		/// </example>
		public virtual async Task AddSegmentAccountsAsync(List<int> accountIds, int id)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.AddSegmentAccountsClient( accountIds,  id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates the details of the customer segment specified in the request.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = customersegment.UpdateSegment( segment,  id,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerSegment UpdateSegment(Mozu.Api.Contracts.Customer.CustomerSegment segment, int id, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.UpdateSegmentClient( segment,  id,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the details of the customer segment specified in the request.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = await customersegment.UpdateSegmentAsync( segment,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegment> UpdateSegmentAsync(Mozu.Api.Contracts.Customer.CustomerSegment segment, int id, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.UpdateSegmentClient( segment,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a customer segment specified by its unique identifier. Deleting a segment removes any customer account associations, but does not delete the customer account itself.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   customersegment.DeleteSegment( id);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteSegment(int id)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.DeleteSegmentClient( id);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a customer segment specified by its unique identifier. Deleting a segment removes any customer account associations, but does not delete the customer account itself.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   await customersegment.DeleteSegmentAsync( id);
		/// </code>
		/// </example>
		public virtual async Task DeleteSegmentAsync(int id)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.DeleteSegmentClient( id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Removes single account from a segment.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   customersegment.RemoveSegmentAccount( id,  accountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void RemoveSegmentAccount(int id, int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.RemoveSegmentAccountClient( id,  accountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Removes single account from a segment.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   await customersegment.RemoveSegmentAccountAsync( id,  accountId);
		/// </code>
		/// </example>
		public virtual async Task RemoveSegmentAccountAsync(int id, int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.RemoveSegmentAccountClient( id,  accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


