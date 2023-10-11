// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing the SecurityInsightsAutomationRule data model. </summary>
    public partial class SecurityInsightsAutomationRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityInsightsAutomationRuleData. </summary>
        /// <param name="displayName"> The display name of the automation rule. </param>
        /// <param name="order"> The order of execution of the automation rule. </param>
        /// <param name="triggeringLogic"> Describes automation rule triggering logic. </param>
        /// <param name="actions">
        /// The actions to execute when the automation rule is triggered.
        /// Please note <see cref="SecurityInsightsAutomationRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutomationRuleModifyPropertiesAction"/> and <see cref="AutomationRuleRunPlaybookAction"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/>, <paramref name="triggeringLogic"/> or <paramref name="actions"/> is null. </exception>
        public SecurityInsightsAutomationRuleData(string displayName, int order, SecurityInsightsAutomationRuleTriggeringLogic triggeringLogic, IEnumerable<SecurityInsightsAutomationRuleAction> actions)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(triggeringLogic, nameof(triggeringLogic));
            Argument.AssertNotNull(actions, nameof(actions));

            DisplayName = displayName;
            Order = order;
            TriggeringLogic = triggeringLogic;
            Actions = actions.ToList();
        }

        /// <summary> Initializes a new instance of SecurityInsightsAutomationRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The display name of the automation rule. </param>
        /// <param name="order"> The order of execution of the automation rule. </param>
        /// <param name="triggeringLogic"> Describes automation rule triggering logic. </param>
        /// <param name="actions">
        /// The actions to execute when the automation rule is triggered.
        /// Please note <see cref="SecurityInsightsAutomationRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutomationRuleModifyPropertiesAction"/> and <see cref="AutomationRuleRunPlaybookAction"/>.
        /// </param>
        /// <param name="lastModifiedOn"> The last time the automation rule was updated. </param>
        /// <param name="createdOn"> The time the automation rule was created. </param>
        /// <param name="lastModifiedBy"> Information on the client (user or application) that made some action. </param>
        /// <param name="createdBy"> Information on the client (user or application) that made some action. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal SecurityInsightsAutomationRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, int order, SecurityInsightsAutomationRuleTriggeringLogic triggeringLogic, IList<SecurityInsightsAutomationRuleAction> actions, DateTimeOffset? lastModifiedOn, DateTimeOffset? createdOn, SecurityInsightsClientInfo lastModifiedBy, SecurityInsightsClientInfo createdBy, ETag? etag) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Order = order;
            TriggeringLogic = triggeringLogic;
            Actions = actions;
            LastModifiedOn = lastModifiedOn;
            CreatedOn = createdOn;
            LastModifiedBy = lastModifiedBy;
            CreatedBy = createdBy;
            ETag = etag;
        }

        /// <summary> The display name of the automation rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> The order of execution of the automation rule. </summary>
        public int Order { get; set; }
        /// <summary> Describes automation rule triggering logic. </summary>
        public SecurityInsightsAutomationRuleTriggeringLogic TriggeringLogic { get; set; }
        /// <summary>
        /// The actions to execute when the automation rule is triggered.
        /// Please note <see cref="SecurityInsightsAutomationRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutomationRuleModifyPropertiesAction"/> and <see cref="AutomationRuleRunPlaybookAction"/>.
        /// </summary>
        public IList<SecurityInsightsAutomationRuleAction> Actions { get; }
        /// <summary> The last time the automation rule was updated. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The time the automation rule was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Information on the client (user or application) that made some action. </summary>
        public SecurityInsightsClientInfo LastModifiedBy { get; }
        /// <summary> Information on the client (user or application) that made some action. </summary>
        public SecurityInsightsClientInfo CreatedBy { get; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}