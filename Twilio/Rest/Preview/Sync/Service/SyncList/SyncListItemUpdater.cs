using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Sync.Service.SyncList 
{

    public class SyncListItemUpdater : Updater<SyncListItemResource> 
    {
        public string ServiceSid { get; }
        public string ListSid { get; }
        public int? Index { get; }
        public Object Data { get; }
    
        /// <summary>
        /// Construct a new SyncListItemUpdater
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="listSid"> The list_sid </param>
        /// <param name="index"> The index </param>
        /// <param name="data"> The data </param>
        public SyncListItemUpdater(string serviceSid, string listSid, int? index, Object data)
        {
            ServiceSid = serviceSid;
            ListSid = listSid;
            Index = index;
            Data = data;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated SyncListItemResource </returns> 
        public override async System.Threading.Tasks.Task<SyncListItemResource> UpdateAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/Sync/Services/" + ServiceSid + "/Lists/" + ListSid + "/Items/" + Index + "",
                client.Region
            );
            AddPostParams(request);
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("SyncListItemResource update failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return SyncListItemResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated SyncListItemResource </returns> 
        public override SyncListItemResource Update(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/Sync/Services/" + ServiceSid + "/Lists/" + ListSid + "/Items/" + Index + "",
                client.Region
            );
            AddPostParams(request);
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("SyncListItemResource update failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return SyncListItemResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void AddPostParams(Request request)
        {
            if (Data != null)
            {
                request.AddPostParam("Data", Data.ToString());
            }
        }
    }
}