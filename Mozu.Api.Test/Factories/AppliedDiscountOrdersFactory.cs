//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use this subresource to apply coupons to or remove coupons from an order based on a supplied coupon code.
	/// </summary>
	public partial class AppliedDiscountOrdersFactory : BaseDataFactory
	{

		/// <summary> 
		/// Apply a coupon to the order.
		/// <example> 
		///  <code> 
		/// var result = AppliedDiscountFactory.ApplyCoupon(handler : handler,  orderId :  orderId,  couponCode :  couponCode,  updateMode :  updateMode,  version :  version,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyCoupon(ServiceClientMessageHandler handler, 
 		 string orderId, string couponCode, string updateMode = null, string version = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AppliedDiscountClient.ApplyCouponClient(
				 orderId :  orderId,  couponCode :  couponCode,  updateMode :  updateMode,  version :  version,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Removes a coupon previously applied to the order.
		/// <example> 
		///  <code> 
		/// var result = AppliedDiscountFactory.RemoveCoupon(handler : handler,  orderId :  orderId,  couponCode :  couponCode,  updateMode :  updateMode,  version :  version,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveCoupon(ServiceClientMessageHandler handler, 
 		 string orderId, string couponCode, string updateMode = null, string version = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AppliedDiscountClient.RemoveCouponClient(
				 orderId :  orderId,  couponCode :  couponCode,  updateMode :  updateMode,  version :  version		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Removes all coupons previously applied to the order.
		/// <example> 
		///  <code> 
		/// var result = AppliedDiscountFactory.RemoveCoupons(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveCoupons(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode = null, string version = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AppliedDiscountClient.RemoveCouponsClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


