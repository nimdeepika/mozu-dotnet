
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Manage the results of order validation.
	/// </summary>
	public partial class OrderValidationResultClient 	{
		
		/// <summary>
		/// Retrieves a list of the validation results associated with the order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetValidationResults( orderId);
		///   var orderValidationResultClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult>> GetValidationResultsClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderValidationResultUrl.GetValidationResultsUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Add a new order validation result to a submitted order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="validationResult">Properties of the resulting order validation performed by an order validation capability.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddValidationResult( validationResult,  orderId,  responseFields);
		///   var orderValidationResultClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult> AddValidationResultClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult validationResult, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderValidationResultUrl.AddValidationResultUrl(orderId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult>(validationResult);
			return mozuClient;

		}


	}

}


