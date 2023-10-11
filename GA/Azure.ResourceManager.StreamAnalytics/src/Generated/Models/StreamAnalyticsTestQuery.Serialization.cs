// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsTestQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("streamingJob"u8);
            writer.WriteObjectValue(StreamingJob);
            writer.WritePropertyName("diagnostics"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WriteUri))
            {
                writer.WritePropertyName("writeUri"u8);
                writer.WriteStringValue(WriteUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
