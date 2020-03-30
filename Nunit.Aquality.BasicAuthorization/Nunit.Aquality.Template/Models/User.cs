using Newtonsoft.Json;

namespace Nunit.Aquality.BasicAuthorizationTesting.Models
{
    public class User
    {
        [JsonProperty("user")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}