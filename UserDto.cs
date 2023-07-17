using Newtonsoft.Json;

namespace BankProject.Shared
{
    public class UserDto
    {
        [JsonProperty("user_id")]
        public string Id { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("given_name")]
        public string Name { get; set; }
        [JsonProperty("family_name")]
        public string LastName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        //[JsonProperty("phone_number")]
        //public string Phone { get; set; }
        //public string Address { get; set; }
        //public string Country { get; set; }
        //public string Role { get; set; }
        [JsonProperty("connection")]
        public string Connection { get; set; } = "Username-Password-Authentication";
    }
}
