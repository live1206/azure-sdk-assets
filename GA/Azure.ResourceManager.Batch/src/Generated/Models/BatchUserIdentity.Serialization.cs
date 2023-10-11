// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchUserIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(AutoUser))
            {
                writer.WritePropertyName("autoUser"u8);
                writer.WriteObjectValue(AutoUser);
            }
            writer.WriteEndObject();
        }

        internal static BatchUserIdentity DeserializeBatchUserIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> userName = default;
            Optional<BatchAutoUserSpecification> autoUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUser = BatchAutoUserSpecification.DeserializeBatchAutoUserSpecification(property.Value);
                    continue;
                }
            }
            return new BatchUserIdentity(userName.Value, autoUser.Value);
        }
    }
}