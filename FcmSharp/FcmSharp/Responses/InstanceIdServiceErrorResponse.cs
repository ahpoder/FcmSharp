﻿using Newtonsoft.Json;

namespace FcmSharp.Responses
{
    public class InstanceIdServiceErrorResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
