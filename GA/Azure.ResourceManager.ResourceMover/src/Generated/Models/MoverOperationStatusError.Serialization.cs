// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverOperationStatusError
    {
        internal static MoverOperationStatusError DeserializeMoverOperationStatusError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<MoverOperationStatusError>> details = default;
            Optional<IReadOnlyList<MoverOperationErrorAdditionalInfo>> additionalInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
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
                    List<MoverOperationStatusError> array = new List<MoverOperationStatusError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeMoverOperationStatusError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("additionalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        additionalInfo = null;
                        continue;
                    }
                    List<MoverOperationErrorAdditionalInfo> array = new List<MoverOperationErrorAdditionalInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverOperationErrorAdditionalInfo.DeserializeMoverOperationErrorAdditionalInfo(item));
                    }
                    additionalInfo = array;
                    continue;
                }
            }
            return new MoverOperationStatusError(code.Value, message.Value, Optional.ToList(details), Optional.ToList(additionalInfo));
        }
    }
}