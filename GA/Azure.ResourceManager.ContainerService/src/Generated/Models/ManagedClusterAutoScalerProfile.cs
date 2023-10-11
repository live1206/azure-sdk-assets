// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Parameters to be applied to the cluster-autoscaler when enabled. </summary>
    public partial class ManagedClusterAutoScalerProfile
    {
        /// <summary> Initializes a new instance of ManagedClusterAutoScalerProfile. </summary>
        public ManagedClusterAutoScalerProfile()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterAutoScalerProfile. </summary>
        /// <param name="balanceSimilarNodeGroups"> Valid values are 'true' and 'false'. </param>
        /// <param name="expander"> If not specified, the default is 'random'. See [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more information. </param>
        /// <param name="maxEmptyBulkDelete"> The default is 10. </param>
        /// <param name="maxGracefulTerminationSec"> The default is 600. </param>
        /// <param name="maxNodeProvisionTime"> The default is '15m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="maxTotalUnreadyPercentage"> The default is 45. The maximum is 100 and the minimum is 0. </param>
        /// <param name="newPodScaleUpDelay"> For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. The default is '0s'. Values must be an integer followed by a unit ('s' for seconds, 'm' for minutes, 'h' for hours, etc). </param>
        /// <param name="okTotalUnreadyCount"> This must be an integer. The default is 3. </param>
        /// <param name="scanIntervalInSeconds"> The default is '10'. Values must be an integer number of seconds. </param>
        /// <param name="scaleDownDelayAfterAdd"> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownDelayAfterDelete"> The default is the scan-interval. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownDelayAfterFailure"> The default is '3m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownUnneededTime"> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownUnreadyTime"> The default is '20m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownUtilizationThreshold"> The default is '0.5'. </param>
        /// <param name="skipNodesWithLocalStorage"> The default is true. </param>
        /// <param name="skipNodesWithSystemPods"> The default is true. </param>
        internal ManagedClusterAutoScalerProfile(string balanceSimilarNodeGroups, AutoScaleExpander? expander, string maxEmptyBulkDelete, string maxGracefulTerminationSec, string maxNodeProvisionTime, string maxTotalUnreadyPercentage, string newPodScaleUpDelay, string okTotalUnreadyCount, string scanIntervalInSeconds, string scaleDownDelayAfterAdd, string scaleDownDelayAfterDelete, string scaleDownDelayAfterFailure, string scaleDownUnneededTime, string scaleDownUnreadyTime, string scaleDownUtilizationThreshold, string skipNodesWithLocalStorage, string skipNodesWithSystemPods)
        {
            BalanceSimilarNodeGroups = balanceSimilarNodeGroups;
            Expander = expander;
            MaxEmptyBulkDelete = maxEmptyBulkDelete;
            MaxGracefulTerminationSec = maxGracefulTerminationSec;
            MaxNodeProvisionTime = maxNodeProvisionTime;
            MaxTotalUnreadyPercentage = maxTotalUnreadyPercentage;
            NewPodScaleUpDelay = newPodScaleUpDelay;
            OkTotalUnreadyCount = okTotalUnreadyCount;
            ScanIntervalInSeconds = scanIntervalInSeconds;
            ScaleDownDelayAfterAdd = scaleDownDelayAfterAdd;
            ScaleDownDelayAfterDelete = scaleDownDelayAfterDelete;
            ScaleDownDelayAfterFailure = scaleDownDelayAfterFailure;
            ScaleDownUnneededTime = scaleDownUnneededTime;
            ScaleDownUnreadyTime = scaleDownUnreadyTime;
            ScaleDownUtilizationThreshold = scaleDownUtilizationThreshold;
            SkipNodesWithLocalStorage = skipNodesWithLocalStorage;
            SkipNodesWithSystemPods = skipNodesWithSystemPods;
        }

        /// <summary> Valid values are 'true' and 'false'. </summary>
        public string BalanceSimilarNodeGroups { get; set; }
        /// <summary> If not specified, the default is 'random'. See [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more information. </summary>
        public AutoScaleExpander? Expander { get; set; }
        /// <summary> The default is 10. </summary>
        public string MaxEmptyBulkDelete { get; set; }
        /// <summary> The default is 600. </summary>
        public string MaxGracefulTerminationSec { get; set; }
        /// <summary> The default is '15m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        public string MaxNodeProvisionTime { get; set; }
        /// <summary> The default is 45. The maximum is 100 and the minimum is 0. </summary>
        public string MaxTotalUnreadyPercentage { get; set; }
        /// <summary> For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. The default is '0s'. Values must be an integer followed by a unit ('s' for seconds, 'm' for minutes, 'h' for hours, etc). </summary>
        public string NewPodScaleUpDelay { get; set; }
        /// <summary> This must be an integer. The default is 3. </summary>
        public string OkTotalUnreadyCount { get; set; }
        /// <summary> The default is '10'. Values must be an integer number of seconds. </summary>
        public string ScanIntervalInSeconds { get; set; }
        /// <summary> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        public string ScaleDownDelayAfterAdd { get; set; }
        /// <summary> The default is the scan-interval. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        public string ScaleDownDelayAfterDelete { get; set; }
        /// <summary> The default is '3m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        public string ScaleDownDelayAfterFailure { get; set; }
        /// <summary> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        public string ScaleDownUnneededTime { get; set; }
        /// <summary> The default is '20m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        public string ScaleDownUnreadyTime { get; set; }
        /// <summary> The default is '0.5'. </summary>
        public string ScaleDownUtilizationThreshold { get; set; }
        /// <summary> The default is true. </summary>
        public string SkipNodesWithLocalStorage { get; set; }
        /// <summary> The default is true. </summary>
        public string SkipNodesWithSystemPods { get; set; }
    }
}