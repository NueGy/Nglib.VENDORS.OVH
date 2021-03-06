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


// [GET] "/hosting/reseller"  string[]--
//[GET] "/hosting/reseller/{serviceName}"  hosting.reseller.product--serviceName
//[POST] "/hosting/reseller/{serviceName}/changeContact"  long[]--contactAdmin,contactBilling,contactTech,serviceName
//[POST] "/hosting/reseller/{serviceName}/email"  string--email,serviceName
//[POST] "/hosting/reseller/{serviceName}/language"  string--language,serviceName
//[POST] "/hosting/reseller/{serviceName}/reboot"  string--hard,serviceName
//[POST] "/hosting/reseller/{serviceName}/reinstall"  string--serviceName
//[GET] "/hosting/reseller/{serviceName}/resetPasswordUrl"  string--serviceName
//[POST] "/hosting/reseller/{serviceName}/reverse"  string--reverse,serviceName
//[GET] "/hosting/reseller/{serviceName}/serviceInfos"  services.Service--serviceName
//[PUT] "/hosting/reseller/{serviceName}/serviceInfos"  void--,serviceName
//[GET] "/hosting/reseller/{serviceName}/snapshot"  reseller.snapshot[]--serviceName
//[POST] "/hosting/reseller/{serviceName}/snapshot"  string--serviceName
//[GET] "/hosting/reseller/{serviceName}/snapshot/{snapshotId}"  reseller.snapshot--serviceName,snapshotId
//[POST] "/hosting/reseller/{serviceName}/snapshot/{snapshotId}/restore"  string--serviceName,snapshotId
//[GET] "/hosting/reseller/{serviceName}/task"  reseller.task[]--serviceName
//[GET] "/hosting/reseller/{serviceName}/task/{taskId}"  reseller.task--serviceName,taskId
namespace Nglib.VENDORS.OVH.HOSTINGRESELLER {
	
	
	/// <summary>
	/// Reseller type
	/// </summary>
	public enum HostingresellerresellerTypeEnum {
		
		[EnumMember(Value="TYPE1")]
		TYPE1,
		
		[EnumMember(Value="TYPE2")]
		TYPE2,
		
		[EnumMember(Value="TYPE3")]
		TYPE3,
		
		[EnumMember(Value="TYPE4")]
		TYPE4,
		
		[EnumMember(Value="TYPE5")]
		TYPE5,
	}
	
	/// <summary>
	/// Possible values for language type
	/// </summary>
	public enum ResellerpleskLanguageTypeEnum {
		
		[EnumMember(Value="ar")]
		Ar,
		
		[EnumMember(Value="zh-CN")]
		Zh_CN,
		
		[EnumMember(Value="zh-TW")]
		Zh_TW,
		
		[EnumMember(Value="cs-CZ")]
		Cs_CZ,
		
		[EnumMember(Value="da-DK")]
		Da_DK,
		
		[EnumMember(Value="nl-NL")]
		Nl_NL,
		
		[EnumMember(Value="en-US")]
		En_US,
		
		[EnumMember(Value="fi-FI")]
		Fi_FI,
		
		[EnumMember(Value="fr-FR")]
		Fr_FR,
		
		[EnumMember(Value="de-DE")]
		De_DE,
		
		[EnumMember(Value="el-GR")]
		El_GR,
		
		[EnumMember(Value="he-IL")]
		He_IL,
		
		[EnumMember(Value="hu-HU")]
		Hu_HU,
		
		[EnumMember(Value="id-ID")]
		Id_ID,
		
		[EnumMember(Value="it-IT")]
		It_IT,
		
		[EnumMember(Value="ja-JP")]
		Ja_JP,
		
		[EnumMember(Value="ko-KR")]
		Ko_KR,
		
		[EnumMember(Value="ms-MY")]
		Ms_MY,
		
		[EnumMember(Value="nb-NO")]
		Nb_NO,
		
		[EnumMember(Value="pl-PL")]
		Pl_PL,
		
		[EnumMember(Value="pt-BR")]
		Pt_BR,
		
		[EnumMember(Value="pt-PT")]
		Pt_PT,
		
		[EnumMember(Value="ro-RO")]
		Ro_RO,
		
		[EnumMember(Value="ru-RU")]
		Ru_RU,
		
		[EnumMember(Value="es-ES")]
		Es_ES,
		
		[EnumMember(Value="sv-SE")]
		Sv_SE,
		
		[EnumMember(Value="tl-PH")]
		Tl_PH,
		
		[EnumMember(Value="th-TH")]
		Th_TH,
		
		[EnumMember(Value="tr-TR")]
		Tr_TR,
		
		[EnumMember(Value="uk-UA")]
		Uk_UA,
		
		[EnumMember(Value="vi-VN")]
		Vi_VN,
	}
	
