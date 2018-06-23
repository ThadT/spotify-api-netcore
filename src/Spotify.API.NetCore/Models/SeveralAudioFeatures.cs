using System.Collections.Generic;
using Newtonsoft.Json;

namespace Spotify.API.NetCore.Models
{
    public class SeveralAudioFeatures : BasicModel
    {
         [JsonProperty("audio_features")]
         public List<AudioFeatures> AudioFeatures { get; set; }
    }
}