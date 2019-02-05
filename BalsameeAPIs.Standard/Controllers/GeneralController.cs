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
    public partial class GeneralController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static GeneralController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static GeneralController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new GeneralController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Return career levels with specialities
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5SpecialitiesWithCareerLevelsGet()
        {
            Task t = GetApiV5SpecialitiesWithCareerLevelsGetAsync();
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Return career levels with specialities
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5SpecialitiesWithCareerLevelsGetAsync()
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/specialities_with_career_levels");


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
        /// Search news
        /// </summary>
        /// <param name="q">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5SearchGet(string q)
        {
            Task t = GetApiV5SearchGetAsync(q);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Search news
        /// </summary>
        /// <param name="q">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5SearchGetAsync(string q)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/search");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "q", q }
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
        /// TODO: Add Description
        /// </summary>
        /// <param name="appVersion">Required parameter: Example: </param>
        /// <param name="xAppId">Required parameter: Example: </param>
        /// <param name="userAgent">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5AppVersionGet(DateTime appVersion, string xAppId, string userAgent)
        {
            Task t = GetApiV5AppVersionGetAsync(appVersion, xAppId, userAgent);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="appVersion">Required parameter: Example: </param>
        /// <param name="xAppId">Required parameter: Example: </param>
        /// <param name="userAgent">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5AppVersionGetAsync(DateTime appVersion, string xAppId, string userAgent)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/app_version");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "app_version", appVersion.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "X-App-Id", xAppId },
                { "User-Agent", userAgent }
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
        /// TODO: Add Description
        /// </summary>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="careerLevelId">Required parameter: Example: </param>
        /// <param name="specialityId">Required parameter: Example: </param>
        /// <param name="mobileNumber">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void CreateApiV5DoctorRequestsPost(
                string xAuthenticationToken,
                string xSessionId,
                string careerLevelId,
                string specialityId,
                string mobileNumber)
        {
            Task t = CreateApiV5DoctorRequestsPostAsync(xAuthenticationToken, xSessionId, careerLevelId, specialityId, mobileNumber);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="careerLevelId">Required parameter: Example: </param>
        /// <param name="specialityId">Required parameter: Example: </param>
        /// <param name="mobileNumber">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateApiV5DoctorRequestsPostAsync(
                string xAuthenticationToken,
                string xSessionId,
                string careerLevelId,
                string specialityId,
                string mobileNumber)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/doctor_requests");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "X-Authentication-Token", xAuthenticationToken },
                { "X-Session-Id", xSessionId }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "career_level_id", careerLevelId ),
                new KeyValuePair<string, object>( "speciality_id", specialityId ),
                new KeyValuePair<string, object>( "mobile_number", mobileNumber )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 