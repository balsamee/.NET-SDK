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
    public class Allergy : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string allergen;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("allergen")]
        public string Allergen 
        { 
            get 
            {
                return this.allergen; 
            } 
            set 
            {
                this.allergen = value;
                onPropertyChanged("Allergen");
            }
        }
    }
} 