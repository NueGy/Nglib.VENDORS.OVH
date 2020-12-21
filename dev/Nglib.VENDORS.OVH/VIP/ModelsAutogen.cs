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


// [GET] "/vip"  string[]--
//[GET] "/vip/{serviceName}"  vip.SupportVip--serviceName
//[GET] "/vip/{serviceName}/serviceInfos"  services.Service--serviceName
//[PUT] "/vip/{serviceName}/serviceInfos"  void--,serviceName
namespace Nglib.VENDORS.OVH.VIP {
	
	
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
	/// Available universe for VIP service
	/// </summary>
	public enum VipUniverseEnum {
		
		[EnumMember(Value="cloud")]
		Cloud,
		
		[EnumMember(Value="dedicated")]
		Dedicated,
		
		[EnumMember(Value="telecom")]
		Telecom,
		
		[EnumMember(Value="web")]
		Web,
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
	
	/// <summary>
	/// Vip Service
	/// </summary>
	public class VipSupportVip {
		
		private string ServiceName_bfield;
		
		private string[] Universe_bfield;
		
		/// <summary>
		/// Name of the VIP offer
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Name of the VIP offer&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("serviceName")]
		public string ServiceName {
			get {
				return this.ServiceName_bfield;
			}
			set {
				this.ServiceName_bfield = value;
			}
		}
		
		/// <summary>
		/// VIP universes of this service
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;vip.UniverseEnum[]&quot;,&quot;Description&quot;:&quot;VIP universes of this service&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("universe")]
		public string[] Universe {
			get {
				return this.Universe_bfield;
			}
			set {
				this.Universe_bfield = value;
			}
		}
	}
}
