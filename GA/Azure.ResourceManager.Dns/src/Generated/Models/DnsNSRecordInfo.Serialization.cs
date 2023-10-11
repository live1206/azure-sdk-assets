// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class DnsNSRecordInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DnsNSDomainName))
            {
                writer.WritePropertyName("nsdname"u8);
                writer.WriteStringValue(DnsNSDomainName);
            }
            writer.WriteEndObject();
        }

        internal static DnsNSRecordInfo DeserializeDnsNSRecordInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nsdname = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nsdname"u8))
                {
                    nsdname = property.Value.GetString();
                    continue;
                }
            }
            return new DnsNSRecordInfo(nsdname.Value);
        }
    }
}