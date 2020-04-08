﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HATEOAS.Models
{
    public abstract class Resource
    {
        [JsonProperty("_links", Order = -2)]
        public List<Link> Links { get; } = new List<Link>();
    }
}
