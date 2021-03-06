
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

namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Authentication Tickets resource to generate and refresh authentication tickets for customer accounts.
	/// </summary>
	public partial class CustomerAuthTicketClient 	{
		
		/// <summary>
		/// Creates an authentication ticket for an anonymous shopper user.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateAnonymousShopperAuthTicket( responseFields);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> CreateAnonymousShopperAuthTicketClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAuthTicketUrl.CreateAnonymousShopperAuthTicketUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Generates a new authentication ticket for a customer account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userAuthInfo">The authentication information required to generate an authentication ticket for a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateUserAuthTicket( userAuthInfo,  responseFields);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> CreateUserAuthTicketClient(Mozu.Api.Contracts.Customer.CustomerUserAuthInfo userAuthInfo, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAuthTicketUrl.CreateUserAuthTicketUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerUserAuthInfo>(userAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// Refreshes an existing authentication ticket for a customer account by providing the refresh token string.
		/// </summary>
		/// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RefreshUserAuthTicket( refreshToken,  responseFields);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> RefreshUserAuthTicketClient(string refreshToken, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAuthTicketUrl.RefreshUserAuthTicketUrl(refreshToken, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


