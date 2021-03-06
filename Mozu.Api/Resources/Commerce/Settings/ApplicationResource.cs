
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

namespace Mozu.Api.Resources.Commerce.Settings
{
	/// <summary>
	/// Use the Applications resource to update site-specific settings for installed applications.
	/// </summary>
	public partial class ApplicationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ApplicationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ApplicationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ApplicationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieve the settings of a third-party application.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Application.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = application.ThirdPartyGetApplication( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Application.Application ThirdPartyGetApplication(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Application.Application> response;
			var client = Mozu.Api.Clients.Commerce.Settings.ApplicationClient.ThirdPartyGetApplicationClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieve the settings of a third-party application.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Application.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = await application.ThirdPartyGetApplicationAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Application.Application> ThirdPartyGetApplicationAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Application.Application> response;
			var client = Mozu.Api.Clients.Commerce.Settings.ApplicationClient.ThirdPartyGetApplicationClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Initializes an application with the necessary configured settings.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="application">Properties of an application installed in a tenant.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Application.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = application.ThirdPartyUpdateApplication( application,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Application.Application ThirdPartyUpdateApplication(Mozu.Api.Contracts.SiteSettings.Application.Application application, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Application.Application> response;
			var client = Mozu.Api.Clients.Commerce.Settings.ApplicationClient.ThirdPartyUpdateApplicationClient( application,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Initializes an application with the necessary configured settings.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="application">Properties of an application installed in a tenant.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Application.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = await application.ThirdPartyUpdateApplicationAsync( application,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Application.Application> ThirdPartyUpdateApplicationAsync(Mozu.Api.Contracts.SiteSettings.Application.Application application, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Application.Application> response;
			var client = Mozu.Api.Clients.Commerce.Settings.ApplicationClient.ThirdPartyUpdateApplicationClient( application,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


