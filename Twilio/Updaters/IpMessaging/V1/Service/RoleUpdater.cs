using System.Collections.Generic;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.IpMessaging.V1.Service;
using Twilio.Updaters;

namespace Twilio.Updaters.IpMessaging.V1.Service {

    public class RoleUpdater : Updater<RoleResource> {
        private string serviceSid;
        private string sid;
        private string friendlyName;
        private List<string> permission;
    
        /**
         * Construct a new RoleUpdater
         * 
         * @param serviceSid The service_sid
         * @param sid The sid
         * @param friendlyName The friendly_name
         * @param permission The permission
         */
        public RoleUpdater(string serviceSid, string sid, string friendlyName, List<string> permission) {
            this.serviceSid = serviceSid;
            this.sid = sid;
            this.friendlyName = friendlyName;
            this.permission = permission;
        }
    
        /**
         * Make the request to the Twilio API to perform the update
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Updated RoleResource
         */
        public override async Task<RoleResource> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                Domains.IPMESSAGING,
                "/v1/Services/" + this.serviceSid + "/Roles/" + this.sid + ""
            );
            
            addPostParams(request);
            Response response = await client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("RoleResource update failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return RoleResource.FromJson(response.GetContent());
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (friendlyName != "") {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (permission != null) {
                request.AddPostParam("Permission", permission.ToString());
            }
        }
    }
}