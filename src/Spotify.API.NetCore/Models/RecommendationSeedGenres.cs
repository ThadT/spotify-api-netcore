using System.Collections.Generic;
using Newtonsoft.Json;

namespace Spotify.API.NetCore.Models
{
    public class RecommendationSeedGenres : BasicModel
    {
         [JsonProperty("genres")]
         public List<string> Genres { get; set; }
    }
}