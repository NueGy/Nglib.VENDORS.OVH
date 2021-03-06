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
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;


namespace Nglib.VENDORS.OVH.DOMAIN {
	
	
	/// <summary>
	/// OVH API WRAPPER
	/// </summary>
	public class DOMAINWrapper : IWrapper
    {
        public System.Net.Http.HttpClient client { get; set; }

        public IOvhApiCredentials Credentials { get; set; }

        public DOMAINWrapper(IOvhApiCredentials credentials, System.Net.Http.HttpClient client = null)
        {
            this.Credentials = credentials;
            if (client != null) this.client = client;
            else this.client = OvhApiTools.FactoryClient(this.Credentials);
        }



        public async Task<List<string>> GetListDomains() => await OvhApiTools.ExecuteWithModelAsync<List<string>>(this.client, this.Credentials, HttpMethod.Get, $"domain/zone");


        public async Task<string> GetDomainContent(string domainName) => await OvhApiTools.ExecuteWithModelAsync<string>(this.client, this.Credentials, HttpMethod.Get, $"domain/zone/{domainName}/export");

        public async Task<DomainFullApiModel> GetDomainFull(string domainName)
        {
            DomainFullApiModel retour = await OvhApiTools.ExecuteWithModelAsync<DomainFullApiModel>(this.client, this.Credentials, HttpMethod.Get, $"domain/{domainName}");
            retour.serviceInfo = await OvhApiTools.ExecuteWithModelAsync<ServicesService>(this.client, this.Credentials, HttpMethod.Get, $"domain/{domainName}/serviceInfos");
            retour.zoneInfo = await OvhApiTools.ExecuteWithModelAsync<DomainzoneZone>(this.client, this.Credentials, HttpMethod.Get, $"domain/zone/{domainName}");
            return retour;
        }

        public async Task<DomainzoneRecord> AddZoneRecord(string domainName, DomainzoneRecord modelrequest)
            => await OvhApiTools.ExecuteWithModelAsync<DomainzoneRecord>(this.client, this.Credentials, HttpMethod.Post, $"domain/zone/{domainName}/record", null, modelrequest);


        public async Task<string> RefreshZone(string domainName) => await OvhApiTools.ExecuteWithModelAsync<string>(this.client, this.Credentials, HttpMethod.Post, $"domain/zone/{domainName}/refresh");




    }
}
