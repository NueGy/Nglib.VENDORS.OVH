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


// [POST] "/supply/mondialRelay"  supply.MondialRelayReturn--address,city,country,zipcode
namespace Nglib.VENDORS.OVH.SUPPLYMONDIALRELAY {
	
	
	/// <summary>
	/// ISO country codes
	/// </summary>
	public enum CoreTypesCountryEnum {
		
		[EnumMember(Value="ac")]
		Ac,
		
		[EnumMember(Value="ad")]
		Ad,
		
		[EnumMember(Value="ae")]
		Ae,
		
		[EnumMember(Value="af")]
		Af,
		
		[EnumMember(Value="ag")]
		Ag,
		
		[EnumMember(Value="ai")]
		Ai,
		
		[EnumMember(Value="al")]
		Al,
		
		[EnumMember(Value="am")]
		Am,
		
		[EnumMember(Value="an")]
		An,
		
		[EnumMember(Value="ao")]
		Ao,
		
		[EnumMember(Value="aq")]
		Aq,
		
		[EnumMember(Value="ar")]
		Ar,
		
		[EnumMember(Value="as")]
		As,
		
		[EnumMember(Value="at")]
		At,
		
		[EnumMember(Value="au")]
		Au,
		
		[EnumMember(Value="aw")]
		Aw,
		
		[EnumMember(Value="ax")]
		Ax,
		
		[EnumMember(Value="az")]
		Az,
		
		[EnumMember(Value="ba")]
		Ba,
		
		[EnumMember(Value="bb")]
		Bb,
		
		[EnumMember(Value="bd")]
		Bd,
		
		[EnumMember(Value="be")]
		Be,
		
		[EnumMember(Value="bf")]
		Bf,
		
		[EnumMember(Value="bg")]
		Bg,
		
		[EnumMember(Value="bh")]
		Bh,
		
		[EnumMember(Value="bi")]
		Bi,
		
		[EnumMember(Value="bj")]
		Bj,
		
		[EnumMember(Value="bl")]
		Bl,
		
		[EnumMember(Value="bm")]
		Bm,
		
		[EnumMember(Value="bn")]
		Bn,
		
		[EnumMember(Value="bo")]
		Bo,
		
		[EnumMember(Value="bq")]
		Bq,
		
		[EnumMember(Value="br")]
		Br,
		
		[EnumMember(Value="bs")]
		Bs,
		
		[EnumMember(Value="bt")]
		Bt,
		
		[EnumMember(Value="bv")]
		Bv,
		
		[EnumMember(Value="bw")]
		Bw,
		
		[EnumMember(Value="by")]
		By,
		
		[EnumMember(Value="bz")]
		Bz,
		
		[EnumMember(Value="ca")]
		Ca,
		
		[EnumMember(Value="cc")]
		Cc,
		
		[EnumMember(Value="cd")]
		Cd,
		
		[EnumMember(Value="cf")]
		Cf,
		
		[EnumMember(Value="cg")]
		Cg,
		
		[EnumMember(Value="ch")]
		Ch,
		
		[EnumMember(Value="ci")]
		Ci,
		
		[EnumMember(Value="ck")]
		Ck,
		
		[EnumMember(Value="cl")]
		Cl,
		
		[EnumMember(Value="cm")]
		Cm,
		
		[EnumMember(Value="cn")]
		Cn,
		
		[EnumMember(Value="co")]
		Co,
		
		[EnumMember(Value="cr")]
		Cr,
		
		[EnumMember(Value="cs")]
		Cs,
		
		[EnumMember(Value="cu")]
		Cu,
		
		[EnumMember(Value="cv")]
		Cv,
		
		[EnumMember(Value="cw")]
		Cw,
		
		[EnumMember(Value="cx")]
		Cx,
		
		[EnumMember(Value="cy")]
		Cy,
		
		[EnumMember(Value="cz")]
		Cz,
		
		[EnumMember(Value="de")]
		De,
		
		[EnumMember(Value="dj")]
		Dj,
		
		[EnumMember(Value="dk")]
		Dk,
		
		[EnumMember(Value="dm")]
		Dm,
		
