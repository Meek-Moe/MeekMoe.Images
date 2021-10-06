using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeekMoe.Images.Entities
{
    public class MeekMoeImage
    {
        /// <summary>
        /// Direct image URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; internal set; }

        /// <summary>
        /// Rarely filled
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; internal set; }

        /// <summary>
        /// Should not be manually constructed
        /// </summary>
        [JsonConstructor]
        internal MeekMoeImage()
        {}
    }
}
