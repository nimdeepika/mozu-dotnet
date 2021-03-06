
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

namespace Mozu.Api.Resources.Commerce.Customer.Credits
{
	/// <summary>
	/// Use the Customer Credit Audit Entries subresource to retrieve entries logged in the audit report of a store credit or gift card applied to a customer account. The system creates a new audit entry when the credit is created, deleted, activated, or deactivated. The system then creates a new audit entry each time the credit is updated or redeemed in a transaction.
	/// </summary>
	public partial class CreditAuditEntryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CreditAuditEntryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CreditAuditEntryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CreditAuditEntryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the list of audit entries for the credit, according to any filter or sort criteria specified in the request.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var creditauditentry = new CreditAuditEntry();
		///   var creditAuditEntryCollection = creditauditentry.GetAuditEntries( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection GetAuditEntries(string code, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Credits.CreditAuditEntryClient.GetAuditEntriesClient( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of audit entries for the credit, according to any filter or sort criteria specified in the request.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var creditauditentry = new CreditAuditEntry();
		///   var creditAuditEntryCollection = await creditauditentry.GetAuditEntriesAsync( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection> GetAuditEntriesAsync(string code, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Credits.CreditAuditEntryClient.GetAuditEntriesClient( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