		[EnumMember(Value="do")]
		Do,
		
		[EnumMember(Value="dz")]
		Dz,
		
		[EnumMember(Value="ec")]
		Ec,
		
		[EnumMember(Value="ee")]
		Ee,
		
		[EnumMember(Value="eg")]
		Eg,
		
		[EnumMember(Value="eh")]
		Eh,
		
		[EnumMember(Value="er")]
		Er,
		
		[EnumMember(Value="es")]
		Es,
		
		[EnumMember(Value="et")]
		Et,
		
		[EnumMember(Value="fc")]
		Fc,
		
		[EnumMember(Value="fd")]
		Fd,
		
		[EnumMember(Value="fi")]
		Fi,
		
		[EnumMember(Value="fj")]
		Fj,
		
		[EnumMember(Value="fk")]
		Fk,
		
		[EnumMember(Value="fm")]
		Fm,
		
		[EnumMember(Value="fo")]
		Fo,
		
		[EnumMember(Value="fr")]
		Fr,
		
		[EnumMember(Value="fx")]
		Fx,
		
		[EnumMember(Value="ga")]
		Ga,
		
		[EnumMember(Value="gb")]
		Gb,
		
		[EnumMember(Value="gd")]
		Gd,
		
		[EnumMember(Value="ge")]
		Ge,
		
		[EnumMember(Value="gf")]
		Gf,
		
		[EnumMember(Value="gg")]
		Gg,
		
		[EnumMember(Value="gh")]
		Gh,
		
		[EnumMember(Value="gi")]
		Gi,
		
		[EnumMember(Value="gl")]
		Gl,
		
		[EnumMember(Value="gm")]
		Gm,
		
		[EnumMember(Value="gn")]
		Gn,
		
		[EnumMember(Value="gp")]
		Gp,
		
		[EnumMember(Value="gq")]
		Gq,
		
		[EnumMember(Value="gr")]
		Gr,
		
		[EnumMember(Value="gs")]
		Gs,
		
		[EnumMember(Value="gt")]
		Gt,
		
		[EnumMember(Value="gu")]
		Gu,
		
		[EnumMember(Value="gw")]
		Gw,
		
		[EnumMember(Value="gy")]
		Gy,
		
		[EnumMember(Value="hk")]
		Hk,
		
		[EnumMember(Value="hm")]
		Hm,
		
		[EnumMember(Value="hn")]
		Hn,
		
		[EnumMember(Value="hr")]
		Hr,
		
		[EnumMember(Value="ht")]
		Ht,
		
		[EnumMember(Value="hu")]
		Hu,
		
		[EnumMember(Value="id")]
		Id,
		
		[EnumMember(Value="ie")]
		Ie,
		
		[EnumMember(Value="il")]
		Il,
		
		[EnumMember(Value="im")]
		Im,
		
		[EnumMember(Value="in")]
		In,
		
		[EnumMember(Value="io")]
		Io,
		
		[EnumMember(Value="iq")]
		Iq,
		
		[EnumMember(Value="ir")]
		Ir,
		
		[EnumMember(Value="is")]
		Is,
		
		[EnumMember(Value="it")]
		It,
		
		[EnumMember(Value="je")]
		Je,
		
		[EnumMember(Value="jm")]
		Jm,
		
		[EnumMember(Value="jo")]
		Jo,
		
		[EnumMember(Value="jp")]
		Jp,
		
		[EnumMember(Value="ke")]
		Ke,
		
		[EnumMember(Value="kg")]
		Kg,
		
		[EnumMember(Value="kh")]
		Kh,
		
		[EnumMember(Value="ki")]
		Ki,
		
		[EnumMember(Value="km")]
		Km,
		
		[EnumMember(Value="kn")]
		Kn,
		
		[EnumMember(Value="kp")]
		Kp,
		
		[EnumMember(Value="kr")]
		Kr,
		
		[EnumMember(Value="kw")]
		Kw,
		
		[EnumMember(Value="ky")]
		Ky,
		
		[EnumMember(Value="kz")]
		Kz,
		
		[EnumMember(Value="la")]
		La,
		
		[EnumMember(Value="lb")]
		Lb,
		
