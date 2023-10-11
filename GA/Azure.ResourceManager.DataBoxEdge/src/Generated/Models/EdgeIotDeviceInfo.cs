// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Metadata of IoT device/IoT Edge device to be configured. </summary>
    public partial class EdgeIotDeviceInfo
    {
        /// <summary> Initializes a new instance of EdgeIotDeviceInfo. </summary>
        /// <param name="deviceId"> ID of the IoT device/edge device. </param>
        /// <param name="iotHostHub"> Host name for the IoT hub associated to the device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/> or <paramref name="iotHostHub"/> is null. </exception>
        public EdgeIotDeviceInfo(string deviceId, string iotHostHub)
        {
            Argument.AssertNotNull(deviceId, nameof(deviceId));
            Argument.AssertNotNull(iotHostHub, nameof(iotHostHub));

            DeviceId = deviceId;
            IotHostHub = iotHostHub;
        }

        /// <summary> Initializes a new instance of EdgeIotDeviceInfo. </summary>
        /// <param name="deviceId"> ID of the IoT device/edge device. </param>
        /// <param name="iotHostHub"> Host name for the IoT hub associated to the device. </param>
        /// <param name="iotHostHubId"> Id for the IoT hub associated to the device. </param>
        /// <param name="authentication"> Encrypted IoT device/IoT edge device connection string. </param>
        internal EdgeIotDeviceInfo(string deviceId, string iotHostHub, ResourceIdentifier iotHostHubId, Authentication authentication)
        {
            DeviceId = deviceId;
            IotHostHub = iotHostHub;
            IotHostHubId = iotHostHubId;
            Authentication = authentication;
        }

        /// <summary> ID of the IoT device/edge device. </summary>
        public string DeviceId { get; set; }
        /// <summary> Host name for the IoT hub associated to the device. </summary>
        public string IotHostHub { get; set; }
        /// <summary> Id for the IoT hub associated to the device. </summary>
        public ResourceIdentifier IotHostHubId { get; set; }
        /// <summary> Encrypted IoT device/IoT edge device connection string. </summary>
        internal Authentication Authentication { get; set; }
        /// <summary> Connection string based on the symmetric key. </summary>
        public AsymmetricEncryptedSecret SymmetricKeyConnectionString
        {
            get => Authentication is null ? default : Authentication.SymmetricKeyConnectionString;
            set
            {
                if (Authentication is null)
                    Authentication = new Authentication();
                Authentication.SymmetricKeyConnectionString = value;
            }
        }
    }
}