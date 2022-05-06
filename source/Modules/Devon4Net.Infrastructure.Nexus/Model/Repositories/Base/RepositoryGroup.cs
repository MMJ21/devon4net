﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Devon4Net.Infrastructure.Nexus.Model.Repositories.Base
{
    public class RepositoryGroup : Repository
    {
        [JsonPropertyName("group")]
        public Group Group { get; set; }
    }

    public class Group
    {
        [JsonPropertyName("memberNames")]
        public List<string> MemberNames { get; set; }
        [JsonPropertyName("writableMember")]
        public string WritableMember { get; set; }
    }
}