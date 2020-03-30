using Newtonsoft.Json;

namespace Nunit.Aquality.BasicAuthorizationTesting.Models
{
    public class AuthenticatedUser
    {
        [JsonProperty("authenticated")]
        public bool IsAuthenticated { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}