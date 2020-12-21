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


// [POST] "/secret/retrieve"  secret.Secret--id
namespace Nglib.VENDORS.OVH.SECRET {
	
	
	/// <summary>
	/// A secret
	/// </summary>
	public class SecretSecret {
		
		private System.DateTime Expiration_bfield;
		
		private string Secret_bfield;
		
		/// <summary>
		/// Expiration time of the secret
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Expiration time of the secret&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("expiration")]
		public System.DateTime Expiration {
			get {
				return this.Expiration_bfield;
			}
			set {
				this.Expiration_bfield = value;
			}
		}
		
		/// <summary>
		/// The secret
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;password&quot;,&quot;Description&quot;:&quot;The secret&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("secret")]
		public string Secret {
			get {
				return this.Secret_bfield;
			}
			set {
				this.Secret_bfield = value;
			}
		}
	}
}
