﻿using Devon4Net.Infrastructure.Nexus.Model.Repositories.Base;
using System.Text.Json.Serialization;

namespace Devon4Net.Infrastructure.Nexus.Model.Repositories.GroupRepositories
{
    public class YumGroupRepository : RepositoryGroup
    {
        [JsonPropertyName("yum")]
        public Yum Yum { get; set; }
    }
}
