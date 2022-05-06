﻿using Devon4Net.Infrastructure.Nexus.Model.Repositories.Base;
using System.Text.Json.Serialization;

namespace Devon4Net.Infrastructure.Nexus.Model.Repositories.HostedRepositories
{
    public class MavenHostedRepository : RepositoryHosted
    {
        [JsonPropertyName("maven")]
        public Maven Maven { get; set; }
    }
}



