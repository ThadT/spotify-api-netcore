using Spotify.API.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Spotify.API.NetCore.Enums;
using Xunit;

namespace SpotifyAPI.NetCore.Tests
{
    public class SpotifyUriTests
    {
        [Fact]
        public void ShouldThrowArgumentExceptionForInvalidUri()
        {
            Assert.Throws<ArgumentException>(() => SpotifyUri.Parse("asdafadfgsrsegqejfa"));
        }

        [Fact]
        public void ShouldCorrectlyParseTrackUri()
        {
            string testUri = "spotify:track:3QOruXa2lvqIFvOOa2rYyJ";
            SpotifyUri uri = SpotifyUri.Parse(testUri);

            uri.Base.Should().Be("spotify");
            uri.Type.Should().Be(UriType.track);
            uri.Id.Should().Be("3QOruXa2lvqIFvOOa2rYyJ");
            uri.ToString().Should().Be(testUri);
        }

        [Fact]
        public void ShouldCorrectlyParsePlaylistUri()
        {
            string testUri = "spotify:user:spotifycharts:playlist:37i9dQZEVXbMDoHDwVN2tF";
            SpotifyUri uri = SpotifyUri.Parse(testUri);

            uri.Base.Should().Be("spotify");
            uri.Type.Should().Be(UriType.playlist);
            uri.Id.Should().Be("37i9dQZEVXbMDoHDwVN2tF");

            uri.GetUriPropValue(UriType.user).Should().Be("spotifycharts");
            uri.ToString().Should().Be(testUri);
        }

        [Fact]
        public void ShouldHandleNotExistingUriProperty()
        {
            string testUri = "spotify:track:3QOruXa2lvqIFvOOa2rYyJ";
            SpotifyUri uri = SpotifyUri.Parse(testUri);

            Action action = () => uri.GetUriPropValue(UriType.user);
            action.Should().NotThrow();
            uri.GetUriPropValue(UriType.user).Should().BeNull();
        }
    }
}
