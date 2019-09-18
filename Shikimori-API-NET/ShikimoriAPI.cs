using System;

namespace Shikimori_API_NET
{
    public class ShikimoriAPI
    {
        // TODO перенести в конфиг
        //private static string API_URL { get { return "https://shikimori.one/api/"; } }
        private const string API_URL = "https://shikimori.one/api/";

        public string GetCurrentAPI_URL()
        {
            return API_URL;
        }

    }
}
