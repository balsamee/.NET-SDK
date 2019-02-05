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
    public class IndexlabrequestsgroupsforreservationrequestClinicvisit : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<string> labRequests;
        private List<Models.LabRequestImagesGroup> labRequestImagesGroups;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lab_requests")]
        public List<string> LabRequests 
        { 
            get 
            {
                return this.labRequests; 
            } 
            set 
            {
                this.labRequests = value;
                onPropertyChanged("LabRequests");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lab_request_images_groups")]
        public List<Models.LabRequestImagesGroup> LabRequestImagesGroups 
        { 
            get 
            {
                return this.labRequestImagesGroups; 
            } 
            set 
            {
                this.labRequestImagesGroups = value;
                onPropertyChanged("LabRequestImagesGroups");
            }
        }
    }
} 