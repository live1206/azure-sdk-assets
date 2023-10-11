// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class B2BPartnerContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BusinessIdentities))
            {
                writer.WritePropertyName("businessIdentities"u8);
                writer.WriteStartArray();
                foreach (var item in BusinessIdentities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static B2BPartnerContent DeserializeB2BPartnerContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<IntegrationAccountBusinessIdentity>> businessIdentities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("businessIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntegrationAccountBusinessIdentity> array = new List<IntegrationAccountBusinessIdentity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(item));
                    }
                    businessIdentities = array;
                    continue;
                }
            }
            return new B2BPartnerContent(Optional.ToList(businessIdentities));
        }
    }
}