// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class CustomerDiskJobSecrets
    {
        internal static CustomerDiskJobSecrets DeserializeCustomerDiskJobSecrets(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxDiskSecret>> diskSecrets = default;
            Optional<string> carrierAccountNumber = default;
            DataBoxOrderType jobSecretsType = default;
            Optional<DataCenterAccessSecurityCode> dcAccessSecurityCode = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxDiskSecret> array = new List<DataBoxDiskSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxDiskSecret.DeserializeDataBoxDiskSecret(item));
                    }
                    diskSecrets = array;
                    continue;
                }
                if (property.NameEquals("carrierAccountNumber"u8))
                {
                    carrierAccountNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new CustomerDiskJobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value, Optional.ToList(diskSecrets), carrierAccountNumber.Value);
        }
    }
}
