// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The V3 type of the mapped entity. </summary>
    public readonly partial struct SecurityInsightsAlertRuleEntityMappingType : IEquatable<SecurityInsightsAlertRuleEntityMappingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertRuleEntityMappingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsAlertRuleEntityMappingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountValue = "Account";
        private const string HostValue = "Host";
        private const string IPValue = "IP";
        private const string MalwareValue = "Malware";
        private const string FileValue = "File";
        private const string ProcessValue = "Process";
        private const string CloudApplicationValue = "CloudApplication";
        private const string DnsValue = "DNS";
        private const string AzureResourceValue = "AzureResource";
        private const string FileHashValue = "FileHash";
        private const string RegistryKeyValue = "RegistryKey";
        private const string RegistryValueValue = "RegistryValue";
        private const string SecurityGroupValue = "SecurityGroup";
        private const string UriValue = "URL";
        private const string MailboxValue = "Mailbox";
        private const string MailClusterValue = "MailCluster";
        private const string MailMessageValue = "MailMessage";
        private const string SubmissionMailValue = "SubmissionMail";

        /// <summary> User account entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Account { get; } = new SecurityInsightsAlertRuleEntityMappingType(AccountValue);
        /// <summary> Host entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Host { get; } = new SecurityInsightsAlertRuleEntityMappingType(HostValue);
        /// <summary> IP address entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType IP { get; } = new SecurityInsightsAlertRuleEntityMappingType(IPValue);
        /// <summary> Malware entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Malware { get; } = new SecurityInsightsAlertRuleEntityMappingType(MalwareValue);
        /// <summary> System file entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType File { get; } = new SecurityInsightsAlertRuleEntityMappingType(FileValue);
        /// <summary> Process entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Process { get; } = new SecurityInsightsAlertRuleEntityMappingType(ProcessValue);
        /// <summary> Cloud app entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType CloudApplication { get; } = new SecurityInsightsAlertRuleEntityMappingType(CloudApplicationValue);
        /// <summary> DNS entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Dns { get; } = new SecurityInsightsAlertRuleEntityMappingType(DnsValue);
        /// <summary> Azure resource entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType AzureResource { get; } = new SecurityInsightsAlertRuleEntityMappingType(AzureResourceValue);
        /// <summary> File-hash entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType FileHash { get; } = new SecurityInsightsAlertRuleEntityMappingType(FileHashValue);
        /// <summary> Registry key entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType RegistryKey { get; } = new SecurityInsightsAlertRuleEntityMappingType(RegistryKeyValue);
        /// <summary> Registry value entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType RegistryValue { get; } = new SecurityInsightsAlertRuleEntityMappingType(RegistryValueValue);
        /// <summary> Security group entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType SecurityGroup { get; } = new SecurityInsightsAlertRuleEntityMappingType(SecurityGroupValue);
        /// <summary> URL entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Uri { get; } = new SecurityInsightsAlertRuleEntityMappingType(UriValue);
        /// <summary> Mailbox entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType Mailbox { get; } = new SecurityInsightsAlertRuleEntityMappingType(MailboxValue);
        /// <summary> Mail cluster entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType MailCluster { get; } = new SecurityInsightsAlertRuleEntityMappingType(MailClusterValue);
        /// <summary> Mail message entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType MailMessage { get; } = new SecurityInsightsAlertRuleEntityMappingType(MailMessageValue);
        /// <summary> Submission mail entity type. </summary>
        public static SecurityInsightsAlertRuleEntityMappingType SubmissionMail { get; } = new SecurityInsightsAlertRuleEntityMappingType(SubmissionMailValue);
        /// <summary> Determines if two <see cref="SecurityInsightsAlertRuleEntityMappingType"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsAlertRuleEntityMappingType left, SecurityInsightsAlertRuleEntityMappingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsAlertRuleEntityMappingType"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsAlertRuleEntityMappingType left, SecurityInsightsAlertRuleEntityMappingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsAlertRuleEntityMappingType"/>. </summary>
        public static implicit operator SecurityInsightsAlertRuleEntityMappingType(string value) => new SecurityInsightsAlertRuleEntityMappingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsAlertRuleEntityMappingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsAlertRuleEntityMappingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}