using System;
using Newtonsoft.Json;

namespace HomeAutio.Mqtt.GoogleHome.Models.GoogleHomeGraph
{
    /// <summary>
    /// Access token response.
    /// </summary>
    public class AccessTokenResponse
    {
        /// <summary>
        /// Access token.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public required string AccessToken { get; init; }

        /// <summary>
        /// Expires in.
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public required int ExpiresIn { get; init; }

        /// <summary>
        /// Expires at.
        /// </summary>
        public required DateTime ExpiresAt {
            get
            {
                return CreatedAt.AddSeconds(ExpiresIn);
            }

            set
            {
                // no setter
            }
        }

        /// <summary>
        /// Created time
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public required string RefreshToken { get; init; }

        /// <summary>
        /// Scope.
        /// </summary>
        public required string Scope { get; init; }

        /// <summary>
        /// Token type.
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public required string TokenType { get; init; }
    }
}
