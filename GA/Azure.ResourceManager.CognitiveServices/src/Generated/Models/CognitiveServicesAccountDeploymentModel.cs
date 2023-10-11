// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account deployment model. </summary>
    public partial class CognitiveServicesAccountDeploymentModel
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountDeploymentModel. </summary>
        public CognitiveServicesAccountDeploymentModel()
        {
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountDeploymentModel. </summary>
        /// <param name="format"> Deployment model format. </param>
        /// <param name="name"> Deployment model name. </param>
        /// <param name="version"> Optional. Deployment model version. If version is not specified, a default version will be assigned. The default version is different for different models and might change when there is new version available for a model. Default version for a model could be found from list models API. </param>
        /// <param name="source"> Optional. Deployment model source ARM resource ID. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        internal CognitiveServicesAccountDeploymentModel(string format, string name, string version, string source, ServiceAccountCallRateLimit callRateLimit)
        {
            Format = format;
            Name = name;
            Version = version;
            Source = source;
            CallRateLimit = callRateLimit;
        }

        /// <summary> Deployment model format. </summary>
        public string Format { get; set; }
        /// <summary> Deployment model name. </summary>
        public string Name { get; set; }
        /// <summary> Optional. Deployment model version. If version is not specified, a default version will be assigned. The default version is different for different models and might change when there is new version available for a model. Default version for a model could be found from list models API. </summary>
        public string Version { get; set; }
        /// <summary> Optional. Deployment model source ARM resource ID. </summary>
        public string Source { get; set; }
        /// <summary> The call rate limit Cognitive Services account. </summary>
        public ServiceAccountCallRateLimit CallRateLimit { get; }
    }
}