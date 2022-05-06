﻿using Devon4Net.Infrastructure.Nexus.Model.Repositories.Base;
using System.Text.Json.Serialization;

namespace Devon4Net.Infrastructure.Nexus.Model.Repositories.GroupRepositories
{
    public class MavenGroupRepository : RepositoryGroup
    {
        [JsonPropertyName("maven")]
        public Maven Maven { get; set; }
    }
}



