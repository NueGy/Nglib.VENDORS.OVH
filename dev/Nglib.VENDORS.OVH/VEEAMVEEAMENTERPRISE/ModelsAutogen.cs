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


// [GET] "/veeam/veeamEnterprise"  string[]--
//[GET] "/veeam/veeamEnterprise/{serviceName}"  veeam.veeamEnterprise.Account--serviceName
//[POST] "/veeam/veeamEnterprise/{serviceName}/confirmTermination"  string--commentary,futureUse,reason,serviceName,token
//[POST] "/veeam/veeamEnterprise/{serviceName}/register"  veeam.veeamEnterprise.Task[]--ip,password,port,serviceName,username
//[GET] "/veeam/veeamEnterprise/{serviceName}/serviceInfos"  services.Service--serviceName
//[PUT] "/veeam/veeamEnterprise/{serviceName}/serviceInfos"  void--,serviceName
//[GET] "/veeam/veeamEnterprise/{serviceName}/task"  long[]--name,serviceName,state
//[GET] "/veeam/veeamEnterprise/{serviceName}/task/{taskId}"  veeam.veeamEnterprise.Task--serviceName,taskId
//[POST] "/veeam/veeamEnterprise/{serviceName}/terminate"  string--serviceName
//[POST] "/veeam/veeamEnterprise/{serviceName}/update"  veeam.veeamEnterprise.Task[]--ip,password,port,serviceName,username
namespace Nglib.VENDORS.OVH.VEEAMVEEAMENTERPRISE {
	
	
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
	/// All possible states for a Veeam Enterprise Task
	/// </summary>
	public enum VeeamEnterpriseTaskStateEnum {
		
		[EnumMember(Value="canceled")]
		Canceled,
		
		[EnumMember(Value="doing")]
		Doing,
		
		[EnumMember(Value="done")]
		Done,
		
		[EnumMember(Value="error")]
		Error,
		
		[EnumMember(Value="toCreate")]
		ToCreate,
		
		[EnumMember(Value="todo")]
		Todo,
		
		[EnumMember(Value="unfixed")]
		Unfixed,
		
		[EnumMember(Value="waiting")]
		Waiting,
		
		[EnumMember(Value="waitingForChilds")]
		WaitingForChilds,
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
	/// Veeeam Enterprise offer
	/// </summary>
	public class VeeamveeamEnterpriseAccount {
		
		private string Ip_bfield;
		
		private System.Nullable<long> Port_bfield;
		
		private string ServiceName_bfield;
		
		private string SourceIp_bfield;
		
		/// <summary>
		/// This Backup Server IP
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;ip&quot;,&quot;Description&quot;:&quot;This Backup Server IP&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("ip")]
		public string Ip {
			get {
				return this.Ip_bfield;
			}
			set {
				this.Ip_bfield = value;
			}
		}
		
		/// <summary>
		/// This Backup Server port
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;This Backup Server port&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("port")]
		public System.Nullable<long> Port {
			get {
				return this.Port_bfield;
			}
			set {
				this.Port_bfield = value;
			}
		}
		
		/// <summary>
		/// Your Veeam Enterprise Service name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Your Veeam Enterprise Service name&quot;,&quot;Readonly&quot;:true}
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
		/// OVH Enterprise Manager IP
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;ip&quot;,&quot;Description&quot;:&quot;OVH Enterprise Manager IP&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("sourceIp")]
		public string SourceIp {
			get {
				return this.SourceIp_bfield;
			}
			set {
				this.SourceIp_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Operation with the Enterprise Account
	/// </summary>
	public class VeeamveeamEnterpriseTask {
		
		private System.Nullable<System.DateTime> EndDate_bfield;
		
		private string Name_bfield;
		
		private long Progress_bfield;
		
		private System.Nullable<System.DateTime> StartDate_bfield;
		
		private string State_bfield;
		
		private long TaskId_bfield;
		
		/// <summary>
		/// Task completion date
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Task completion date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("endDate")]
		public System.Nullable<System.DateTime> EndDate {
			get {
				return this.EndDate_bfield;
			}
			set {
				this.EndDate_bfield = value;
			}
		}
		
		/// <summary>
		/// Task name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Task name&quot;,&quot;Readonly&quot;:true}
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
		/// Current progress
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Current progress&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("progress")]
		public long Progress {
			get {
				return this.Progress_bfield;
			}
			set {
				this.Progress_bfield = value;
			}
		}
		
		/// <summary>
		/// Task creation date
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Task creation date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("startDate")]
		public System.Nullable<System.DateTime> StartDate {
			get {
				return this.StartDate_bfield;
			}
			set {
				this.StartDate_bfield = value;
			}
		}
		
		/// <summary>
		/// Current Task state
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;veeamEnterprise.TaskStateEnum&quot;,&quot;Description&quot;:&quot;Current Task state&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("state")]
		public string State {
			get {
				return this.State_bfield;
			}
			set {
				this.State_bfield = value;
			}
		}
		
		/// <summary>
		/// Task id
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Task id&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("taskId")]
		public long TaskId {
			get {
				return this.TaskId_bfield;
			}
			set {
				this.TaskId_bfield = value;
			}
		}
	}
}
