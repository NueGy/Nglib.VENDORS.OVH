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


// [GET] "/metrics"  string[]--
//[GET] "/metrics/{serviceName}"  metrics.api.Service--serviceName
//[PUT] "/metrics/{serviceName}"  metrics.api.Service--,serviceName
//[POST] "/metrics/{serviceName}/changeContact"  long[]--contactAdmin,contactBilling,contactTech,serviceName
//[POST] "/metrics/{serviceName}/confirmTermination"  string--commentary,futureUse,reason,serviceName,token
//[GET] "/metrics/{serviceName}/consumption"  metrics.api.Consumption--duration,serviceName
//[POST] "/metrics/{serviceName}/lookup/token"  string[]--,serviceName
//[PUT] "/metrics/{serviceName}/quota"  string--,serviceName
//[GET] "/metrics/{serviceName}/serviceInfos"  services.Service--serviceName
//[PUT] "/metrics/{serviceName}/serviceInfos"  void--,serviceName
//[POST] "/metrics/{serviceName}/terminate"  string--serviceName
//[GET] "/metrics/{serviceName}/token"  string[]--serviceName
//[POST] "/metrics/{serviceName}/token"  metrics.api.Token--,serviceName
//[DELETE] "/metrics/{serviceName}/token/{tokenId}"  void--serviceName,tokenId
//[GET] "/metrics/{serviceName}/token/{tokenId}"  metrics.api.Token--serviceName,tokenId
//[PUT] "/metrics/{serviceName}/token/{tokenId}"  metrics.api.Token--,serviceName,tokenId
namespace Nglib.VENDORS.OVH.METRICS {
	
	
	/// <summary>
	/// Type of the service
	/// </summary>
	public enum MetricsapiOfferTypeEnum {
		
		[EnumMember(Value="cloud")]
		Cloud,
		
		[EnumMember(Value="live")]
		Live,
	}
	
	/// <summary>
	/// Metrics service token permissions
	/// </summary>
	public enum MetricsapiPermissionEnum {
		
		[EnumMember(Value="read")]
		Read,
		
		[EnumMember(Value="write")]
		Write,
	}
	
	/// <summary>
	/// Status of of the service
	/// </summary>
	public enum MetricsapiServiceStatusEnum {
		
		[EnumMember(Value="new")]
		New,
		
		[EnumMember(Value="alive")]
		Alive,
		
		[EnumMember(Value="disabled")]
		Disabled,
		
		[EnumMember(Value="dead")]
		Dead,
	}
	
	/// <summary>
	/// Detailed renewal type of a service
	/// </summary>
	public enum ServiceRenewalTypeEnum {
		
		[EnumMember(Value="automaticForcedProduct")]
		AutomaticForcedProduct,
		
		[EnumMember(Value="automaticV2012")]
		AutomaticV2012,
		
		[EnumMember(Value="automaticV2014")]
		AutomaticV2014,
		
		[EnumMember(Value="automaticV2016")]
		AutomaticV2016,
		
		[EnumMember(Value="manual")]
		Manual,
		
		[EnumMember(Value="oneShot")]
		OneShot,
		
		[EnumMember(Value="option")]
		Option,
	}
	
	public enum ServiceStateEnum {
		
		[EnumMember(Value="expired")]
		Expired,
		
		[EnumMember(Value="inCreation")]
		InCreation,
		
		[EnumMember(Value="ok")]
		Ok,
		
		[EnumMember(Value="pendingDebt")]
		PendingDebt,
		
		[EnumMember(Value="unPaid")]
		UnPaid,
	}
	
	/// <summary>
	/// All future uses you can provide for a service termination
	/// </summary>
	public enum ServiceTerminationFutureUseEnum {
		
		[EnumMember(Value="NOT_REPLACING_SERVICE")]
		NOT_REPLACING_SERVICE,
		
		[EnumMember(Value="OTHER")]
		OTHER,
		
		[EnumMember(Value="SUBSCRIBE_AN_OTHER_SERVICE")]
		SUBSCRIBE_AN_OTHER_SERVICE,
		
		[EnumMember(Value="SUBSCRIBE_OTHER_KIND_OF_SERVICE_WITH_COMPETITOR")]
		SUBSCRIBE_OTHER_KIND_OF_SERVICE_WITH_COMPETITOR,
		
