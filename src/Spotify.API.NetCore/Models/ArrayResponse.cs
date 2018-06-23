using System.Collections.Generic;

namespace Spotify.API.NetCore.Models
{
    public class ListResponse<T> : BasicModel
    {
        public List<T> List { get; set; }
    }
}