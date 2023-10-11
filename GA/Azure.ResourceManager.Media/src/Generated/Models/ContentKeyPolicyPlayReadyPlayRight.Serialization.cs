// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyPlayRight : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FirstPlayExpiration))
            {
                writer.WritePropertyName("firstPlayExpiration"u8);
                writer.WriteStringValue(FirstPlayExpiration.Value, "P");
            }
            if (Optional.IsDefined(ScmsRestriction))
            {
                writer.WritePropertyName("scmsRestriction"u8);
                writer.WriteNumberValue(ScmsRestriction.Value);
            }
            if (Optional.IsDefined(AgcAndColorStripeRestriction))
            {
                writer.WritePropertyName("agcAndColorStripeRestriction"u8);
                writer.WriteNumberValue(AgcAndColorStripeRestriction.Value);
            }
            if (Optional.IsDefined(ExplicitAnalogTelevisionOutputRestriction))
            {
                writer.WritePropertyName("explicitAnalogTelevisionOutputRestriction"u8);
                writer.WriteObjectValue(ExplicitAnalogTelevisionOutputRestriction);
            }
            writer.WritePropertyName("digitalVideoOnlyContentRestriction"u8);
            writer.WriteBooleanValue(HasDigitalVideoOnlyContentRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComponentVideoRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComponentVideoRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComputerMonitorRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComputerMonitorRestriction);
            writer.WritePropertyName("allowPassingVideoContentToUnknownOutput"u8);
            writer.WriteStringValue(AllowPassingVideoContentToUnknownOutput.ToString());
            if (Optional.IsDefined(UncompressedDigitalVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("uncompressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(CompressedDigitalVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("compressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(CompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(AnalogVideoOutputProtectionLevel))
            {
                writer.WritePropertyName("analogVideoOpl"u8);
                writer.WriteNumberValue(AnalogVideoOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(CompressedDigitalAudioOutputProtectionLevel))
            {
                writer.WritePropertyName("compressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(CompressedDigitalAudioOutputProtectionLevel.Value);
            }
            if (Optional.IsDefined(UncompressedDigitalAudioOutputProtectionLevel))
            {
                writer.WritePropertyName("uncompressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalAudioOutputProtectionLevel.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContentKeyPolicyPlayReadyPlayRight DeserializeContentKeyPolicyPlayReadyPlayRight(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> firstPlayExpiration = default;
            Optional<int> scmsRestriction = default;
            Optional<int> agcAndColorStripeRestriction = default;
            Optional<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction> explicitAnalogTelevisionOutputRestriction = default;
            bool digitalVideoOnlyContentRestriction = default;
            bool imageConstraintForAnalogComponentVideoRestriction = default;
            bool imageConstraintForAnalogComputerMonitorRestriction = default;
            ContentKeyPolicyPlayReadyUnknownOutputPassingOption allowPassingVideoContentToUnknownOutput = default;
            Optional<int> uncompressedDigitalVideoOpl = default;
            Optional<int> compressedDigitalVideoOpl = default;
            Optional<int> analogVideoOpl = default;
            Optional<int> compressedDigitalAudioOpl = default;
            Optional<int> uncompressedDigitalAudioOpl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstPlayExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstPlayExpiration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("scmsRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scmsRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agcAndColorStripeRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agcAndColorStripeRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("explicitAnalogTelevisionOutputRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    explicitAnalogTelevisionOutputRestriction = ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction.DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(property.Value);
                    continue;
                }
                if (property.NameEquals("digitalVideoOnlyContentRestriction"u8))
                {
                    digitalVideoOnlyContentRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComponentVideoRestriction"u8))
                {
                    imageConstraintForAnalogComponentVideoRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComputerMonitorRestriction"u8))
                {
                    imageConstraintForAnalogComputerMonitorRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPassingVideoContentToUnknownOutput"u8))
                {
                    allowPassingVideoContentToUnknownOutput = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("analogVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analogVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
            }
            return new ContentKeyPolicyPlayReadyPlayRight(Optional.ToNullable(firstPlayExpiration), Optional.ToNullable(scmsRestriction), Optional.ToNullable(agcAndColorStripeRestriction), explicitAnalogTelevisionOutputRestriction.Value, digitalVideoOnlyContentRestriction, imageConstraintForAnalogComponentVideoRestriction, imageConstraintForAnalogComputerMonitorRestriction, allowPassingVideoContentToUnknownOutput, Optional.ToNullable(uncompressedDigitalVideoOpl), Optional.ToNullable(compressedDigitalVideoOpl), Optional.ToNullable(analogVideoOpl), Optional.ToNullable(compressedDigitalAudioOpl), Optional.ToNullable(uncompressedDigitalAudioOpl));
        }
    }
}
