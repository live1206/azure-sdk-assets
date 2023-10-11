// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderResourceType
    {
        internal static ProviderResourceType DeserializeProviderResourceType(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceRoutingType> routingType = default;
            Optional<ResourceValidation> resourceValidation = default;
            Optional<IReadOnlyList<string>> allowedUnauthorizedActions = default;
            Optional<IReadOnlyList<AuthorizationActionMapping>> authorizationActionMappings = default;
            Optional<IReadOnlyList<LinkedAccessCheck>> linkedAccessChecks = default;
            Optional<string> defaultApiVersion = default;
            Optional<IReadOnlyList<LoggingRule>> loggingRules = default;
            Optional<IReadOnlyList<ThrottlingRule>> throttlingRules = default;
            Optional<IReadOnlyList<ResourceProviderEndpoint>> endpoints = default;
            Optional<MarketplaceType> marketplaceType = default;
            Optional<IdentityManagement> identityManagement = default;
            Optional<BinaryData> metadata = default;
            Optional<IReadOnlyList<string>> requiredFeatures = default;
            Optional<FeaturesRule> featuresRule = default;
            Optional<IReadOnlyList<ProviderSubscriptionStateRule>> subscriptionStateRules = default;
            Optional<IReadOnlyList<ServiceTreeInfo>> serviceTreeInfos = default;
            Optional<RequestHeaderOptions> requestHeaderOptions = default;
            Optional<string> skuLink = default;
            Optional<IReadOnlyList<string>> disallowedActionVerbs = default;
            Optional<TemplateDeploymentPolicy> templateDeploymentPolicy = default;
            Optional<IReadOnlyList<ProviderHubExtendedLocationOptions>> extendedLocations = default;
            Optional<IReadOnlyList<LinkedOperationRule>> linkedOperationRules = default;
            Optional<ManifestResourceDeletionPolicy> resourceDeletionPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingType = new ResourceRoutingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceValidation = new ResourceValidation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedUnauthorizedActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedUnauthorizedActions = array;
                    continue;
                }
                if (property.NameEquals("authorizationActionMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuthorizationActionMapping> array = new List<AuthorizationActionMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationActionMapping.DeserializeAuthorizationActionMapping(item));
                    }
                    authorizationActionMappings = array;
                    continue;
                }
                if (property.NameEquals("linkedAccessChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedAccessCheck> array = new List<LinkedAccessCheck>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedAccessCheck.DeserializeLinkedAccessCheck(item));
                    }
                    linkedAccessChecks = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoggingRule> array = new List<LoggingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoggingRule.DeserializeLoggingRule(item));
                    }
                    loggingRules = array;
                    continue;
                }
                if (property.NameEquals("throttlingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThrottlingRule> array = new List<ThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThrottlingRule.DeserializeThrottlingRule(item));
                    }
                    throttlingRules = array;
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderEndpoint> array = new List<ResourceProviderEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderEndpoint.DeserializeResourceProviderEndpoint(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("marketplaceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceType = property.Value.GetString().ToMarketplaceType();
                    continue;
                }
                if (property.NameEquals("identityManagement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityManagement = IdentityManagement.DeserializeIdentityManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("subscriptionStateRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderSubscriptionStateRule> array = new List<ProviderSubscriptionStateRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderSubscriptionStateRule.DeserializeProviderSubscriptionStateRule(item));
                    }
                    subscriptionStateRules = array;
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("skuLink"u8))
                {
                    skuLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disallowedActionVerbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    disallowedActionVerbs = array;
                    continue;
                }
                if (property.NameEquals("templateDeploymentPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentPolicy = TemplateDeploymentPolicy.DeserializeTemplateDeploymentPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderHubExtendedLocationOptions> array = new List<ProviderHubExtendedLocationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderHubExtendedLocationOptions.DeserializeProviderHubExtendedLocationOptions(item));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("linkedOperationRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedOperationRule> array = new List<LinkedOperationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedOperationRule.DeserializeLinkedOperationRule(item));
                    }
                    linkedOperationRules = array;
                    continue;
                }
                if (property.NameEquals("resourceDeletionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceDeletionPolicy = new ManifestResourceDeletionPolicy(property.Value.GetString());
                    continue;
                }
            }
            return new ProviderResourceType(name.Value, Optional.ToNullable(routingType), Optional.ToNullable(resourceValidation), Optional.ToList(allowedUnauthorizedActions), Optional.ToList(authorizationActionMappings), Optional.ToList(linkedAccessChecks), defaultApiVersion.Value, Optional.ToList(loggingRules), Optional.ToList(throttlingRules), Optional.ToList(endpoints), Optional.ToNullable(marketplaceType), identityManagement.Value, metadata.Value, Optional.ToList(requiredFeatures), featuresRule.Value, Optional.ToList(subscriptionStateRules), Optional.ToList(serviceTreeInfos), requestHeaderOptions.Value, skuLink.Value, Optional.ToList(disallowedActionVerbs), templateDeploymentPolicy.Value, Optional.ToList(extendedLocations), Optional.ToList(linkedOperationRules), Optional.ToNullable(resourceDeletionPolicy));
        }
    }
}