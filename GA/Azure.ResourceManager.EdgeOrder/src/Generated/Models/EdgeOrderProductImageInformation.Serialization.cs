// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProductImageInformation
    {
        internal static EdgeOrderProductImageInformation DeserializeEdgeOrderProductImageInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeOrderProductImageType> imageType = default;
            Optional<Uri> imageUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageType = new EdgeOrderProductImageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("imageUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new EdgeOrderProductImageInformation(Optional.ToNullable(imageType), imageUrl.Value);
        }
    }
}