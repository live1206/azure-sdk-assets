// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Type of the Health state. </summary>
    public readonly partial struct ServerEndpointOfflineDataTransferState : IEquatable<ServerEndpointOfflineDataTransferState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerEndpointOfflineDataTransferState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerEndpointOfflineDataTransferState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string StoppingValue = "Stopping";
        private const string NotRunningValue = "NotRunning";
        private const string CompleteValue = "Complete";

        /// <summary> InProgress. </summary>
        public static ServerEndpointOfflineDataTransferState InProgress { get; } = new ServerEndpointOfflineDataTransferState(InProgressValue);
        /// <summary> Stopping. </summary>
        public static ServerEndpointOfflineDataTransferState Stopping { get; } = new ServerEndpointOfflineDataTransferState(StoppingValue);
        /// <summary> NotRunning. </summary>
        public static ServerEndpointOfflineDataTransferState NotRunning { get; } = new ServerEndpointOfflineDataTransferState(NotRunningValue);
        /// <summary> Complete. </summary>
        public static ServerEndpointOfflineDataTransferState Complete { get; } = new ServerEndpointOfflineDataTransferState(CompleteValue);
        /// <summary> Determines if two <see cref="ServerEndpointOfflineDataTransferState"/> values are the same. </summary>
        public static bool operator ==(ServerEndpointOfflineDataTransferState left, ServerEndpointOfflineDataTransferState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerEndpointOfflineDataTransferState"/> values are not the same. </summary>
        public static bool operator !=(ServerEndpointOfflineDataTransferState left, ServerEndpointOfflineDataTransferState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerEndpointOfflineDataTransferState"/>. </summary>
        public static implicit operator ServerEndpointOfflineDataTransferState(string value) => new ServerEndpointOfflineDataTransferState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerEndpointOfflineDataTransferState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerEndpointOfflineDataTransferState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}