	/// <summary>
	/// Possible values for snapshot type
	/// </summary>
	public enum ResellersnapshotTypeEnum {
		
		[EnumMember(Value="automatic")]
		Automatic,
		
		[EnumMember(Value="manual")]
		Manual,
	}
	
	/// <summary>
	/// Possible values for task status
	/// </summary>
	public enum ResellertaskTypeEnum {
		
		[EnumMember(Value="done")]
		Done,
		
		[EnumMember(Value="error")]
		Error,
		
		[EnumMember(Value="doing")]
		Doing,
		
		[EnumMember(Value="todo")]
		Todo,
		
		[EnumMember(Value="unknown")]
		Unknown,
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
	/// Plesk instance meta details
	/// </summary>
	public class HostingresellermetaType {
		
		private string Email_bfield;
		
		private string Region_bfield;
		
		/// <summary>
		/// Customer email
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Customer email&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("email")]
		public string Email {
			get {
				return this.Email_bfield;
			}
			set {
				this.Email_bfield = value;
			}
		}
		
		/// <summary>
		/// Region hosting the cloud instance
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Region hosting the cloud instance&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("region")]
		public string Region {
			get {
				return this.Region_bfield;
			}
			set {
				this.Region_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Reseller
	/// </summary>
	public class Hostingresellerproduct {
		
		private string Action_bfield;
		
		private string Ip_bfield;
		
		private HostingresellermetaType Meta_bfield;
		
		private System.Nullable<double> Progress_bfield;
		
		private string Status_bfield;
		
		private string Type_bfield;
		
		private HostingresellerproductType TypeDetail_bfield;
		
		private string Url_bfield;
		
		/// <summary>
		/// Current action done on the instance
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Current action done on the instance&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("action")]
		public string Action {
			get {
				return this.Action_bfield;
			}
			set {
				this.Action_bfield = value;
			}
		}
		
		/// <summary>
		/// Ip address of the Plesk instance
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;ip&quot;,&quot;Description&quot;:&quot;Ip address of the Plesk instance&quot;,&quot;Readonly&quot;:true}
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
		/// Additional information about the plesk
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;hosting.reseller.metaType&quot;,&quot;Description&quot;:&quot;Additional information about the plesk&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("meta")]
		public HostingresellermetaType Meta {
			get {
				return this.Meta_bfield;
			}
			set {
				this.Meta_bfield = value;
			}
		}
		
