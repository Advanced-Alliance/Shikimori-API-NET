using System;
using Xunit;
using ShikimoriAPI;

namespace ShikimoriAPI.Tests
{
    public class ShikimoriAPI_BaseFunctions
    {
        private readonly ShikAPI _shikimoriAPI;

        public ShikimoriAPI_BaseFunctions()
        {
            _shikimoriAPI = new ShikAPI();
        }

        [Fact]
        public void CurrentURL()
        {
            Assert.Equal("https://shikimori.one/api/", _shikimoriAPI.GetCurrentAPI_URL());
        }
    }
}
