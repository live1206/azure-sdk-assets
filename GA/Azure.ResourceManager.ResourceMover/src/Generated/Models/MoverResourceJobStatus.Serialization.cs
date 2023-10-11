// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceJobStatus
    {
        internal static MoverResourceJobStatus DeserializeMoverResourceJobStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MoverResourceJobName> jobName = default;
            Optional<string> jobProgress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobName = new MoverResourceJobName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobProgress"u8))
                {
                    jobProgress = property.Value.GetString();
                    continue;
                }
            }
            return new MoverResourceJobStatus(Optional.ToNullable(jobName), jobProgress.Value);
        }
    }
}
