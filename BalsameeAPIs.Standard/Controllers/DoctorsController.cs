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
    public partial class DoctorsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static DoctorsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DoctorsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new DoctorsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        ///   Get Doctors
        ///   This API by default did'nt include accepted doctor in the response  
        ///     
        ///   @params [Float] latitude  
        ///   @params [Float] longitude  
        ///   @param  [Integer] speciality_id  
        ///   @param  [Integer] career_level_id  
        ///   @return [JsonArray] doctors
        ///  
        ///   This API called if uer authenticated or not  
        ///   in case of authenticated user. send required authentication headers as below:  
        ///  
        ///  X-Authentication-Token  
        ///  X-Session-Id  
        ///  
        /// </summary>
        /// <param name="latitude">Required parameter: Example: </param>
        /// <param name="longitude">Required parameter: Example: </param>
        /// <param name="specialityId">Required parameter: Example: </param>
        /// <param name="careerLevelId">Required parameter: Example: </param>
        /// <param name="limit">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void GetApiV5DoctorsGet(
                double latitude,
                double longitude,
                string specialityId,
                string careerLevelId,
                int limit,
                string xAuthenticationToken,
                string xSessionId)
        {
            Task t = GetApiV5DoctorsGetAsync(latitude, longitude, specialityId, careerLevelId, limit, xAuthenticationToken, xSessionId);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        ///   Get Doctors
        ///   This API by default did'nt include accepted doctor in the response  
        ///     
        ///   @params [Float] latitude  
        ///   @params [Float] longitude  
        ///   @param  [Integer] speciality_id  
        ///   @param  [Integer] career_level_id  
        ///   @return [JsonArray] doctors
        ///  
        ///   This API called if uer authenticated or not  
        ///   in case of authenticated user. send required authentication headers as below:  
        ///  
        ///  X-Authentication-Token  
        ///  X-Session-Id  
        ///  
        /// </summary>
        /// <param name="latitude">Required parameter: Example: </param>
        /// <param name="longitude">Required parameter: Example: </param>
        /// <param name="specialityId">Required parameter: Example: </param>
        /// <param name="careerLevelId">Required parameter: Example: </param>
        /// <param name="limit">Required parameter: Example: </param>
        /// <param name="xAuthenticationToken">Required parameter: Example: </param>
        /// <param name="xSessionId">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task GetApiV5DoctorsGetAsync(
                double latitude,
                double longitude,
                string specialityId,
                string careerLevelId,
                int limit,
                string xAuthenticationToken,
                string xSessionId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/doctors");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "latitude", latitude },
                { "longitude", longitude },
                { "speciality_id", specialityId },
                { "career_level_id", careerLevelId },
                { "limit", limit }
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

    }
} 