		/// <summary>
		/// Progression of an action on the instance if any
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;double&quot;,&quot;Description&quot;:&quot;Progression of an action on the instance if any&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("progress")]
		public System.Nullable<double> Progress {
			get {
				return this.Progress_bfield;
			}
			set {
				this.Progress_bfield = value;
			}
		}
		
		/// <summary>
		/// Status of the instance
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Status of the instance&quot;,&quot;Readonly&quot;:true}
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
		/// Reseller flavor
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;hosting.reseller.resellerTypeEnum&quot;,&quot;Description&quot;:&quot;Reseller flavor&quot;,&quot;Readonly&quot;:true}
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
		
		/// <summary>
		/// Details about the plesk type
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;hosting.reseller.productType&quot;,&quot;Description&quot;:&quot;Details about the plesk type&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("typeDetail")]
		public HostingresellerproductType TypeDetail {
			get {
				return this.TypeDetail_bfield;
			}
			set {
				this.TypeDetail_bfield = value;
			}
		}
		
		/// <summary>
		/// Plesk server address
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Plesk server address&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("url")]
		public string Url {
			get {
				return this.Url_bfield;
			}
			set {
				this.Url_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Plesk instance type details
	/// </summary>
	public class HostingresellerproductType {
		
		private long Consumers_bfield;
		
		private string Cpu_bfield;
		
		private long Databases_bfield;
		
		private long DiskSize_bfield;
		
		private long EmailAccounts_bfield;
		
		private long Ram_bfield;
		
		private string Type_bfield;
		
		private long VCores_bfield;
		
		private long Websites_bfield;
		
		/// <summary>
		/// Number of allowed customers
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Number of allowed customers&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("consumers")]
		public long Consumers {
			get {
				return this.Consumers_bfield;
			}
			set {
				this.Consumers_bfield = value;
			}
		}
		
		/// <summary>
		/// Instance's cpu
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Instance's cpu&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("cpu")]
		public string Cpu {
			get {
				return this.Cpu_bfield;
			}
			set {
				this.Cpu_bfield = value;
			}
		}
		
		/// <summary>
		/// Number of allowed databases
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Number of allowed databases&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("databases")]
		public long Databases {
			get {
				return this.Databases_bfield;
			}
			set {
				this.Databases_bfield = value;
			}
		}
		
		/// <summary>
		/// Disk size of the instance (in GB)
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Disk size of the instance (in GB)&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("diskSize")]
		public long DiskSize {
			get {
				return this.DiskSize_bfield;
			}
			set {
				this.DiskSize_bfield = value;
			}
		}
		
		/// <summary>
		/// Number of allowed email accounts
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Number of allowed email accounts&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("emailAccounts")]
		public long EmailAccounts {
			get {
				return this.EmailAccounts_bfield;
			}
			set {
				this.EmailAccounts_bfield = value;
			}
		}
		
		/// <summary>
		/// Instance's ram (in GB)
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Instance's ram (in GB)&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("ram")]
		public long Ram {
			get {
				return this.Ram_bfield;
			}
			set {
				this.Ram_bfield = value;
			}
		}
		
		/// <summary>
		/// Type name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Type name&quot;,&quot;Readonly&quot;:false}
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
		
		/// <summary>
		/// Number of vCore
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Number of vCore&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("vCores")]
		public long VCores {
			get {
				return this.VCores_bfield;
			}
			set {
				this.VCores_bfield = value;
			}
		}
		
		/// <summary>
		/// Number of allowed websites
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Number of allowed websites&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("websites")]
		public long Websites {
			get {
				return this.Websites_bfield;
			}
			set {
				this.Websites_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Reseller snapshot
	/// </summary>
	public class Resellersnapshot {
		
		private System.DateTime CreationDate_bfield;
		
		private string Id_bfield;
		
		private string SnashotName_bfield;
		
		private string Type_bfield;
		
		/// <summary>
		/// Snapshot creation date
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Snapshot creation date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("creationDate")]
		public System.DateTime CreationDate {
			get {
				return this.CreationDate_bfield;
			}
			set {
				this.CreationDate_bfield = value;
			}
		}
		
		/// <summary>
		/// Snapshot id
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Snapshot id&quot;,&quot;Readonly&quot;:true}
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
		/// Snapshot name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Snapshot name&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("snashotName")]
		public string SnashotName {
			get {
				return this.SnashotName_bfield;
			}
			set {
				this.SnashotName_bfield = value;
			}
		}
		
		/// <summary>
		/// Snapshot type
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;reseller.snapshotTypeEnum&quot;,&quot;Description&quot;:&quot;Snapshot type&quot;,&quot;Readonly&quot;:true}
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
	/// Reseller task
	/// </summary>
	public class Resellertask {
		
		private string CurrentStep_bfield;
		
		private System.Nullable<System.DateTime> ExpectedDoneDate_bfield;
		
		private string Id_bfield;
		
		private System.Nullable<System.DateTime> LastUpdateDate_bfield;
		
		private string ProductDomain_bfield;
		
		private long Progress_bfield;
		
		private string TaskName_bfield;
		
		private string TaskStatus_bfield;
		
		/// <summary>
		/// Task current step
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Task current step&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("currentStep")]
		public string CurrentStep {
			get {
				return this.CurrentStep_bfield;
			}
			set {
				this.CurrentStep_bfield = value;
			}
		}
		
		/// <summary>
		/// Task expected done date
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Task expected done date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("expectedDoneDate")]
		public System.Nullable<System.DateTime> ExpectedDoneDate {
			get {
				return this.ExpectedDoneDate_bfield;
			}
			set {
				this.ExpectedDoneDate_bfield = value;
			}
		}
		
		/// <summary>
		/// Task id
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Task id&quot;,&quot;Readonly&quot;:true}
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
		/// Task last update date
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Task last update date&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("lastUpdateDate")]
		public System.Nullable<System.DateTime> LastUpdateDate {
			get {
				return this.LastUpdateDate_bfield;
			}
			set {
				this.LastUpdateDate_bfield = value;
			}
		}
		
		/// <summary>
		/// Linked product
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Linked product&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("productDomain")]
		public string ProductDomain {
			get {
				return this.ProductDomain_bfield;
			}
			set {
				this.ProductDomain_bfield = value;
			}
		}
		
		/// <summary>
		/// Task percentage progression
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;long&quot;,&quot;Description&quot;:&quot;Task percentage progression&quot;,&quot;Readonly&quot;:true}
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
		/// Task name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Task name&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("taskName")]
		public string TaskName {
			get {
				return this.TaskName_bfield;
			}
			set {
				this.TaskName_bfield = value;
			}
		}
		
		/// <summary>
		/// Task status
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;reseller.taskTypeEnum&quot;,&quot;Description&quot;:&quot;Task status&quot;,&quot;Readonly&quot;:true}
		/// </summary>
		[JsonProperty("taskStatus")]
		public string TaskStatus {
			get {
				return this.TaskStatus_bfield;
			}
			set {
				this.TaskStatus_bfield = value;
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
