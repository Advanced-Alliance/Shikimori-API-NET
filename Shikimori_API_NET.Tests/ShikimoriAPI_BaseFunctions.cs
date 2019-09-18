using System;
using Xunit;
using Shikimori_API_NET;

namespace Shikimori_API_NET.Tests
{
    public class ShikimoriAPI_BaseFunctions
    {
        private readonly ShikimoriAPI _shikimoriAPI;

        public ShikimoriAPI_BaseFunctions()
        {
            _shikimoriAPI = new ShikimoriAPI();
        }

        [Fact]
        public void CurrentURL()
        {
            Assert.Equal("https://shikimori.one/api/", _shikimoriAPI.GetCurrentAPI_URL());
        }
    }
}
