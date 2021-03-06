
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Content
{
		///
		///	Summary properties of an unpublished document draft.
		///
		public class DocumentDraftSummary
		{
			///
			///Detailed information of the date and time for the active update date for the document draft summary. This data is associated to document and content data.
			///
			public DateTime? ActiveUpdateDate { get; set; }

			///
			///Mozu.Content.Contracts.DocumentDraftSummary activeUpdatedBy ApiTypeMember DOCUMENT_HERE 
			///
			public string ActiveUpdatedBy { get; set; }

			///
			///The unique identifier for the product catalog. Catalogs are part of a master catalog.
			///
			public int? CatalogId { get; set; }

			///
			///Fully qualified name of the document type. 
			///
			public string DocumentTypeFQN { get; set; }

			///
			///Detailed information of the date and time for the draft update date for the document draft summary. This data is associated to document and content data.
			///
			public DateTime DraftUpdateDate { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The fully qualified name of the document list.
			///
			public string ListFQN { get; set; }

			///
			///Unique identifier for the master catalog. 
			///
			public int? MasterCatalogId { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///Mozu.Content.Contracts.DocumentDraftSummary publishSetCode ApiTypeMember DOCUMENT_HERE 
			///
			public string PublishSetCode { get; set; }

			///
			///Whether the draft has been published.
			///
			public string PublishType { get; set; }

			///
			///Unique identifier for the site. This ID is used at all levels of a store, catalog, and tenant to associate objects to a site.
			///
			public int? SiteId { get; set; }

			///
			///Unique identifier of the user who last modified the item. This value is system-supplied and read-only.
			///
			public string UpdatedBy { get; set; }

		}

}