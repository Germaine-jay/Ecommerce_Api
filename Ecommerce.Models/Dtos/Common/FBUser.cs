﻿using Newtonsoft.Json;

namespace Ecommerce.Models.Dtos.Common
{
    public partial class FBUser
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("app_id")]
        public string? AppId { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("application")]
        public string? Application { get; set; }

        [JsonProperty("data_access_expires_at")]
        public long DataAccessExpiresAt { get; set; }

        [JsonProperty("expires_at")]
        public long ExpiresAt { get; set; }

        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }

    public class FBUserInfo
    {

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }
    }
}
