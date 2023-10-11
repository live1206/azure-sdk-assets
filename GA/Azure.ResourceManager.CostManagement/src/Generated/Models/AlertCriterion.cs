// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Criteria that triggered alert. </summary>
    public readonly partial struct AlertCriterion : IEquatable<AlertCriterion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertCriterion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertCriterion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CostThresholdExceededValue = "CostThresholdExceeded";
        private const string UsageThresholdExceededValue = "UsageThresholdExceeded";
        private const string CreditThresholdApproachingValue = "CreditThresholdApproaching";
        private const string CreditThresholdReachedValue = "CreditThresholdReached";
        private const string QuotaThresholdApproachingValue = "QuotaThresholdApproaching";
        private const string QuotaThresholdReachedValue = "QuotaThresholdReached";
        private const string MultiCurrencyValue = "MultiCurrency";
        private const string ForecastCostThresholdExceededValue = "ForecastCostThresholdExceeded";
        private const string ForecastUsageThresholdExceededValue = "ForecastUsageThresholdExceeded";
        private const string InvoiceDueDateApproachingValue = "InvoiceDueDateApproaching";
        private const string InvoiceDueDateReachedValue = "InvoiceDueDateReached";
        private const string CrossCloudNewDataAvailableValue = "CrossCloudNewDataAvailable";
        private const string CrossCloudCollectionErrorValue = "CrossCloudCollectionError";
        private const string GeneralThresholdErrorValue = "GeneralThresholdError";

        /// <summary> CostThresholdExceeded. </summary>
        public static AlertCriterion CostThresholdExceeded { get; } = new AlertCriterion(CostThresholdExceededValue);
        /// <summary> UsageThresholdExceeded. </summary>
        public static AlertCriterion UsageThresholdExceeded { get; } = new AlertCriterion(UsageThresholdExceededValue);
        /// <summary> CreditThresholdApproaching. </summary>
        public static AlertCriterion CreditThresholdApproaching { get; } = new AlertCriterion(CreditThresholdApproachingValue);
        /// <summary> CreditThresholdReached. </summary>
        public static AlertCriterion CreditThresholdReached { get; } = new AlertCriterion(CreditThresholdReachedValue);
        /// <summary> QuotaThresholdApproaching. </summary>
        public static AlertCriterion QuotaThresholdApproaching { get; } = new AlertCriterion(QuotaThresholdApproachingValue);
        /// <summary> QuotaThresholdReached. </summary>
        public static AlertCriterion QuotaThresholdReached { get; } = new AlertCriterion(QuotaThresholdReachedValue);
        /// <summary> MultiCurrency. </summary>
        public static AlertCriterion MultiCurrency { get; } = new AlertCriterion(MultiCurrencyValue);
        /// <summary> ForecastCostThresholdExceeded. </summary>
        public static AlertCriterion ForecastCostThresholdExceeded { get; } = new AlertCriterion(ForecastCostThresholdExceededValue);
        /// <summary> ForecastUsageThresholdExceeded. </summary>
        public static AlertCriterion ForecastUsageThresholdExceeded { get; } = new AlertCriterion(ForecastUsageThresholdExceededValue);
        /// <summary> InvoiceDueDateApproaching. </summary>
        public static AlertCriterion InvoiceDueDateApproaching { get; } = new AlertCriterion(InvoiceDueDateApproachingValue);
        /// <summary> InvoiceDueDateReached. </summary>
        public static AlertCriterion InvoiceDueDateReached { get; } = new AlertCriterion(InvoiceDueDateReachedValue);
        /// <summary> CrossCloudNewDataAvailable. </summary>
        public static AlertCriterion CrossCloudNewDataAvailable { get; } = new AlertCriterion(CrossCloudNewDataAvailableValue);
        /// <summary> CrossCloudCollectionError. </summary>
        public static AlertCriterion CrossCloudCollectionError { get; } = new AlertCriterion(CrossCloudCollectionErrorValue);
        /// <summary> GeneralThresholdError. </summary>
        public static AlertCriterion GeneralThresholdError { get; } = new AlertCriterion(GeneralThresholdErrorValue);
        /// <summary> Determines if two <see cref="AlertCriterion"/> values are the same. </summary>
        public static bool operator ==(AlertCriterion left, AlertCriterion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertCriterion"/> values are not the same. </summary>
        public static bool operator !=(AlertCriterion left, AlertCriterion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertCriterion"/>. </summary>
        public static implicit operator AlertCriterion(string value) => new AlertCriterion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertCriterion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertCriterion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}