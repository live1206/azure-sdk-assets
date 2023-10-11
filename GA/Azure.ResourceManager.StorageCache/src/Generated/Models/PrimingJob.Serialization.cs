// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class PrimingJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("primingJobName"u8);
            writer.WriteStringValue(PrimingJobName);
            writer.WritePropertyName("primingManifestUrl"u8);
            writer.WriteStringValue(PrimingManifestUri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static PrimingJob DeserializePrimingJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primingJobName = default;
            Uri primingManifestUrl = default;
            Optional<string> primingJobId = default;
            Optional<PrimingJobState> primingJobState = default;
            Optional<string> primingJobStatus = default;
            Optional<string> primingJobDetails = default;
            Optional<double> primingJobPercentComplete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primingJobName"u8))
                {
                    primingJobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primingManifestUrl"u8))
                {
                    primingManifestUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primingJobId"u8))
                {
                    primingJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primingJobState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primingJobState = new PrimingJobState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primingJobStatus"u8))
                {
                    primingJobStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primingJobDetails"u8))
                {
                    primingJobDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primingJobPercentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primingJobPercentComplete = property.Value.GetDouble();
                    continue;
                }
            }
            return new PrimingJob(primingJobName, primingManifestUrl, primingJobId.Value, Optional.ToNullable(primingJobState), primingJobStatus.Value, primingJobDetails.Value, Optional.ToNullable(primingJobPercentComplete));
        }
    }
}