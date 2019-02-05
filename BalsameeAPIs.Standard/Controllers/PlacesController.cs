/*
 * BalsameeAPIs.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using BalsameeAPIs.Standard;
using BalsameeAPIs.Standard.Utilities;
using BalsameeAPIs.Standard.Http.Request;
using BalsameeAPIs.Standard.Http.Response;
using BalsameeAPIs.Standard.Http.Client;
using BalsameeAPIs.Standard.Exceptions;

namespace BalsameeAPIs.Standard.Controllers
{
    public partial class PlacesController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PlacesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PlacesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PlacesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// # URL         => /places
        ///   # Method      => GET
        ///   # Description => return regions of country text search with type in that country
        ///   #==Parameters
        ///   # headers['X-Authentication-Token']
        ///   # headers['X-Session-Id']
        ///   # headers['X-App-Id']
        ///   # params[:latitude]
        ///   # params[:longitude]
        ///   # params[:type] : clinic or hospital ... etc
        ///   #==Response/JSON
        ///   # { data: {} }, status: :ok
        /// </summary>
        /// <param name="latitude">Required parameter: Example: </param>
        /// <param name="longitude">Required parameter: Example: </param>
        /// <param name="type">Required parameter: Example: </param>
        /// <param name="lang">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5PlacesGet(
                double latitude,
                double longitude,
                string type,
                string lang)
        {
            Task t = GetApiV5PlacesGetAsync(latitude, longitude, type, lang);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// # URL         => /places
        ///   # Method      => GET
        ///   # Description => return regions of country text search with type in that country
        ///   #==Parameters
        ///   # headers['X-Authentication-Token']
        ///   # headers['X-Session-Id']
        ///   # headers['X-App-Id']
        ///   # params[:latitude]
        ///   # params[:longitude]
        ///   # params[:type] : clinic or hospital ... etc
        ///   #==Response/JSON
        ///   # { data: {} }, status: :ok
        /// </summary>
        /// <param name="latitude">Required parameter: Example: </param>
        /// <param name="longitude">Required parameter: Example: </param>
        /// <param name="type">Required parameter: Example: </param>
        /// <param name="lang">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5PlacesGetAsync(
                double latitude,
                double longitude,
                string type,
                string lang)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/places");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "latitude", latitude },
                { "longitude", longitude },
                { "type", type },
                { "lang", lang }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        ///   # URL         => /places/categories
        ///   # Method      => GET
        ///   # Description => return categories
        ///   #==Parameters
        ///   # headers['X-Authentication-Token']
        ///   # headers['X-Session-Id']
        ///   # headers['X-App-Id']
        ///   #==Response/JSON
        ///   # { categories: {} }, status: :ok
        /// </summary>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xAppId">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5PlacesCategoriesGet(string xSessionId, string xAuthenticationToken, string xAppId)
        {
            Task t = GetApiV5PlacesCategoriesGetAsync(xSessionId, xAuthenticationToken, xAppId);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        ///   # URL         => /places/categories
        ///   # Method      => GET
        ///   # Description => return categories
        ///   #==Parameters
        ///   # headers['X-Authentication-Token']
        ///   # headers['X-Session-Id']
        ///   # headers['X-App-Id']
        ///   #==Response/JSON
        ///   # { categories: {} }, status: :ok
        /// </summary>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xAppId">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5PlacesCategoriesGetAsync(string xSessionId, string xAuthenticationToken, string xAppId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/places/categories");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "X-Session-Id", xSessionId },
                { "X-Authentication-Token", xAuthenticationToken },
                { "X-App-Id", xAppId }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// # URL         => /places/id
        ///   # Method      => GET
        ///   # Description => get details about some place      
        ///   #==Parameters
        ///   # headers['X-Authentication-Token']
        ///   # headers['X-Session-Id']
        ///   # headers['X-App-Id']
        ///   # params[:id] : place id you want to get details about  
        ///   # params[:source] : currently g for google and f for foursquare
        ///   # you should add app_id
        ///   #==Response/JSON
        ///   # { data: detailed data about specified place }, status: :ok
        ///   # returned data consists of
        ///   # formatted_address  
        ///   # formatted_phone_number
        ///   # international_phone_number
        ///   # photo_url : photo_url
        /// </summary>
        /// <param name="source">Required parameter: Example: </param>
        /// <param name="lang">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGet(string source, string lang)
        {
            Task t = GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGetAsync(source, lang);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// # URL         => /places/id
        ///   # Method      => GET
        ///   # Description => get details about some place      
        ///   #==Parameters
        ///   # headers['X-Authentication-Token']
        ///   # headers['X-Session-Id']
        ///   # headers['X-App-Id']
        ///   # params[:id] : place id you want to get details about  
        ///   # params[:source] : currently g for google and f for foursquare
        ///   # you should add app_id
        ///   #==Response/JSON
        ///   # { data: detailed data about specified place }, status: :ok
        ///   # returned data consists of
        ///   # formatted_address  
        ///   # formatted_phone_number
        ///   # international_phone_number
        ///   # photo_url : photo_url
        /// </summary>
        /// <param name="source">Required parameter: Example: </param>
        /// <param name="lang">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGetAsync(string source, string lang)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/places/ChIJC7wXvkEWWBQRaULiE84-dFE");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "source", source },
                { "lang", lang }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 