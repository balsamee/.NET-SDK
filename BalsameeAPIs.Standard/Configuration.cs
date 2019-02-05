using System.Collections.Generic;
using System.Text;
using BalsameeAPIs.Standard.Utilities;
using BalsameeAPIs.Standard.Models;
namespace BalsameeAPIs.Standard
{
    public partial class Configuration
    {


        public enum Environments
        {
            PRODUCTION,
        }
        public enum Servers
        {
            SERVER1,
            SERVER2,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.SERVER1,"http://admin.balsamee.com/api/v5" },
                        { Servers.SERVER2,"https://api.sandbox.paypal.com/v1/oauth2" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:SERVER1</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.SERVER1)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}