using Newtonsoft.Json;

namespace Spotify.API.NetCore.Models
{
    public class CategoryList : BasicModel
    {
        [JsonProperty("categories")]
        public Paging<Category> Categories { get; set; }
    }
}