﻿using Newtonsoft.Json;

namespace Box.V2.Models
{
    public class BoxCollaborationUserRequest : BoxRequestEntity
    {

        /// <summary>
        /// An email address (does not need to be a Box user)
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

    }
}