		[EnumMember(Value="lc")]
		Lc,
		
		[EnumMember(Value="li")]
		Li,
		
		[EnumMember(Value="lk")]
		Lk,
		
		[EnumMember(Value="lr")]
		Lr,
		
		[EnumMember(Value="ls")]
		Ls,
		
		[EnumMember(Value="lt")]
		Lt,
		
		[EnumMember(Value="lu")]
		Lu,
		
		[EnumMember(Value="lv")]
		Lv,
		
		[EnumMember(Value="ly")]
		Ly,
		
		[EnumMember(Value="ma")]
		Ma,
		
		[EnumMember(Value="mc")]
		Mc,
		
		[EnumMember(Value="md")]
		Md,
		
		[EnumMember(Value="me")]
		Me,
		
		[EnumMember(Value="mf")]
		Mf,
		
		[EnumMember(Value="mg")]
		Mg,
		
		[EnumMember(Value="mh")]
		Mh,
		
		[EnumMember(Value="mk")]
		Mk,
		
		[EnumMember(Value="ml")]
		Ml,
		
		[EnumMember(Value="mm")]
		Mm,
		
		[EnumMember(Value="mn")]
		Mn,
		
		[EnumMember(Value="mo")]
		Mo,
		
		[EnumMember(Value="mp")]
		Mp,
		
		[EnumMember(Value="mq")]
		Mq,
		
		[EnumMember(Value="mr")]
		Mr,
		
		[EnumMember(Value="ms")]
		Ms,
		
		[EnumMember(Value="mt")]
		Mt,
		
		[EnumMember(Value="mu")]
		Mu,
		
		[EnumMember(Value="mv")]
		Mv,
		
		[EnumMember(Value="mw")]
		Mw,
		
		[EnumMember(Value="mx")]
		Mx,
		
		[EnumMember(Value="my")]
		My,
		
		[EnumMember(Value="mz")]
		Mz,
		
		[EnumMember(Value="na")]
		Na,
		
		[EnumMember(Value="nc")]
		Nc,
		
		[EnumMember(Value="ne")]
		Ne,
		
		[EnumMember(Value="nf")]
		Nf,
		
		[EnumMember(Value="ng")]
		Ng,
		
		[EnumMember(Value="ni")]
		Ni,
		
		[EnumMember(Value="nl")]
		Nl,
		
		[EnumMember(Value="no")]
		No,
		
		[EnumMember(Value="np")]
		Np,
		
		[EnumMember(Value="nr")]
		Nr,
		
		[EnumMember(Value="nu")]
		Nu,
		
		[EnumMember(Value="nz")]
		Nz,
		
		[EnumMember(Value="om")]
		Om,
		
		[EnumMember(Value="pa")]
		Pa,
		
		[EnumMember(Value="pe")]
		Pe,
		
		[EnumMember(Value="pf")]
		Pf,
		
		[EnumMember(Value="pg")]
		Pg,
		
		[EnumMember(Value="ph")]
		Ph,
		
		[EnumMember(Value="pk")]
		Pk,
		
		[EnumMember(Value="pl")]
		Pl,
		
		[EnumMember(Value="pm")]
		Pm,
		
		[EnumMember(Value="pn")]
		Pn,
		
		[EnumMember(Value="pr")]
		Pr,
		
		[EnumMember(Value="ps")]
		Ps,
		
		[EnumMember(Value="pt")]
		Pt,
		
		[EnumMember(Value="pw")]
		Pw,
		
		[EnumMember(Value="py")]
		Py,
		
		[EnumMember(Value="qa")]
		Qa,
		
		[EnumMember(Value="qc")]
		Qc,
		
		[EnumMember(Value="re")]
		Re,
		
		[EnumMember(Value="ro")]
		Ro,
		
		[EnumMember(Value="rs")]
		Rs,
		
		[EnumMember(Value="ru")]
		Ru,
		
		[EnumMember(Value="rw")]
		Rw,
		
		[EnumMember(Value="sa")]
		Sa,
		
		[EnumMember(Value="sb")]
		Sb,
		
		[EnumMember(Value="sc")]
		Sc,
		
