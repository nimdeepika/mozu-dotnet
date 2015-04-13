
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
	/// 
	/// </summary>
	public partial class SoftAllocationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public SoftAllocationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public SoftAllocationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new SoftAllocationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocationCollection = softallocation.GetSoftAllocations( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection GetSoftAllocations(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocationCollection = await softallocation.GetSoftAllocationsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> GetSoftAllocationsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.GetSoftAllocation( softAllocationId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SoftAllocation GetSoftAllocation(int softAllocationId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationClient( softAllocationId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.GetSoftAllocationAsync( softAllocationId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> GetSoftAllocationAsync(int softAllocationId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationClient( softAllocationId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationsIn"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.AddSoftAllocations( softAllocationsIn);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> AddSoftAllocations(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocationsIn)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.AddSoftAllocationsClient( softAllocationsIn);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationsIn"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.AddSoftAllocationsAsync( softAllocationsIn);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> AddSoftAllocationsAsync(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocationsIn)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.AddSoftAllocationsClient( softAllocationsIn);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var productReservation = softallocation.ConvertToProductReservation( softAllocations);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> ConvertToProductReservation(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.ConvertToProductReservationClient( softAllocations);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var productReservation = await softallocation.ConvertToProductReservationAsync( softAllocations);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> ConvertToProductReservationAsync(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.ConvertToProductReservationClient( softAllocations);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.UpdateSoftAllocations( softAllocations);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> UpdateSoftAllocations(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.UpdateSoftAllocationsClient( softAllocations);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.UpdateSoftAllocationsAsync( softAllocations);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> UpdateSoftAllocationsAsync(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.UpdateSoftAllocationsClient( softAllocations);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   softallocation.DeleteSoftAllocation( softAllocationId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteSoftAllocation(int softAllocationId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.DeleteSoftAllocationClient( softAllocationId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   await softallocation.DeleteSoftAllocationAsync( softAllocationId);
		/// </code>
		/// </example>
		public virtual async Task DeleteSoftAllocationAsync(int softAllocationId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.DeleteSoftAllocationClient( softAllocationId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

