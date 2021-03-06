/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Marketplace 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Install an Add-on for the Account specified.
    /// </summary>
    public class CreateInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// A string that uniquely identifies the Add-on to install
        /// </summary>
        public string AvailableAddOnSid { get; }
        /// <summary>
        /// A boolean reflecting your acceptance of the Terms of Service
        /// </summary>
        public bool? AcceptTermsOfService { get; }
        /// <summary>
        /// The JSON object representing the configuration
        /// </summary>
        public object Configuration { get; set; }
        /// <summary>
        /// The string that uniquely identifies this Add-on installation
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new CreateInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="availableAddOnSid"> A string that uniquely identifies the Add-on to install </param>
        /// <param name="acceptTermsOfService"> A boolean reflecting your acceptance of the Terms of Service </param>
        public CreateInstalledAddOnOptions(string availableAddOnSid, bool? acceptTermsOfService)
        {
            AvailableAddOnSid = availableAddOnSid;
            AcceptTermsOfService = acceptTermsOfService;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AvailableAddOnSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AvailableAddOnSid", AvailableAddOnSid.ToString()));
            }

            if (AcceptTermsOfService != null)
            {
                p.Add(new KeyValuePair<string, string>("AcceptTermsOfService", AcceptTermsOfService.Value.ToString()));
            }

            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Serializers.JsonObject(Configuration)));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Remove an Add-on installation from your account
    /// </summary>
    public class DeleteInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// The Installed Add-on Sid to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The Installed Add-on Sid to delete </param>
        public DeleteInstalledAddOnOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch an instance of an Add-on currently installed on this Account.
    /// </summary>
    public class FetchInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// The unique Installed Add-on Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The unique Installed Add-on Sid </param>
        public FetchInstalledAddOnOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Update an Add-on installation for the Account specified.
    /// </summary>
    public class UpdateInstalledAddOnOptions : IOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The JSON object representing the configuration
        /// </summary>
        public object Configuration { get; set; }
        /// <summary>
        /// The string that uniquely identifies this Add-on installation
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new UpdateInstalledAddOnOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateInstalledAddOnOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Serializers.JsonObject(Configuration)));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of Add-ons currently installed on this Account.
    /// </summary>
    public class ReadInstalledAddOnOptions : ReadOptions<InstalledAddOnResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}