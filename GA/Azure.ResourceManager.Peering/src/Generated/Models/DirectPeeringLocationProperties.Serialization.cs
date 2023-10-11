// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class DirectPeeringLocationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PeeringFacilities))
            {
                writer.WritePropertyName("peeringFacilities"u8);
                writer.WriteStartArray();
                foreach (var item in PeeringFacilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BandwidthOffers))
            {
                writer.WritePropertyName("bandwidthOffers"u8);
                writer.WriteStartArray();
                foreach (var item in BandwidthOffers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DirectPeeringLocationProperties DeserializeDirectPeeringLocationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DirectPeeringFacility>> peeringFacilities = default;
            Optional<IList<PeeringBandwidthOffer>> bandwidthOffers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringFacilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DirectPeeringFacility> array = new List<DirectPeeringFacility>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DirectPeeringFacility.DeserializeDirectPeeringFacility(item));
                    }
                    peeringFacilities = array;
                    continue;
                }
                if (property.NameEquals("bandwidthOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringBandwidthOffer> array = new List<PeeringBandwidthOffer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringBandwidthOffer.DeserializePeeringBandwidthOffer(item));
                    }
                    bandwidthOffers = array;
                    continue;
                }
            }
            return new DirectPeeringLocationProperties(Optional.ToList(peeringFacilities), Optional.ToList(bandwidthOffers));
        }
    }
}