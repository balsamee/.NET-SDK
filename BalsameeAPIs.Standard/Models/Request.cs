/*
 * BalsameeAPIs.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BalsameeAPIs.Standard;
using BalsameeAPIs.Standard.Utilities;


namespace BalsameeAPIs.Standard.Models
{
    public class Request : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int eventId;
        private string actionMessage;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("event_id")]
        public int EventId 
        { 
            get 
            {
                return this.eventId; 
            } 
            set 
            {
                this.eventId = value;
                onPropertyChanged("EventId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("action_message")]
        public string ActionMessage 
        { 
            get 
            {
                return this.actionMessage; 
            } 
            set 
            {
                this.actionMessage = value;
                onPropertyChanged("ActionMessage");
            }
        }
    }
} 