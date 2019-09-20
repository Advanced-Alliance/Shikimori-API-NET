using System;

namespace ShikimoriAPI
{
    public class ShikAPI
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
