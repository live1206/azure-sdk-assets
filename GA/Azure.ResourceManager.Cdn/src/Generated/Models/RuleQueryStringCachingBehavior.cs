// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings. </summary>
    public readonly partial struct RuleQueryStringCachingBehavior : IEquatable<RuleQueryStringCachingBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RuleQueryStringCachingBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RuleQueryStringCachingBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IgnoreQueryStringValue = "IgnoreQueryString";
        private const string UseQueryStringValue = "UseQueryString";
        private const string IgnoreSpecifiedQueryStringsValue = "IgnoreSpecifiedQueryStrings";
        private const string IncludeSpecifiedQueryStringsValue = "IncludeSpecifiedQueryStrings";

        /// <summary> IgnoreQueryString. </summary>
        public static RuleQueryStringCachingBehavior IgnoreQueryString { get; } = new RuleQueryStringCachingBehavior(IgnoreQueryStringValue);
        /// <summary> UseQueryString. </summary>
        public static RuleQueryStringCachingBehavior UseQueryString { get; } = new RuleQueryStringCachingBehavior(UseQueryStringValue);
        /// <summary> IgnoreSpecifiedQueryStrings. </summary>
        public static RuleQueryStringCachingBehavior IgnoreSpecifiedQueryStrings { get; } = new RuleQueryStringCachingBehavior(IgnoreSpecifiedQueryStringsValue);
        /// <summary> IncludeSpecifiedQueryStrings. </summary>
        public static RuleQueryStringCachingBehavior IncludeSpecifiedQueryStrings { get; } = new RuleQueryStringCachingBehavior(IncludeSpecifiedQueryStringsValue);
        /// <summary> Determines if two <see cref="RuleQueryStringCachingBehavior"/> values are the same. </summary>
        public static bool operator ==(RuleQueryStringCachingBehavior left, RuleQueryStringCachingBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RuleQueryStringCachingBehavior"/> values are not the same. </summary>
        public static bool operator !=(RuleQueryStringCachingBehavior left, RuleQueryStringCachingBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RuleQueryStringCachingBehavior"/>. </summary>
        public static implicit operator RuleQueryStringCachingBehavior(string value) => new RuleQueryStringCachingBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RuleQueryStringCachingBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RuleQueryStringCachingBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}