		[EnumMember(Value="sd")]
		Sd,
		
		[EnumMember(Value="se")]
		Se,
		
		[EnumMember(Value="sg")]
		Sg,
		
		[EnumMember(Value="sh")]
		Sh,
		
		[EnumMember(Value="si")]
		Si,
		
		[EnumMember(Value="sj")]
		Sj,
		
		[EnumMember(Value="sk")]
		Sk,
		
		[EnumMember(Value="sl")]
		Sl,
		
		[EnumMember(Value="sm")]
		Sm,
		
		[EnumMember(Value="sn")]
		Sn,
		
		[EnumMember(Value="so")]
		So,
		
		[EnumMember(Value="sr")]
		Sr,
		
		[EnumMember(Value="ss")]
		Ss,
		
		[EnumMember(Value="st")]
		St,
		
		[EnumMember(Value="sv")]
		Sv,
		
		[EnumMember(Value="sx")]
		Sx,
		
		[EnumMember(Value="sy")]
		Sy,
		
		[EnumMember(Value="sz")]
		Sz,
		
		[EnumMember(Value="tc")]
		Tc,
		
		[EnumMember(Value="td")]
		Td,
		
		[EnumMember(Value="tf")]
		Tf,
		
		[EnumMember(Value="tg")]
		Tg,
		
		[EnumMember(Value="th")]
		Th,
		
		[EnumMember(Value="tj")]
		Tj,
		
		[EnumMember(Value="tk")]
		Tk,
		
		[EnumMember(Value="tl")]
		Tl,
		
		[EnumMember(Value="tm")]
		Tm,
		
		[EnumMember(Value="tn")]
		Tn,
		
		[EnumMember(Value="to")]
		To,
		
		[EnumMember(Value="tp")]
		Tp,
		
		[EnumMember(Value="tr")]
		Tr,
		
		[EnumMember(Value="tt")]
		Tt,
		
		[EnumMember(Value="tv")]
		Tv,
		
		[EnumMember(Value="tw")]
		Tw,
		
		[EnumMember(Value="tz")]
		Tz,
		
		[EnumMember(Value="ua")]
		Ua,
		
		[EnumMember(Value="ug")]
		Ug,
		
		[EnumMember(Value="uk")]
		Uk,
		
		[EnumMember(Value="um")]
		Um,
		
		[EnumMember(Value="us")]
		Us,
		
		[EnumMember(Value="uy")]
		Uy,
		
		[EnumMember(Value="uz")]
		Uz,
		
		[EnumMember(Value="va")]
		Va,
		
		[EnumMember(Value="vc")]
		Vc,
		
		[EnumMember(Value="ve")]
		Ve,
		
		[EnumMember(Value="vg")]
		Vg,
		
		[EnumMember(Value="vi")]
		Vi,
		
		[EnumMember(Value="vn")]
		Vn,
		
		[EnumMember(Value="vu")]
		Vu,
		
		[EnumMember(Value="we")]
		We,
		
		[EnumMember(Value="wf")]
		Wf,
		
		[EnumMember(Value="ws")]
		Ws,
		
		[EnumMember(Value="ye")]
		Ye,
		
		[EnumMember(Value="yt")]
		Yt,
		
		[EnumMember(Value="yu")]
		Yu,
		
		[EnumMember(Value="za")]
		Za,
		
		[EnumMember(Value="zm")]
		Zm,
		
		[EnumMember(Value="zw")]
		Zw,
	}
	
	/// <summary>
	/// Mondial Relay Point Details
	/// </summary>
	public class SupplyMondialRelay {
		
		private string Address_bfield;
		
		private string City_bfield;
		
		private string[] Closing_bfield;
		
		private string Country_bfield;
		
		private System.Nullable<double> Distance_bfield;
		
		private string Id_bfield;
		
		private double Lat_bfield;
		
		private double Lng_bfield;
		
		private string MapUrl_bfield;
		
		private string Name_bfield;
		
		private SupplyMondialRelayOpening Opening_bfield;
		
		private string PictureUrl_bfield;
		
		private string Zipcode_bfield;
		
