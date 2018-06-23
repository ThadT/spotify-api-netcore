using Newtonsoft.Json;

namespace Spotify.API.NetCore.Models
{
    public class Snapshot : BasicModel
    {
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }
    }
}