// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentAdditionalInfo
    {
        internal static SecurityInsightsIncidentAdditionalInfo DeserializeSecurityInsightsIncidentAdditionalInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> alertsCount = default;
            Optional<int> bookmarksCount = default;
            Optional<int> commentsCount = default;
            Optional<IReadOnlyList<string>> alertProductNames = default;
            Optional<IReadOnlyList<SecurityInsightsAttackTactic>> tactics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bookmarksCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bookmarksCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("commentsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("alertProductNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    alertProductNames = array;
                    continue;
                }
                if (property.NameEquals("tactics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                    }
                    tactics = array;
                    continue;
                }
            }
            return new SecurityInsightsIncidentAdditionalInfo(Optional.ToNullable(alertsCount), Optional.ToNullable(bookmarksCount), Optional.ToNullable(commentsCount), Optional.ToList(alertProductNames), Optional.ToList(tactics));
        }
    }
}