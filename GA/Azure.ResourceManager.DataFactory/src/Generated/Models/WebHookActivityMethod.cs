// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The list of HTTP methods supported by a WebHook activity. </summary>
    public readonly partial struct WebHookActivityMethod : IEquatable<WebHookActivityMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebHookActivityMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebHookActivityMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PostValue = "POST";

        /// <summary> POST. </summary>
        public static WebHookActivityMethod Post { get; } = new WebHookActivityMethod(PostValue);
        /// <summary> Determines if two <see cref="WebHookActivityMethod"/> values are the same. </summary>
        public static bool operator ==(WebHookActivityMethod left, WebHookActivityMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebHookActivityMethod"/> values are not the same. </summary>
        public static bool operator !=(WebHookActivityMethod left, WebHookActivityMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebHookActivityMethod"/>. </summary>
        public static implicit operator WebHookActivityMethod(string value) => new WebHookActivityMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebHookActivityMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebHookActivityMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
