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
    public partial class MiniPmrController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static MiniPmrController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static MiniPmrController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MiniPmrController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5IndividualsMedicalProfileStatisticsGet(string xSessionId, string xAuthenticationToken)
        {
            Task t = GetApiV5IndividualsMedicalProfileStatisticsGetAsync(xSessionId, xAuthenticationToken);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5IndividualsMedicalProfileStatisticsGetAsync(string xSessionId, string xAuthenticationToken)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/individuals/medical_profile_statistics");


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
        /// <return>Returns the Models.ListRadiologyScans response from the API call</return>
        public Models.ListRadiologyScans GetApiV5RadiologyScansGet(string xSessionId, string xAuthenticationToken)
        {
            Task<Models.ListRadiologyScans> t = GetApiV5RadiologyScansGetAsync(xSessionId, xAuthenticationToken);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: Add Description
        /// </summary>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <return>Returns the Models.ListRadiologyScans response from the API call</return>
        public async Task<Models.ListRadiologyScans> GetApiV5RadiologyScansGetAsync(string xSessionId, string xAuthenticationToken)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/radiology_scans");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
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

            try
            {
                return APIHelper.JsonDeserialize<Models.ListRadiologyScans>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 