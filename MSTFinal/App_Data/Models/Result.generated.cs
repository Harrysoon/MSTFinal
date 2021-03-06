//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.2.93
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Result</summary>
	[PublishedContentModel("result")]
	public partial class Result : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "result";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Result(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Result, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Client Description
		///</summary>
		[ImplementPropertyType("clientDescription")]
		public IHtmlString ClientDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("clientDescription"); }
		}

		///<summary>
		/// Client Name
		///</summary>
		[ImplementPropertyType("clientName")]
		public string ClientName
		{
			get { return this.GetPropertyValue<string>("clientName"); }
		}

		///<summary>
		/// Photos
		///</summary>
		[ImplementPropertyType("resultPhotos")]
		public string ResultPhotos
		{
			get { return this.GetPropertyValue<string>("resultPhotos"); }
		}
	}
}
