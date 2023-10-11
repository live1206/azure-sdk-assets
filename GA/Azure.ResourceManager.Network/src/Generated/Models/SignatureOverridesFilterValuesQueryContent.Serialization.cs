// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class SignatureOverridesFilterValuesQueryContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FilterName))
            {
                writer.WritePropertyName("filterName"u8);
                writer.WriteStringValue(FilterName);
            }
            writer.WriteEndObject();
        }
    }
}