// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessRequestInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("virtualMachines"u8);
            writer.WriteStartArray();
            foreach (var item in VirtualMachines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("startTimeUtc"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("requestor"u8);
            writer.WriteStringValue(Requestor);
            if (Optional.IsDefined(Justification))
            {
                writer.WritePropertyName("justification"u8);
                writer.WriteStringValue(Justification);
            }
            writer.WriteEndObject();
        }

        internal static JitNetworkAccessRequestInfo DeserializeJitNetworkAccessRequestInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<JitNetworkAccessRequestVirtualMachine> virtualMachines = default;
            DateTimeOffset startTimeUtc = default;
            string requestor = default;
            Optional<string> justification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachines"u8))
                {
                    List<JitNetworkAccessRequestVirtualMachine> array = new List<JitNetworkAccessRequestVirtualMachine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JitNetworkAccessRequestVirtualMachine.DeserializeJitNetworkAccessRequestVirtualMachine(item));
                    }
                    virtualMachines = array;
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("requestor"u8))
                {
                    requestor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
            }
            return new JitNetworkAccessRequestInfo(virtualMachines, startTimeUtc, requestor, justification.Value);
        }
    }
}