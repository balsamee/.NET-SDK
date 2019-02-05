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
    public class PrescriptionImage : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string image;
        private int createdAt;
        private int updatedAt;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("image")]
        public string Image 
        { 
            get 
            {
                return this.image; 
            } 
            set 
            {
                this.image = value;
                onPropertyChanged("Image");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("created_at")]
        public int CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("updated_at")]
        public int UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }
    }
} 