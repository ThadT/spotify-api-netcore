using System.Collections.Generic;
using Newtonsoft.Json;

namespace Spotify.API.NetCore.Models
{
    public class SeveralArtists : BasicModel
    {
        [JsonProperty("artists")]
        public List<FullArtist> Artists { get; set; }
    }
}