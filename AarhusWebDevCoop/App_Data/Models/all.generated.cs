using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.0.90
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------













namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1048 with alias "master"
	/// <summary>Master</summary>
	public partial interface IMaster : IPublishedContent
	{
		/// <summary>MetaDescription</summary>
		string MetaDescription { get; }

		/// <summary>MetaKeywords</summary>
		string MetaKeywords { get; }

		/// <summary>Hide from menu</summary>
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// MetaDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for MetaDescription</summary>
		public static string GetMetaDescription(IMaster that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return GetMetaKeywords(this); }
		}

		/// <summary>Static getter for MetaKeywords</summary>
		public static string GetMetaKeywords(IMaster that) { return that.GetPropertyValue<string>("metaKeywords"); }

		///<summary>
		/// Hide from menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for Hide from menu</summary>
		public static bool GetUmbracoNaviHide(IMaster that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// Main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("mainContent"); }
		}

		///<summary>
		/// SiteTitle
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}

		///<summary>
		/// MetaDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Master.GetMetaDescription(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// Hide from menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>About</summary>
	[PublishedContentModel("about")]
	public partial class About : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "about";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public About(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// Main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public Newtonsoft.Json.Linq.JToken MainContent
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("mainContent"); }
		}

		///<summary>
		/// MetaDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Master.GetMetaDescription(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// Hide from menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>News</summary>
	[PublishedContentModel("news")]
	public partial class News : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "news";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public News(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<News, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// MainContent
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("mainContent"); }
		}

		///<summary>
		/// MetaDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Master.GetMetaDescription(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// Hide from menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>NewsItem</summary>
	[PublishedContentModel("article")]
	public partial class Article : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "article";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Article(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Info
		///</summary>
		[ImplementPropertyType("info")]
		public string Info
		{
			get { return this.GetPropertyValue<string>("info"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Project</summary>
	[PublishedContentModel("projectMain")]
	public partial class ProjectMain : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectMain";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectMain(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectMain, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// Main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("mainContent"); }
		}

		///<summary>
		/// MetaDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Master.GetMetaDescription(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// Hide from menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>ProjectItem</summary>
	[PublishedContentModel("projectItem")]
	public partial class ProjectItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Info
		///</summary>
		[ImplementPropertyType("info")]
		public IHtmlString Info
		{
			get { return this.GetPropertyValue<IHtmlString>("info"); }
		}

		///<summary>
		/// Status
		///</summary>
		[ImplementPropertyType("status")]
		public object Status
		{
			get { return this.GetPropertyValue("status"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// Main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("mainContent"); }
		}
	}

	/// <summary>Comment</summary>
	[PublishedContentModel("comment")]
	public partial class Comment : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "comment";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Comment(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Comment, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Name
		///</summary>
		[ImplementPropertyType("commentName")]
		public string CommentName
		{
			get { return this.GetPropertyValue<string>("commentName"); }
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("email")]
		public string Email
		{
			get { return this.GetPropertyValue<string>("email"); }
		}

		///<summary>
		/// Message
		///</summary>
		[ImplementPropertyType("message")]
		public string Message
		{
			get { return this.GetPropertyValue<string>("message"); }
		}

		///<summary>
		/// Subject
		///</summary>
		[ImplementPropertyType("subject")]
		public string Subject
		{
			get { return this.GetPropertyValue<string>("subject"); }
		}
	}

	/// <summary>Login</summary>
	[PublishedContentModel("login")]
	public partial class Login : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "login";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Login(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Login, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}

		///<summary>
		/// MainContent
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("mainContent"); }
		}
	}

	/// <summary>Members</summary>
	[PublishedContentModel("members")]
	public partial class Members : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "members";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Members(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Members, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public string Header
		{
			get { return this.GetPropertyValue<string>("header"); }
		}
	}

	/// <summary>Restricted</summary>
	[PublishedContentModel("restricted")]
	public partial class Restricted : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "restricted";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Restricted(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Restricted, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// MetaDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Master.GetMetaDescription(this); }
		}

		///<summary>
		/// MetaKeywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// Hide from menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Master.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Prospect</summary>
	[PublishedContentModel("prospect")]
	public partial class Prospect : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "prospect";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Prospect(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Prospect, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Firstname
		///</summary>
		[ImplementPropertyType("firstname")]
		public string Firstname
		{
			get { return this.GetPropertyValue<string>("firstname"); }
		}

		///<summary>
		/// Lastname
		///</summary>
		[ImplementPropertyType("lastname")]
		public string Lastname
		{
			get { return this.GetPropertyValue<string>("lastname"); }
		}

		///<summary>
		/// Mobile
		///</summary>
		[ImplementPropertyType("mobile")]
		public string Mobile
		{
			get { return this.GetPropertyValue<string>("mobile"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

	/// <summary>Active</summary>
	[PublishedContentModel("active")]
	public partial class Active : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "active";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Active(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Active, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("address")]
		public string Address
		{
			get { return this.GetPropertyValue<string>("address"); }
		}

		///<summary>
		/// City
		///</summary>
		[ImplementPropertyType("city")]
		public string City
		{
			get { return this.GetPropertyValue<string>("city"); }
		}

		///<summary>
		/// Firstname
		///</summary>
		[ImplementPropertyType("firstname")]
		public string Firstname
		{
			get { return this.GetPropertyValue<string>("firstname"); }
		}

		///<summary>
		/// Lastname
		///</summary>
		[ImplementPropertyType("lastname")]
		public string Lastname
		{
			get { return this.GetPropertyValue<string>("lastname"); }
		}

		///<summary>
		/// Mobile
		///</summary>
		[ImplementPropertyType("mobile")]
		public string Mobile
		{
			get { return this.GetPropertyValue<string>("mobile"); }
		}

		///<summary>
		/// Photo
		///</summary>
		[ImplementPropertyType("photo")]
		public Umbraco.Web.Models.ImageCropDataSet Photo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("photo"); }
		}

		///<summary>
		/// Skills
		///</summary>
		[ImplementPropertyType("skills")]
		public object Skills
		{
			get { return this.GetPropertyValue("skills"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}

		///<summary>
		/// Zip
		///</summary>
		[ImplementPropertyType("zip")]
		public string Zip
		{
			get { return this.GetPropertyValue<string>("zip"); }
		}
	}

}



// EOF