		[EnumMember(Value="SUBSCRIBE_SIMILAR_SERVICE_WITH_COMPETITOR")]
		SUBSCRIBE_SIMILAR_SERVICE_WITH_COMPETITOR,
	}
	
	/// <summary>
	/// All reasons you can provide for a service termination
	/// </summary>
	public enum ServiceTerminationReasonEnum {
		
		[EnumMember(Value="FEATURES_DONT_SUIT_ME")]
		FEATURES_DONT_SUIT_ME,
		
		[EnumMember(Value="LACK_OF_PERFORMANCES")]
		LACK_OF_PERFORMANCES,
		
		[EnumMember(Value="MIGRATED_TO_ANOTHER_OVH_PRODUCT")]
		MIGRATED_TO_ANOTHER_OVH_PRODUCT,
		
		[EnumMember(Value="MIGRATED_TO_COMPETITOR")]
		MIGRATED_TO_COMPETITOR,
		
		[EnumMember(Value="NOT_ENOUGH_RECOGNITION")]
		NOT_ENOUGH_RECOGNITION,
		
		[EnumMember(Value="NOT_NEEDED_ANYMORE")]
		NOT_NEEDED_ANYMORE,
		
		[EnumMember(Value="NOT_RELIABLE")]
		NOT_RELIABLE,
		
		[EnumMember(Value="NO_ANSWER")]
		NO_ANSWER,
		
		[EnumMember(Value="OTHER")]
		OTHER,
		
		[EnumMember(Value="PRODUCT_DIMENSION_DONT_SUIT_ME")]
		PRODUCT_DIMENSION_DONT_SUIT_ME,
		
		[EnumMember(Value="PRODUCT_TOOLS_DONT_SUIT_ME")]
		PRODUCT_TOOLS_DONT_SUIT_ME,
		
		[EnumMember(Value="TOO_EXPENSIVE")]
		TOO_EXPENSIVE,
		
		[EnumMember(Value="TOO_HARD_TO_USE")]
		TOO_HARD_TO_USE,
		
		[EnumMember(Value="UNSATIFIED_BY_CUSTOMER_SUPPORT")]
		UNSATIFIED_BY_CUSTOMER_SUPPORT,
	}
	
	/// <summary>
	/// Missing description
	/// </summary>
	public class MetricsLookupTokenCreation {
		
		private string AccessToken_bfield;
		
