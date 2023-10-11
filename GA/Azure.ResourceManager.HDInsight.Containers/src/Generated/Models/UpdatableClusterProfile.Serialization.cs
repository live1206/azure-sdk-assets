// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class UpdatableClusterProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceConfigsProfiles))
            {
                writer.WritePropertyName("serviceConfigsProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceConfigsProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SshProfile))
            {
                writer.WritePropertyName("sshProfile"u8);
                writer.WriteObjectValue(SshProfile);
            }
            if (Optional.IsDefined(AutoscaleProfile))
            {
                writer.WritePropertyName("autoscaleProfile"u8);
                writer.WriteObjectValue(AutoscaleProfile);
            }
            if (Optional.IsDefined(AuthorizationProfile))
            {
                writer.WritePropertyName("authorizationProfile"u8);
                writer.WriteObjectValue(AuthorizationProfile);
            }
            if (Optional.IsDefined(LogAnalyticsProfile))
            {
                writer.WritePropertyName("logAnalyticsProfile"u8);
                writer.WriteObjectValue(LogAnalyticsProfile);
            }
            if (Optional.IsDefined(PrometheusProfile))
            {
                writer.WritePropertyName("prometheusProfile"u8);
                writer.WriteObjectValue(PrometheusProfile);
            }
            if (Optional.IsCollectionDefined(ScriptActionProfiles))
            {
                writer.WritePropertyName("scriptActionProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActionProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static UpdatableClusterProfile DeserializeUpdatableClusterProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ClusterServiceConfigsProfile>> serviceConfigsProfiles = default;
            Optional<ClusterSshProfile> sshProfile = default;
            Optional<ClusterAutoscaleProfile> autoscaleProfile = default;
            Optional<AuthorizationProfile> authorizationProfile = default;
            Optional<ClusterLogAnalyticsProfile> logAnalyticsProfile = default;
            Optional<ClusterPrometheusProfile> prometheusProfile = default;
            Optional<IList<ScriptActionProfile>> scriptActionProfiles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceConfigsProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServiceConfigsProfile> array = new List<ClusterServiceConfigsProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServiceConfigsProfile.DeserializeClusterServiceConfigsProfile(item));
                    }
                    serviceConfigsProfiles = array;
                    continue;
                }
                if (property.NameEquals("sshProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshProfile = ClusterSshProfile.DeserializeClusterSshProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("autoscaleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleProfile = ClusterAutoscaleProfile.DeserializeClusterAutoscaleProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationProfile = AuthorizationProfile.DeserializeAuthorizationProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("logAnalyticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsProfile = ClusterLogAnalyticsProfile.DeserializeClusterLogAnalyticsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("prometheusProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusProfile = ClusterPrometheusProfile.DeserializeClusterPrometheusProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("scriptActionProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActionProfile> array = new List<ScriptActionProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActionProfile.DeserializeScriptActionProfile(item));
                    }
                    scriptActionProfiles = array;
                    continue;
                }
            }
            return new UpdatableClusterProfile(Optional.ToList(serviceConfigsProfiles), sshProfile.Value, autoscaleProfile.Value, authorizationProfile.Value, logAnalyticsProfile.Value, prometheusProfile.Value, Optional.ToList(scriptActionProfiles));
        }
    }
}