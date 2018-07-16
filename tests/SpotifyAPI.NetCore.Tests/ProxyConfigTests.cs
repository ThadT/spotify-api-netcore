using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Spotify.API.NetCore;
using Xunit;

namespace SpotifyAPI.NetCore.Tests
{
    public class ProxyConfigTest
    {
        #region GetUri

        [Fact]
        public void GetUri_HostNameWithScheme()
        {
            ProxyConfig config = new ProxyConfig { Host = "https://test-host.com" };
            CheckUri(config.GetUri(), "https", "test-host.com", 80);
        }

        [Fact]
        public void GetUri_HostNameWithoutScheme()
        {
            ProxyConfig config = new ProxyConfig { Host = "test-host.com" };
            CheckUri(config.GetUri(), "http", "test-host.com", 80);
        }

        [Fact]
        public void GetUri_HostNameWithSchemeAndPort()
        {
            ProxyConfig config = new ProxyConfig
            {
                Host = "https://test-host.com",
                Port = 8080
            };
            CheckUri(config.GetUri(), "https", "test-host.com", 8080);
        }

        [Fact]
        public void GetUri_HostAddressWithScheme()
        {
            ProxyConfig config = new ProxyConfig { Host = "https://192.168.0.1" };
            CheckUri(config.GetUri(), "https", "192.168.0.1", 80);
        }

        [Fact]
        public void GetUri_HostAddressWithoutScheme()
        {
            ProxyConfig config = new ProxyConfig { Host = "192.168.0.1" };
            CheckUri(config.GetUri(), "http", "192.168.0.1", 80);
        }

        [Fact]
        public void GetUri_HostAddressWithSchemeAndPort()
        {
            ProxyConfig config = new ProxyConfig
            {
                Host = "https://192.168.0.1",
                Port = 8080
            };
            CheckUri(config.GetUri(), "https", "192.168.0.1", 8080);
        }

        [Fact]
        public void GetUri_NullHost()
        {
            ProxyConfig config = new ProxyConfig { Host = null };
            Action action = () => config.GetUri();
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void GetUri_EmptyHost()
        {
            ProxyConfig config = new ProxyConfig { Host = string.Empty };
            Action action = () => config.GetUri();
            action.Should().Throw<UriFormatException>();
        }

        [Fact]
        public void GetUri_NegativePort()
        {
            ProxyConfig config = new ProxyConfig
            {
                Host = "test-host.com",
                Port = -10
            };
            Action action = () => config.GetUri();
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        #endregion GetUri

        [Fact]
        public void Set_Null()
        {
            ProxyConfig config = new ProxyConfig
            {
                Host = "https://test-host.com",
                Port = 1234,
                Username = "admin",
                Password = "password",
                BypassProxyOnLocal = true
            };
            config.Set(null);
            config.Should().NotBeNull();
            config.Host.Should().BeNull();
            config.Port.Should().Be(80);
            config.Username.Should().BeNull();
            config.Password.Should().BeNull();
            config.BypassProxyOnLocal.Should().BeFalse();
        }

        private static void CheckUri(Uri uri, string expectedScheme, string expectedHost, int expectedPort)
        {
            uri.Scheme.Should().Be(expectedScheme);
            uri.Host.Should().Be(expectedHost);
            uri.Port.Should().Be(expectedPort);
        }
    }
}
