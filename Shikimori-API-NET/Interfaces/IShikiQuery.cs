using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ShikimoriAPI.Interfaces
{
    // TODO remove 'FormUrlEncodedContent' dependency and set IShikiUser as property
    interface IShikiQuery
    {
        T GET<T>(string url, IShikiUser user = null);

        T POST<T>(string url, FormUrlEncodedContent args, IShikiUser user = null);

        T PUT<T>(string url, FormUrlEncodedContent args, IShikiUser user = null);

        HttpStatusCode DELETE(string url, IShikiUser user = null);
    }
}
