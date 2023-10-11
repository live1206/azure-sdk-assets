// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class CrossSiteAccessPolicies : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientAccessPolicy))
            {
                writer.WritePropertyName("clientAccessPolicy"u8);
                writer.WriteStringValue(ClientAccessPolicy);
            }
            if (Optional.IsDefined(CrossDomainPolicy))
            {
                writer.WritePropertyName("crossDomainPolicy"u8);
                writer.WriteStringValue(CrossDomainPolicy);
            }
            writer.WriteEndObject();
        }

        internal static CrossSiteAccessPolicies DeserializeCrossSiteAccessPolicies(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientAccessPolicy = default;
            Optional<string> crossDomainPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAccessPolicy"u8))
                {
                    clientAccessPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crossDomainPolicy"u8))
                {
                    crossDomainPolicy = property.Value.GetString();
                    continue;
                }
            }
            return new CrossSiteAccessPolicies(clientAccessPolicy.Value, crossDomainPolicy.Value);
        }
    }
}
