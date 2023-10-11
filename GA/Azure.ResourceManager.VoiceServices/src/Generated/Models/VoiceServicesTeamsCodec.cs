// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The voice codecs expected for communication with Teams. </summary>
    public readonly partial struct VoiceServicesTeamsCodec : IEquatable<VoiceServicesTeamsCodec>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VoiceServicesTeamsCodec"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VoiceServicesTeamsCodec(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PcmaValue = "PCMA";
        private const string PcmuValue = "PCMU";
        private const string G722Value = "G722";
        private const string G7222Value = "G722_2";
        private const string Silk8Value = "SILK_8";
        private const string Silk16Value = "SILK_16";

        /// <summary> PCMA. </summary>
        public static VoiceServicesTeamsCodec Pcma { get; } = new VoiceServicesTeamsCodec(PcmaValue);
        /// <summary> PCMU. </summary>
        public static VoiceServicesTeamsCodec Pcmu { get; } = new VoiceServicesTeamsCodec(PcmuValue);
        /// <summary> G722. </summary>
        public static VoiceServicesTeamsCodec G722 { get; } = new VoiceServicesTeamsCodec(G722Value);
        /// <summary> G722_2. </summary>
        public static VoiceServicesTeamsCodec G7222 { get; } = new VoiceServicesTeamsCodec(G7222Value);
        /// <summary> SILK_8. </summary>
        public static VoiceServicesTeamsCodec Silk8 { get; } = new VoiceServicesTeamsCodec(Silk8Value);
        /// <summary> SILK_16. </summary>
        public static VoiceServicesTeamsCodec Silk16 { get; } = new VoiceServicesTeamsCodec(Silk16Value);
        /// <summary> Determines if two <see cref="VoiceServicesTeamsCodec"/> values are the same. </summary>
        public static bool operator ==(VoiceServicesTeamsCodec left, VoiceServicesTeamsCodec right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VoiceServicesTeamsCodec"/> values are not the same. </summary>
        public static bool operator !=(VoiceServicesTeamsCodec left, VoiceServicesTeamsCodec right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VoiceServicesTeamsCodec"/>. </summary>
        public static implicit operator VoiceServicesTeamsCodec(string value) => new VoiceServicesTeamsCodec(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VoiceServicesTeamsCodec other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VoiceServicesTeamsCodec other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}