		/// <summary>
		/// access token
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;access token&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("accessToken")]
		public string AccessToken {
			get {
				return this.AccessToken_bfield;
			}
			set {
				this.AccessToken_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Missing description
	/// </summary>
	public class MetricsQuotaUpdate {
		
		private long Quota_bfield;
		
		/// <summary>
		/// New value for overquota
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;New value for overquota&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("quota")]
		public long Quota {
			get {
				return this.Quota_bfield;
			}
			set {
				this.Quota_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Missing description
	/// </summary>
	public class MetricsTokenCreation {
		
		private string Description_bfield;
		
		private string[] Labels_bfield;
		
		private string Permission_bfield;
		
		/// <summary>
		/// Description for the new token
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Description for the new token&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("description")]
		public string Description {
			get {
				return this.Description_bfield;
			}
			set {
				this.Description_bfield = value;
			}
		}
		
		/// <summary>
		/// Labels for the new token
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;metrics.api.Label[]&quot;,&quot;Description&quot;:&quot;Labels for the new token&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("labels")]
		public string[] Labels {
			get {
				return this.Labels_bfield;
			}
			set {
				this.Labels_bfield = value;
			}
		}
		
		/// <summary>
		/// Type of the new token. Read or Write
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.PermissionEnum&quot;,&quot;Description&quot;:&quot;Type of the new token. Read or Write&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("permission")]
		public string Permission {
			get {
				return this.Permission_bfield;
			}
			set {
				this.Permission_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Missing description
	/// </summary>
	public class MetricsTokenUpdate {
		
		private string Description_bfield;
		
		/// <summary>
		/// New description for your token
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;New description for your token&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("description")]
		public string Description {
			get {
				return this.Description_bfield;
			}
			set {
				this.Description_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Missing description
	/// </summary>
	public class MetricsUpdate {
		
		private string Description_bfield;
		
		/// <summary>
		/// New description for your service
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;New description for your service&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("description")]
		public string Description {
			get {
				return this.Description_bfield;
			}
			set {
				this.Description_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Structure holding the consumption
	/// </summary>
	public class MetricsapiConsumption {
		
		private long Ddp_bfield;
		
		private long Mads_bfield;
		
		/// <summary>
		/// Current Daily data points
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Current Daily data points&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("ddp")]
		public long Ddp {
			get {
				return this.Ddp_bfield;
			}
			set {
				this.Ddp_bfield = value;
			}
		}
		
		/// <summary>
		/// Current monthly active data streams
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Current monthly active data streams&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("mads")]
		public long Mads {
			get {
				return this.Mads_bfield;
			}
			set {
				this.Mads_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Structure holding the elements about a label
	/// </summary>
	public class MetricsapiLabel {
		
		private string Key_bfield;
		
		private string Value_bfield;
		
		/// <summary>
		/// Label key
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Label key&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("key")]
		public string Key {
			get {
				return this.Key_bfield;
			}
			set {
				this.Key_bfield = value;
			}
		}
		
		/// <summary>
		/// Label value
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Label value&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("value")]
		public string Value {
			get {
				return this.Value_bfield;
			}
			set {
				this.Value_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Structure holding the options for a service
	/// </summary>
	public class MetricsapiOption {
		
		private long Ddp_bfield;
		
		private System.DateTime LastModification_bfield;
		
		private long Mads_bfield;
		
		/// <summary>
		/// Daily data points
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Daily data points&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("ddp")]
		public long Ddp {
			get {
				return this.Ddp_bfield;
			}
			set {
				this.Ddp_bfield = value;
			}
		}
		
		/// <summary>
		/// Time of last modification
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Time of last modification&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("lastModification")]
		public System.DateTime LastModification {
			get {
				return this.LastModification_bfield;
			}
			set {
				this.LastModification_bfield = value;
			}
		}
		
		/// <summary>
		/// Monthly active device streams
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Monthly active device streams&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("mads")]
		public long Mads {
			get {
				return this.Mads_bfield;
			}
			set {
				this.Mads_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Structure holding the elements about a region
	/// </summary>
	public class MetricsapiRegion {
		
		private string Description_bfield;
		
		private string Name_bfield;
		
		/// <summary>
		/// Description of a region
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Description of a region&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("description")]
		public string Description {
			get {
				return this.Description_bfield;
			}
			set {
				this.Description_bfield = value;
			}
		}
		
		/// <summary>
		/// Name of a region
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Name of a region&quot;,&quot;Readonly&quot;:true}
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
	}
	
	/// <summary>
	/// Structure holding the elements about a service
	/// </summary>
	public class MetricsapiService {
		
		private string Description_bfield;
		
		private string Name_bfield;
		
		private string Offer_bfield;
		
		private MetricsapiOption Quota_bfield;
		
		private MetricsapiRegion Region_bfield;
		
		private bool ShouldUpgrade_bfield;
		
		private string Status_bfield;
		
		private string Type_bfield;
		
		/// <summary>
		/// Description of a service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Description of a service&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("description")]
		public string Description {
			get {
				return this.Description_bfield;
			}
			set {
				this.Description_bfield = value;
			}
		}
		
		/// <summary>
		/// Name of a service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Name of a service&quot;,&quot;Readonly&quot;:true}
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
		/// Offer used for the service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Offer used for the service&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("offer")]
		public string Offer {
			get {
				return this.Offer_bfield;
			}
			set {
				this.Offer_bfield = value;
			}
		}
		
		/// <summary>
		/// Quota used for the service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.Option&quot;,&quot;Description&quot;:&quot;Quota used for the service&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("quota")]
		public MetricsapiOption Quota {
			get {
				return this.Quota_bfield;
			}
			set {
				this.Quota_bfield = value;
			}
		}
		
		/// <summary>
		/// Region holding the service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.Region&quot;,&quot;Description&quot;:&quot;Region holding the service&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("region")]
		public MetricsapiRegion Region {
			get {
				return this.Region_bfield;
			}
			set {
				this.Region_bfield = value;
			}
		}
		
		/// <summary>
		/// Indicator if the service should be upgraded based on current quota and offer
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;Indicator if the service should be upgraded based on current quota and offer&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("shouldUpgrade")]
		public bool ShouldUpgrade {
			get {
				return this.ShouldUpgrade_bfield;
			}
			set {
				this.ShouldUpgrade_bfield = value;
			}
		}
		
		/// <summary>
		/// Status of a service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.ServiceStatusEnum&quot;,&quot;Description&quot;:&quot;Status of a service&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("status")]
		public string Status {
			get {
				return this.Status_bfield;
			}
			set {
				this.Status_bfield = value;
			}
		}
		
		/// <summary>
		/// Type of the service: cloud or live
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.OfferTypeEnum&quot;,&quot;Description&quot;:&quot;Type of the service: cloud or live&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("type")]
		public string Type {
			get {
				return this.Type_bfield;
			}
			set {
				this.Type_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Structure holding the elements about a token
	/// </summary>
	public class MetricsapiToken {
		
		private string Access_bfield;
		
		private System.DateTime CreatedAt_bfield;
		
		private string Description_bfield;
		
		private System.DateTime ExpiryAt_bfield;
		
		private string Id_bfield;
		
		private bool IsRevoked_bfield;
		
		private string[] Labels_bfield;
		
		private string Permission_bfield;
		
		/// <summary>
		/// The actual access token
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;password&quot;,&quot;Description&quot;:&quot;The actual access token&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("access")]
		public string Access {
			get {
				return this.Access_bfield;
			}
			set {
				this.Access_bfield = value;
			}
		}
		
		/// <summary>
		/// Token creation date
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Token creation date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("createdAt")]
		public System.DateTime CreatedAt {
			get {
				return this.CreatedAt_bfield;
			}
			set {
				this.CreatedAt_bfield = value;
			}
		}
		
		/// <summary>
		/// Description of the token
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Description of the token&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("description")]
		public string Description {
			get {
				return this.Description_bfield;
			}
			set {
				this.Description_bfield = value;
			}
		}
		
		/// <summary>
		/// Token expiration date
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Token expiration date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("expiryAt")]
		public System.DateTime ExpiryAt {
			get {
				return this.ExpiryAt_bfield;
			}
			set {
				this.ExpiryAt_bfield = value;
			}
		}
		
		/// <summary>
		/// Id of the token
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Id of the token&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("id")]
		public string Id {
			get {
				return this.Id_bfield;
			}
			set {
				this.Id_bfield = value;
			}
		}
		
		/// <summary>
		/// Is your token revoked?
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;Is your token revoked?&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("isRevoked")]
		public bool IsRevoked {
			get {
				return this.IsRevoked_bfield;
			}
			set {
				this.IsRevoked_bfield = value;
			}
		}
		
		/// <summary>
		/// Labels for the token if set
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.Label[]&quot;,&quot;Description&quot;:&quot;Labels for the token if set&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("labels")]
		public string[] Labels {
			get {
				return this.Labels_bfield;
			}
			set {
				this.Labels_bfield = value;
			}
		}
		
		/// <summary>
		/// Token permission: read or write
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;metrics.api.PermissionEnum&quot;,&quot;Description&quot;:&quot;Token permission: read or write&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("permission")]
		public string Permission {
			get {
				return this.Permission_bfield;
			}
			set {
				this.Permission_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Map a possible renew for a specific service
	/// </summary>
	public class ServiceRenewType {
		
		private bool Automatic_bfield;
		
		private bool DeleteAtExpiration_bfield;
		
		private bool Forced_bfield;
		
		private System.Nullable<bool> ManualPayment_bfield;
		
		private System.Nullable<long> Period_bfield;
		
		/// <summary>
		/// The service is automatically renewed
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;The service is automatically renewed&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("automatic")]
		public bool Automatic {
			get {
				return this.Automatic_bfield;
			}
			set {
				this.Automatic_bfield = value;
			}
		}
		
		/// <summary>
		/// The service will be deleted at expiration
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;The service will be deleted at expiration&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("deleteAtExpiration")]
		public bool DeleteAtExpiration {
			get {
				return this.DeleteAtExpiration_bfield;
			}
			set {
				this.DeleteAtExpiration_bfield = value;
			}
		}
		
		/// <summary>
		/// The service forced to be renewed
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;The service forced to be renewed&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("forced")]
		public bool Forced {
			get {
				return this.Forced_bfield;
			}
			set {
				this.Forced_bfield = value;
			}
		}
		
		/// <summary>
		/// The service needs to be manually renewed and paid
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;The service needs to be manually renewed and paid&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("manualPayment")]
		public System.Nullable<bool> ManualPayment {
			get {
				return this.ManualPayment_bfield;
			}
			set {
				this.ManualPayment_bfield = value;
			}
		}
		
		/// <summary>
		/// period of renew in month
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;period of renew in month&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("period")]
		public System.Nullable<long> Period {
			get {
				return this.Period_bfield;
			}
			set {
				this.Period_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Details about a Service
	/// </summary>
	public class ServicesService {
		
		private bool CanDeleteAtExpiration_bfield;
		
		private string ContactAdmin_bfield;
		
		private string ContactBilling_bfield;
		
		private string ContactTech_bfield;
		
		private string Creation_bfield;
		
		private string Domain_bfield;
		
		private string EngagedUpTo_bfield;
		
		private string Expiration_bfield;
		
		private long[] PossibleRenewPeriod_bfield;
		
		private ServiceRenewType Renew_bfield;
		
		private string RenewalType_bfield;
		
		private long ServiceId_bfield;
		
		private string Status_bfield;
		
		/// <summary>
		/// Indicates that the service can be set up to be deleted at expiration
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;boolean&quot;,&quot;Description&quot;:&quot;Indicates that the service can be set up to be deleted at expiration&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("canDeleteAtExpiration")]
		public bool CanDeleteAtExpiration {
			get {
				return this.CanDeleteAtExpiration_bfield;
			}
			set {
				this.CanDeleteAtExpiration_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("contactAdmin")]
		public string ContactAdmin {
			get {
				return this.ContactAdmin_bfield;
			}
			set {
				this.ContactAdmin_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("contactBilling")]
		public string ContactBilling {
			get {
				return this.ContactBilling_bfield;
			}
			set {
				this.ContactBilling_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("contactTech")]
		public string ContactTech {
			get {
				return this.ContactTech_bfield;
			}
			set {
				this.ContactTech_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;date&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("creation")]
		public string Creation {
			get {
				return this.Creation_bfield;
			}
			set {
				this.Creation_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("domain")]
		public string Domain {
			get {
				return this.Domain_bfield;
			}
			set {
				this.Domain_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;date&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("engagedUpTo")]
		public string EngagedUpTo {
			get {
				return this.EngagedUpTo_bfield;
			}
			set {
				this.EngagedUpTo_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;date&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("expiration")]
		public string Expiration {
			get {
				return this.Expiration_bfield;
			}
			set {
				this.Expiration_bfield = value;
			}
		}
		
		/// <summary>
		/// All the possible renew period of your service in month
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;long[]&quot;,&quot;Description&quot;:&quot;All the possible renew period of your service in month&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("possibleRenewPeriod")]
		public long[] PossibleRenewPeriod {
			get {
				return this.PossibleRenewPeriod_bfield;
			}
			set {
				this.PossibleRenewPeriod_bfield = value;
			}
		}
		
		/// <summary>
		/// Way of handling the renew
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;service.RenewType&quot;,&quot;Description&quot;:&quot;Way of handling the renew&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("renew")]
		public ServiceRenewType Renew {
			get {
				return this.Renew_bfield;
			}
			set {
				this.Renew_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;service.RenewalTypeEnum&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("renewalType")]
		public string RenewalType {
			get {
				return this.RenewalType_bfield;
			}
			set {
				this.RenewalType_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("serviceId")]
		public long ServiceId {
			get {
				return this.ServiceId_bfield;
			}
			set {
				this.ServiceId_bfield = value;
			}
		}
		
		/// <summary>
		/// 
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;service.StateEnum&quot;,&quot;Description&quot;:null,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("status")]
		public string Status {
			get {
				return this.Status_bfield;
			}
			set {
				this.Status_bfield = value;
			}
		}
	}
}
