// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The SubscriptionNotificationOperation. </summary>
    public readonly partial struct SubscriptionNotificationOperation : IEquatable<SubscriptionNotificationOperation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SubscriptionNotificationOperation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SubscriptionNotificationOperation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotDefinedValue = "NotDefined";
        private const string DeleteAllResourcesValue = "DeleteAllResources";
        private const string SoftDeleteAllResourcesValue = "SoftDeleteAllResources";
        private const string NoOpValue = "NoOp";
        private const string BillingCancellationValue = "BillingCancellation";
        private const string UndoSoftDeleteValue = "UndoSoftDelete";

        /// <summary> NotDefined. </summary>
        public static SubscriptionNotificationOperation NotDefined { get; } = new SubscriptionNotificationOperation(NotDefinedValue);
        /// <summary> DeleteAllResources. </summary>
        public static SubscriptionNotificationOperation DeleteAllResources { get; } = new SubscriptionNotificationOperation(DeleteAllResourcesValue);
        /// <summary> SoftDeleteAllResources. </summary>
        public static SubscriptionNotificationOperation SoftDeleteAllResources { get; } = new SubscriptionNotificationOperation(SoftDeleteAllResourcesValue);
        /// <summary> NoOp. </summary>
        public static SubscriptionNotificationOperation NoOp { get; } = new SubscriptionNotificationOperation(NoOpValue);
        /// <summary> BillingCancellation. </summary>
        public static SubscriptionNotificationOperation BillingCancellation { get; } = new SubscriptionNotificationOperation(BillingCancellationValue);
        /// <summary> UndoSoftDelete. </summary>
        public static SubscriptionNotificationOperation UndoSoftDelete { get; } = new SubscriptionNotificationOperation(UndoSoftDeleteValue);
        /// <summary> Determines if two <see cref="SubscriptionNotificationOperation"/> values are the same. </summary>
        public static bool operator ==(SubscriptionNotificationOperation left, SubscriptionNotificationOperation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubscriptionNotificationOperation"/> values are not the same. </summary>
        public static bool operator !=(SubscriptionNotificationOperation left, SubscriptionNotificationOperation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SubscriptionNotificationOperation"/>. </summary>
        public static implicit operator SubscriptionNotificationOperation(string value) => new SubscriptionNotificationOperation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubscriptionNotificationOperation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubscriptionNotificationOperation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}