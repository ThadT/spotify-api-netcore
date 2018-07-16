using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Spotify.API.NetCore;
using Xunit;

namespace SpotifyAPI.NetCore.Tests
{
    public class UtilTest
    {
        [Fact]
        public void TimestampShouldBeNoFloatingPoint()
        {
            string timestamp = DateTime.Now.ToUnixTimeMillisecondsPoly().ToString();

            timestamp.Should().NotContain(".");
            timestamp.Should().NotContain(",");
        }
    }
}
