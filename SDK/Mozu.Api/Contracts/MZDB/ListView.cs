
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
using Newtonsoft.Json.Linq;


namespace Mozu.Api.Contracts.MZDB
{
		public class ListView
		{
			public string DefaultSort { get; set; }

			public string Filter { get; set; }

			public string Name { get; set; }

			public string Security { get; set; }

			public List<string> Usages { get; set; }

			public List<ListViewField> Fields { get; set; }

			public JObject MetaData { get; set; }

		}

}