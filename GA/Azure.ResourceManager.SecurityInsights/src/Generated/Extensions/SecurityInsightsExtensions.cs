// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.SecurityInsights. </summary>
    public static partial class SecurityInsightsExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }
        #region SecurityInsightsAlertRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleResource" /> object. </returns>
        public static SecurityInsightsAlertRuleResource GetSecurityInsightsAlertRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsAlertRuleResource.ValidateResourceId(id);
                return new SecurityInsightsAlertRuleResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsAlertRuleActionResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleActionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleActionResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleActionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleActionResource" /> object. </returns>
        public static SecurityInsightsAlertRuleActionResource GetSecurityInsightsAlertRuleActionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsAlertRuleActionResource.ValidateResourceId(id);
                return new SecurityInsightsAlertRuleActionResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsAlertRuleTemplateResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleTemplateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleTemplateResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleTemplateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleTemplateResource" /> object. </returns>
        public static SecurityInsightsAlertRuleTemplateResource GetSecurityInsightsAlertRuleTemplateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsAlertRuleTemplateResource.ValidateResourceId(id);
                return new SecurityInsightsAlertRuleTemplateResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsAutomationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAutomationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAutomationRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAutomationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAutomationRuleResource" /> object. </returns>
        public static SecurityInsightsAutomationRuleResource GetSecurityInsightsAutomationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsAutomationRuleResource.ValidateResourceId(id);
                return new SecurityInsightsAutomationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsBookmarkResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsBookmarkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsBookmarkResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsBookmarkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsBookmarkResource" /> object. </returns>
        public static SecurityInsightsBookmarkResource GetSecurityInsightsBookmarkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsBookmarkResource.ValidateResourceId(id);
                return new SecurityInsightsBookmarkResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsDataConnectorResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsDataConnectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsDataConnectorResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsDataConnectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsDataConnectorResource" /> object. </returns>
        public static SecurityInsightsDataConnectorResource GetSecurityInsightsDataConnectorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsDataConnectorResource.ValidateResourceId(id);
                return new SecurityInsightsDataConnectorResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsIncidentResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentResource" /> object. </returns>
        public static SecurityInsightsIncidentResource GetSecurityInsightsIncidentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsIncidentResource.ValidateResourceId(id);
                return new SecurityInsightsIncidentResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsIncidentCommentResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentCommentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentCommentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentCommentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentCommentResource" /> object. </returns>
        public static SecurityInsightsIncidentCommentResource GetSecurityInsightsIncidentCommentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsIncidentCommentResource.ValidateResourceId(id);
                return new SecurityInsightsIncidentCommentResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsIncidentRelationResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentRelationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentRelationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentRelationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentRelationResource" /> object. </returns>
        public static SecurityInsightsIncidentRelationResource GetSecurityInsightsIncidentRelationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsIncidentRelationResource.ValidateResourceId(id);
                return new SecurityInsightsIncidentRelationResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsSentinelOnboardingStateResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsSentinelOnboardingStateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsSentinelOnboardingStateResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsSentinelOnboardingStateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsSentinelOnboardingStateResource" /> object. </returns>
        public static SecurityInsightsSentinelOnboardingStateResource GetSecurityInsightsSentinelOnboardingStateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsSentinelOnboardingStateResource.ValidateResourceId(id);
                return new SecurityInsightsSentinelOnboardingStateResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityMLAnalyticsSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityMLAnalyticsSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityMLAnalyticsSettingResource.CreateResourceIdentifier" /> to create a <see cref="SecurityMLAnalyticsSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityMLAnalyticsSettingResource" /> object. </returns>
        public static SecurityMLAnalyticsSettingResource GetSecurityMLAnalyticsSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityMLAnalyticsSettingResource.ValidateResourceId(id);
                return new SecurityMLAnalyticsSettingResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsThreatIntelligenceIndicatorResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> object. </returns>
        public static SecurityInsightsThreatIntelligenceIndicatorResource GetSecurityInsightsThreatIntelligenceIndicatorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsThreatIntelligenceIndicatorResource.ValidateResourceId(id);
                return new SecurityInsightsThreatIntelligenceIndicatorResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsWatchlistResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsWatchlistResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsWatchlistResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsWatchlistResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsWatchlistResource" /> object. </returns>
        public static SecurityInsightsWatchlistResource GetSecurityInsightsWatchlistResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsWatchlistResource.ValidateResourceId(id);
                return new SecurityInsightsWatchlistResource(client, id);
            }
            );
        }
        #endregion

        #region SecurityInsightsWatchlistItemResource
        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsWatchlistItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsWatchlistItemResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsWatchlistItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsWatchlistItemResource" /> object. </returns>
        public static SecurityInsightsWatchlistItemResource GetSecurityInsightsWatchlistItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SecurityInsightsWatchlistItemResource.ValidateResourceId(id);
                return new SecurityInsightsWatchlistItemResource(client, id);
            }
            );
        }
        #endregion

        #region OperationalInsightsWorkspaceSecurityInsightsResource
        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> object. </returns>
        public static OperationalInsightsWorkspaceSecurityInsightsResource GetOperationalInsightsWorkspaceSecurityInsightsResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OperationalInsightsWorkspaceSecurityInsightsResource.ValidateResourceId(id);
                return new OperationalInsightsWorkspaceSecurityInsightsResource(client, id);
            }
            );
        }
        #endregion
    }
}