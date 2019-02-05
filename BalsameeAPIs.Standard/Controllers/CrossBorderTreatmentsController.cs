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
    public partial class CrossBorderTreatmentsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CrossBorderTreatmentsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CrossBorderTreatmentsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CrossBorderTreatmentsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="page">Required parameter: Example: </param>
        /// <param name="perPage">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5CrmCrossBorderTreatmentRequestsGet(
                int page,
                int perPage,
                string xAuthenticationToken,
                string xSessionId)
        {
            Task t = GetApiV5CrmCrossBorderTreatmentRequestsGetAsync(page, perPage, xAuthenticationToken, xSessionId);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="page">Required parameter: Example: </param>
        /// <param name="perPage">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5CrmCrossBorderTreatmentRequestsGetAsync(
                int page,
                int perPage,
                string xAuthenticationToken,
                string xSessionId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/crm/cross_border_treatment_requests");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "per_page", perPage }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "X-Authentication-Token", xAuthenticationToken },
                { "X-Session-Id", xSessionId }
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
        /// <param name="contentType">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentName">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentTelephoneNumber">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentEmail">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentDiagnosis">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentTreatmentGroupId">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentCountry">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentRequestType">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void CreateApiV5CrossBorderTreatmentRequestsPost(
                string contentType,
                string crossBorderTreatmentName,
                string crossBorderTreatmentTelephoneNumber,
                string crossBorderTreatmentEmail,
                string crossBorderTreatmentDiagnosis,
                string crossBorderTreatmentTreatmentGroupId,
                string crossBorderTreatmentCountry,
                string crossBorderTreatmentRequestType)
        {
            Task t = CreateApiV5CrossBorderTreatmentRequestsPostAsync(contentType, crossBorderTreatmentName, crossBorderTreatmentTelephoneNumber, crossBorderTreatmentEmail, crossBorderTreatmentDiagnosis, crossBorderTreatmentTreatmentGroupId, crossBorderTreatmentCountry, crossBorderTreatmentRequestType);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="contentType">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentName">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentTelephoneNumber">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentEmail">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentDiagnosis">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentTreatmentGroupId">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentCountry">Required parameter: Example: </param>
        /// <param name="crossBorderTreatmentRequestType">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateApiV5CrossBorderTreatmentRequestsPostAsync(
                string contentType,
                string crossBorderTreatmentName,
                string crossBorderTreatmentTelephoneNumber,
                string crossBorderTreatmentEmail,
                string crossBorderTreatmentDiagnosis,
                string crossBorderTreatmentTreatmentGroupId,
                string crossBorderTreatmentCountry,
                string crossBorderTreatmentRequestType)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/cross_border_treatment_requests");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "Content-Type", contentType }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "cross_border_treatment[name]", crossBorderTreatmentName ),
                new KeyValuePair<string, object>( "cross_border_treatment[telephone_number]", crossBorderTreatmentTelephoneNumber ),
                new KeyValuePair<string, object>( "cross_border_treatment[email]", crossBorderTreatmentEmail ),
                new KeyValuePair<string, object>( "cross_border_treatment[diagnosis]", crossBorderTreatmentDiagnosis ),
                new KeyValuePair<string, object>( "cross_border_treatment[treatment_group_id]", crossBorderTreatmentTreatmentGroupId ),
                new KeyValuePair<string, object>( "cross_border_treatment[country]", crossBorderTreatmentCountry ),
                new KeyValuePair<string, object>( "cross_border_treatment[request_type]", crossBorderTreatmentRequestType )
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

        /// <summary>
        /// -params[:type]  can be set as hospital or clinic
        ///       if not set at all the default is clinics only
        /// -params[:treatments] comma seperated treatments ids to filter with
        /// -params[:speciality_id] 
        /// -params[:country_codes] comma country codes ids to filter with
        /// -params[:country_code] for old apis to work send 1 country code to filter by
        /// cross border treatments should be sorted by price
        /// </summary>
        /// <param name="type">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5CrossBorderTreatmentsGet(string type)
        {
            Task t = GetApiV5CrossBorderTreatmentsGetAsync(type);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// -params[:type]  can be set as hospital or clinic
        ///       if not set at all the default is clinics only
        /// -params[:treatments] comma seperated treatments ids to filter with
        /// -params[:speciality_id] 
        /// -params[:country_codes] comma country codes ids to filter with
        /// -params[:country_code] for old apis to work send 1 country code to filter by
        /// cross border treatments should be sorted by price
        /// </summary>
        /// <param name="type">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5CrossBorderTreatmentsGetAsync(string type)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/cross_border_treatments");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "type", type }
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
        /// <param name="countryCode">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetStatesGet(string countryCode, string xSessionId, string xAuthenticationToken)
        {
            Task t = GetStatesGetAsync(countryCode, xSessionId, xAuthenticationToken);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="countryCode">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetStatesGetAsync(string countryCode, string xSessionId, string xAuthenticationToken)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/states");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "country_code", countryCode }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "X-Session-Id", xSessionId },
                { "X-Authentication-Token", xAuthenticationToken }
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
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5CrossBorderTreatmentsCountriesGet(string xSessionId, string xAuthenticationToken)
        {
            Task t = GetApiV5CrossBorderTreatmentsCountriesGetAsync(xSessionId, xAuthenticationToken);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5CrossBorderTreatmentsCountriesGetAsync(string xSessionId, string xAuthenticationToken)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/cross_border_treatments/countries");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "X-Session-Id", xSessionId },
                { "X-Authentication-Token", xAuthenticationToken }
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
        /// <param name="lang">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5TreatmentsGroupsGet(string lang)
        {
            Task t = GetApiV5TreatmentsGroupsGetAsync(lang);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="lang">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5TreatmentsGroupsGetAsync(string lang)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/treatments_groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
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