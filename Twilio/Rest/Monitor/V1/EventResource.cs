using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Exceptions;

namespace Twilio.Rest.Monitor.V1 
{

    public class EventResource : Resource 
    {
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> EventFetcher capable of executing the fetch </returns> 
        public static EventFetcher Fetcher(string sid)
        {
            return new EventFetcher(sid);
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <returns> EventReader capable of executing the read </returns> 
        public static EventReader Reader()
        {
            return new EventReader();
        }
    
        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns> 
        public static EventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string AccountSid { get; set; }
        [JsonProperty("actor_sid")]
        public string ActorSid { get; set; }
        [JsonProperty("actor_type")]
        public string ActorType { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("event_data")]
        public Object EventData { get; set; }
        [JsonProperty("event_date")]
        public DateTime? EventDate { get; set; }
        [JsonProperty("event_type")]
        public string EventType { get; set; }
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; set; }
        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }
        [JsonProperty("sid")]
        public string Sid { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("source_ip_address")]
        public string SourceIpAddress { get; set; }
        [JsonProperty("url")]
        public Uri Url { get; set; }
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; set; }
    
        public EventResource()
        {
        
        }
    
        private EventResource([JsonProperty("account_sid")]
                              string accountSid, 
                              [JsonProperty("actor_sid")]
                              string actorSid, 
                              [JsonProperty("actor_type")]
                              string actorType, 
                              [JsonProperty("description")]
                              string description, 
                              [JsonProperty("event_data")]
                              Object eventData, 
                              [JsonProperty("event_date")]
                              string eventDate, 
                              [JsonProperty("event_type")]
                              string eventType, 
                              [JsonProperty("resource_sid")]
                              string resourceSid, 
                              [JsonProperty("resource_type")]
                              string resourceType, 
                              [JsonProperty("sid")]
                              string sid, 
                              [JsonProperty("source")]
                              string source, 
                              [JsonProperty("source_ip_address")]
                              string sourceIpAddress, 
                              [JsonProperty("url")]
                              Uri url, 
                              [JsonProperty("links")]
                              Dictionary<string, string> links)
                              {
            AccountSid = accountSid;
            ActorSid = actorSid;
            ActorType = actorType;
            Description = description;
            EventData = eventData;
            EventDate = MarshalConverter.DateTimeFromString(eventDate);
            EventType = eventType;
            ResourceSid = resourceSid;
            ResourceType = resourceType;
            Sid = sid;
            Source = source;
            SourceIpAddress = sourceIpAddress;
            Url = url;
            Links = links;
        }
    }
}