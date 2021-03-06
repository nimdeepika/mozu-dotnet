
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core
{
		///
		///	Properties of the scope in which a user operates, which represents a developer account or Mozu production tenant.
		///
		public class UserScope
		{
			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public int? Id { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///The type of scope, which is a developer account or production tenant.
			///
			public string Type { get; set; }

		}

}