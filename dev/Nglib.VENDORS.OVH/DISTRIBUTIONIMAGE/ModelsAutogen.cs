//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Newtonsoft.Json;
using Nglib.VENDORS.OVH.SHARED;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;


// [GET] "/distribution/image/{serviceType}"  string[]--serviceType
//[GET] "/distribution/image/{serviceType}/{imageName}"  distribution.image--imageName,serviceType
namespace Nglib.VENDORS.OVH.DISTRIBUTIONIMAGE {
	
	
	/// <summary>
	/// Information about installed package for a given image
	/// </summary>
	public class Distributionimage {
		
		private string Name_bfield;
		
		private string[] Packages_bfield;
		
		private Distributionimageproperties Properties_bfield;
		
		private Distributionimageservice Service_bfield;
		
		/// <summary>
		/// The image name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;The image name&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("name")]
		public string Name {
			get {
				return this.Name_bfield;
			}
			set {
				this.Name_bfield = value;
			}
		}
		
		/// <summary>
		/// Packages informations
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;distribution.image.package[]&quot;,&quot;Description&quot;:&quot;Packages informations&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("packages")]
		public string[] Packages {
			get {
				return this.Packages_bfield;
			}
			set {
				this.Packages_bfield = value;
			}
		}
		
		/// <summary>
		/// Image properties
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;distribution.image.properties&quot;,&quot;Description&quot;:&quot;Image properties&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("properties")]
		public Distributionimageproperties Properties {
			get {
				return this.Properties_bfield;
			}
			set {
				this.Properties_bfield = value;
			}
		}
		
		/// <summary>
		/// The service type name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;distribution.image.service&quot;,&quot;Description&quot;:&quot;The service type name&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("service")]
		public Distributionimageservice Service {
			get {
				return this.Service_bfield;
			}
			set {
				this.Service_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// An image package description
	/// </summary>
	public class Distributionimagepackage {
		
		private string Alias_bfield;
		
		private string Name_bfield;
		
		private string Version_bfield;
		
		/// <summary>
		/// Package alias
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Package alias&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("alias")]
		public string Alias {
			get {
				return this.Alias_bfield;
			}
			set {
				this.Alias_bfield = value;
			}
		}
		
		/// <summary>
		/// Package name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Package name&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("name")]
		public string Name {
			get {
				return this.Name_bfield;
			}
			set {
				this.Name_bfield = value;
			}
		}
		
		/// <summary>
		/// Package version
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Package version&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("version")]
		public string Version {
			get {
				return this.Version_bfield;
			}
			set {
				this.Version_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Description not available
	/// </summary>
	public class Distributionimageproperties {
		
		private Distributionimagepropertiescategory Category_bfield;
		
		/// <summary>
		/// The image category
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;distribution.image.properties.category&quot;,&quot;Description&quot;:&quot;The image category&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("category")]
		public Distributionimagepropertiescategory Category {
			get {
				return this.Category_bfield;
			}
			set {
				this.Category_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Description not available
	/// </summary>
	public class Distributionimagepropertiescategory {
	}
	
	/// <summary>
	/// Description not available
	/// </summary>
	public class Distributionimageservice {
	}
}
