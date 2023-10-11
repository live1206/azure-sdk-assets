// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StartStreamingJobContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OutputStartMode))
            {
                writer.WritePropertyName("outputStartMode"u8);
                writer.WriteStringValue(OutputStartMode.Value.ToString());
            }
            if (Optional.IsDefined(OutputStartOn))
            {
                writer.WritePropertyName("outputStartTime"u8);
                writer.WriteStringValue(OutputStartOn.Value, "O");
            }
            writer.WriteEndObject();
        }
    }
}
