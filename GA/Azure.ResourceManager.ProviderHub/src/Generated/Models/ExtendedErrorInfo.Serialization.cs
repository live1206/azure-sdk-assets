// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ExtendedErrorInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalInfo))
            {
                writer.WritePropertyName("additionalInfo"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ExtendedErrorInfo DeserializeExtendedErrorInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> target = default;
            Optional<string> message = default;
            Optional<IList<ExtendedErrorInfo>> details = default;
            Optional<IList<TypedErrorInfo>> additionalInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtendedErrorInfo> array = new List<ExtendedErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeExtendedErrorInfo(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("additionalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TypedErrorInfo> array = new List<TypedErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypedErrorInfo.DeserializeTypedErrorInfo(item));
                    }
                    additionalInfo = array;
                    continue;
                }
            }
            return new ExtendedErrorInfo(code.Value, target.Value, message.Value, Optional.ToList(details), Optional.ToList(additionalInfo));
        }
    }
}
