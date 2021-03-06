/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Trunking.V1.Trunk 
{

    /// <summary>
    /// FetchPhoneNumberOptions
    /// </summary>
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchPhoneNumberOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    /// DeletePhoneNumberOptions
    /// </summary>
    public class DeletePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeletePhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeletePhoneNumberOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    /// CreatePhoneNumberOptions
    /// </summary>
    public class CreatePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The phone_number_sid
        /// </summary>
        public string PhoneNumberSid { get; }

        /// <summary>
        /// Construct a new CreatePhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="phoneNumberSid"> The phone_number_sid </param>
        public CreatePhoneNumberOptions(string pathTrunkSid, string phoneNumberSid)
        {
            PathTrunkSid = pathTrunkSid;
            PhoneNumberSid = phoneNumberSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumberSid", PhoneNumberSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadPhoneNumberOptions
    /// </summary>
    public class ReadPhoneNumberOptions : ReadOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }

        /// <summary>
        /// Construct a new ReadPhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        public ReadPhoneNumberOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
        }

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