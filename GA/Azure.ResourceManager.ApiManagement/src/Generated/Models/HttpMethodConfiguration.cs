// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The HTTP method to be used. </summary>
    public readonly partial struct HttpMethodConfiguration : IEquatable<HttpMethodConfiguration>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HttpMethodConfiguration"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpMethodConfiguration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GetValue = "GET";
        private const string PostValue = "POST";

        /// <summary> GET. </summary>
        public static HttpMethodConfiguration Get { get; } = new HttpMethodConfiguration(GetValue);
        /// <summary> POST. </summary>
        public static HttpMethodConfiguration Post { get; } = new HttpMethodConfiguration(PostValue);
        /// <summary> Determines if two <see cref="HttpMethodConfiguration"/> values are the same. </summary>
        public static bool operator ==(HttpMethodConfiguration left, HttpMethodConfiguration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpMethodConfiguration"/> values are not the same. </summary>
        public static bool operator !=(HttpMethodConfiguration left, HttpMethodConfiguration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HttpMethodConfiguration"/>. </summary>
        public static implicit operator HttpMethodConfiguration(string value) => new HttpMethodConfiguration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpMethodConfiguration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpMethodConfiguration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}