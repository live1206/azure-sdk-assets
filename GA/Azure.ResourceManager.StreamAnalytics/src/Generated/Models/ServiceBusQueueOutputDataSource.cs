// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a Service Bus Queue output data source. </summary>
    public partial class ServiceBusQueueOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of ServiceBusQueueOutputDataSource. </summary>
        public ServiceBusQueueOutputDataSource()
        {
            PropertyColumns = new ChangeTrackingList<string>();
            SystemPropertyColumns = new ChangeTrackingDictionary<string, string>();
            OutputDataSourceType = "Microsoft.ServiceBus/Queue";
        }

        /// <summary> Initializes a new instance of ServiceBusQueueOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serviceBusNamespace"> The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="sharedAccessPolicyName"> The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="sharedAccessPolicyKey"> The shared access policy key for the specified shared access policy. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        /// <param name="queueName"> The name of the Service Bus Queue. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="propertyColumns"> A string array of the names of output columns to be attached to Service Bus messages as custom properties. </param>
        /// <param name="systemPropertyColumns"> The system properties associated with the Service Bus Queue. The following system properties are supported: ReplyToSessionId, ContentType, To, Subject, CorrelationId, TimeToLive, PartitionKey, SessionId, ScheduledEnqueueTime, MessageId, ReplyTo, Label, ScheduledEnqueueTimeUtc. </param>
        internal ServiceBusQueueOutputDataSource(string outputDataSourceType, string serviceBusNamespace, string sharedAccessPolicyName, string sharedAccessPolicyKey, StreamAnalyticsAuthenticationMode? authenticationMode, string queueName, IList<string> propertyColumns, IDictionary<string, string> systemPropertyColumns) : base(outputDataSourceType)
        {
            ServiceBusNamespace = serviceBusNamespace;
            SharedAccessPolicyName = sharedAccessPolicyName;
            SharedAccessPolicyKey = sharedAccessPolicyKey;
            AuthenticationMode = authenticationMode;
            QueueName = queueName;
            PropertyColumns = propertyColumns;
            SystemPropertyColumns = systemPropertyColumns;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.ServiceBus/Queue";
        }

        /// <summary> The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </summary>
        public string ServiceBusNamespace { get; set; }
        /// <summary> The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </summary>
        public string SharedAccessPolicyName { get; set; }
        /// <summary> The shared access policy key for the specified shared access policy. Required on PUT (CreateOrReplace) requests. </summary>
        public string SharedAccessPolicyKey { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
        /// <summary> The name of the Service Bus Queue. Required on PUT (CreateOrReplace) requests. </summary>
        public string QueueName { get; set; }
        /// <summary> A string array of the names of output columns to be attached to Service Bus messages as custom properties. </summary>
        public IList<string> PropertyColumns { get; }
        /// <summary> The system properties associated with the Service Bus Queue. The following system properties are supported: ReplyToSessionId, ContentType, To, Subject, CorrelationId, TimeToLive, PartitionKey, SessionId, ScheduledEnqueueTime, MessageId, ReplyTo, Label, ScheduledEnqueueTimeUtc. </summary>
        public IDictionary<string, string> SystemPropertyColumns { get; }
    }
}