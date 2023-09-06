using Newtonsoft.Json;

namespace Notify.Models
{
    public class NotifyHTTPError
    {
        #pragma warning disable 169
        [JsonProperty("error")]
        public string error;

        [JsonProperty("message")]
        public string message;
    }
}
