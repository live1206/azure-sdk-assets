// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServerVersionCapability
    {
        internal static SqlServerVersionCapability DeserializeSqlServerVersionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<EditionCapability>> supportedEditions = default;
            Optional<IReadOnlyList<ElasticPoolEditionCapability>> supportedElasticPoolEditions = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EditionCapability> array = new List<EditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EditionCapability.DeserializeEditionCapability(item));
                    }
                    supportedEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedElasticPoolEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticPoolEditionCapability> array = new List<ElasticPoolEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolEditionCapability.DeserializeElasticPoolEditionCapability(item));
                    }
                    supportedElasticPoolEditions = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new SqlServerVersionCapability(name.Value, Optional.ToList(supportedEditions), Optional.ToList(supportedElasticPoolEditions), Optional.ToNullable(status), reason.Value);
        }
    }
}