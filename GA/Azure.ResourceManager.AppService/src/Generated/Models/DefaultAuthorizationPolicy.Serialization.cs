// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DefaultAuthorizationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowedPrincipals))
            {
                writer.WritePropertyName("allowedPrincipals"u8);
                writer.WriteObjectValue(AllowedPrincipals);
            }
            if (Optional.IsCollectionDefined(AllowedApplications))
            {
                writer.WritePropertyName("allowedApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedApplications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DefaultAuthorizationPolicy DeserializeDefaultAuthorizationPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceAadAllowedPrincipals> allowedPrincipals = default;
            Optional<IList<string>> allowedApplications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedPrincipals = AppServiceAadAllowedPrincipals.DeserializeAppServiceAadAllowedPrincipals(property.Value);
                    continue;
                }
                if (property.NameEquals("allowedApplications"u8))
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
                    allowedApplications = array;
                    continue;
                }
            }
            return new DefaultAuthorizationPolicy(allowedPrincipals.Value, Optional.ToList(allowedApplications));
        }
    }
}