		/// <summary>
		/// Relay point address
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Relay point address&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("address")]
		public string Address {
			get {
				return this.Address_bfield;
			}
			set {
				this.Address_bfield = value;
			}
		}
		
		/// <summary>
		/// City
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;City&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("city")]
		public string City {
			get {
				return this.City_bfield;
			}
			set {
				this.City_bfield = value;
			}
		}
		
		/// <summary>
		/// Relay point closing dates
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayClosingPeriod[]&quot;,&quot;Description&quot;:&quot;Relay point closing dates&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("closing")]
		public string[] Closing {
			get {
				return this.Closing_bfield;
			}
			set {
				this.Closing_bfield = value;
			}
		}
		
		/// <summary>
		/// Relay country
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;coreTypes.CountryEnum&quot;,&quot;Description&quot;:&quot;Relay country&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("country")]
		public string Country {
			get {
				return this.Country_bfield;
			}
			set {
				this.Country_bfield = value;
			}
		}
		
		/// <summary>
		/// Distance between address and relay point
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;double&quot;,&quot;Description&quot;:&quot;Distance between address and relay point&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("distance")]
		public System.Nullable<double> Distance {
			get {
				return this.Distance_bfield;
			}
			set {
				this.Distance_bfield = value;
			}
		}
		
		/// <summary>
		/// Mondial Relay point ID
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Mondial Relay point ID&quot;,&quot;Readonly&quot;:false}
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
		/// Relay point latitude
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;double&quot;,&quot;Description&quot;:&quot;Relay point latitude&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("lat")]
		public double Lat {
			get {
				return this.Lat_bfield;
			}
			set {
				this.Lat_bfield = value;
			}
		}
		
		/// <summary>
		/// Relay point longitude
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;double&quot;,&quot;Description&quot;:&quot;Relay point longitude&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("lng")]
		public double Lng {
			get {
				return this.Lng_bfield;
			}
			set {
				this.Lng_bfield = value;
			}
		}
		
		/// <summary>
		/// URL of short map
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;URL of short map&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("mapUrl")]
		public string MapUrl {
			get {
				return this.MapUrl_bfield;
			}
			set {
				this.MapUrl_bfield = value;
			}
		}
		
		/// <summary>
		/// Relay point name
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Relay point name&quot;,&quot;Readonly&quot;:false}
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
		/// Relay point opening hours
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;supply.MondialRelayOpening&quot;,&quot;Description&quot;:&quot;Relay point opening hours&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("opening")]
		public SupplyMondialRelayOpening Opening {
			get {
				return this.Opening_bfield;
			}
			set {
				this.Opening_bfield = value;
			}
		}
		
		/// <summary>
		/// Relay point picture\s URL
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Relay point picture\\s URL&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("pictureUrl")]
		public string PictureUrl {
			get {
				return this.PictureUrl_bfield;
			}
			set {
				this.PictureUrl_bfield = value;
			}
		}
		
		/// <summary>
		/// Zipcode
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Zipcode&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("zipcode")]
		public string Zipcode {
			get {
				return this.Zipcode_bfield;
			}
			set {
				this.Zipcode_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Closing period for mondial relay point
	/// </summary>
	public class SupplyMondialRelayClosingPeriod {
		
		private System.DateTime End_bfield;
		
		private System.DateTime Start_bfield;
		
		/// <summary>
		/// Ending of closing period
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Ending of closing period&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("end")]
		public System.DateTime End {
			get {
				return this.End_bfield;
			}
			set {
				this.End_bfield = value;
			}
		}
		
		/// <summary>
		/// Beginning of closing period
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;datetime&quot;,&quot;Description&quot;:&quot;Beginning of closing period&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("start")]
		public System.DateTime Start {
			get {
				return this.Start_bfield;
			}
			set {
				this.Start_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Opening range for mondial relay point
	/// </summary>
	public class SupplyMondialRelayDayPeriod {
		
		private string End_bfield;
		
		private string Start_bfield;
		
		/// <summary>
		/// Ending time (00:00 format)
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Ending time (00:00 format)&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("end")]
		public string End {
			get {
				return this.End_bfield;
			}
			set {
				this.End_bfield = value;
			}
		}
		
		/// <summary>
		/// Starting time (00:00 format)
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Starting time (00:00 format)&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("start")]
		public string Start {
			get {
				return this.Start_bfield;
			}
			set {
				this.Start_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Day with schedule for mondial relay point opening
	/// </summary>
	public class SupplyMondialRelayOpening {
		
		private string[] Friday_bfield;
		
		private string[] Monday_bfield;
		
		private string[] Saturday_bfield;
		
		private string[] Sunday_bfield;
		
		private string[] Thursday_bfield;
		
		private string[] Tuesday_bfield;
		
		private string[] Wednesday_bfield;
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("friday")]
		public string[] Friday {
			get {
				return this.Friday_bfield;
			}
			set {
				this.Friday_bfield = value;
			}
		}
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("monday")]
		public string[] Monday {
			get {
				return this.Monday_bfield;
			}
			set {
				this.Monday_bfield = value;
			}
		}
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("saturday")]
		public string[] Saturday {
			get {
				return this.Saturday_bfield;
			}
			set {
				this.Saturday_bfield = value;
			}
		}
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("sunday")]
		public string[] Sunday {
			get {
				return this.Sunday_bfield;
			}
			set {
				this.Sunday_bfield = value;
			}
		}
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("thursday")]
		public string[] Thursday {
			get {
				return this.Thursday_bfield;
			}
			set {
				this.Thursday_bfield = value;
			}
		}
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("tuesday")]
		public string[] Tuesday {
			get {
				return this.Tuesday_bfield;
			}
			set {
				this.Tuesday_bfield = value;
			}
		}
		
		/// <summary>
		/// Opening range
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayDayPeriod[]&quot;,&quot;Description&quot;:&quot;Opening range&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("wednesday")]
		public string[] Wednesday {
			get {
				return this.Wednesday_bfield;
			}
			set {
				this.Wednesday_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Status and Mondial Relay Point Details
	/// </summary>
	public class SupplyMondialRelayResult {
		
		private string ReferenceAddress_bfield;
		
		private string[] RelayPoints_bfield;
		
		/// <summary>
		/// Reference address for finding RelayPoints
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Reference address for finding RelayPoints&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("referenceAddress")]
		public string ReferenceAddress {
			get {
				return this.ReferenceAddress_bfield;
			}
			set {
				this.ReferenceAddress_bfield = value;
			}
		}
		
		/// <summary>
		/// Array of relay points
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;supply.MondialRelay[]&quot;,&quot;Description&quot;:&quot;Array of relay points&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("relayPoints")]
		public string[] RelayPoints {
			get {
				return this.RelayPoints_bfield;
			}
			set {
				this.RelayPoints_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Status and Mondial Relay Point Details
	/// </summary>
	public class SupplyMondialRelayReturn {
		
		private string Error_bfield;
		
		private SupplyMondialRelayResult Result_bfield;
		
		private SupplyStatus Status_bfield;
		
		/// <summary>
		/// Error
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;string&quot;,&quot;Description&quot;:&quot;Error&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("error")]
		public string Error {
			get {
				return this.Error_bfield;
			}
			set {
				this.Error_bfield = value;
			}
		}
		
		/// <summary>
		/// Relay points list and reference address
		/// {&quot;CanBeNull&quot;:true,&quot;Type&quot;:&quot;supply.MondialRelayResult&quot;,&quot;Description&quot;:&quot;Relay points list and reference address&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("result")]
		public SupplyMondialRelayResult Result {
			get {
				return this.Result_bfield;
			}
			set {
				this.Result_bfield = value;
			}
		}
		
		/// <summary>
		/// Request status
		/// {&quot;CanBeNull&quot;:false,&quot;Type&quot;:&quot;supply.Status&quot;,&quot;Description&quot;:&quot;Request status&quot;,&quot;Readonly&quot;:false}
		/// </summary>
		[JsonProperty("status")]
		public SupplyStatus Status {
			get {
				return this.Status_bfield;
			}
			set {
				this.Status_bfield = value;
			}
		}
	}
	
	/// <summary>
	/// Request status
	/// </summary>
	public class SupplyStatus {
	}
}
