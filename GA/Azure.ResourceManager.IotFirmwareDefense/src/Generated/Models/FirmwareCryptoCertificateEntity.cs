// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Information on an entity (distinguished name) in a cryptographic certificate. </summary>
    public partial class FirmwareCryptoCertificateEntity
    {
        /// <summary> Initializes a new instance of FirmwareCryptoCertificateEntity. </summary>
        internal FirmwareCryptoCertificateEntity()
        {
        }

        /// <summary> Initializes a new instance of FirmwareCryptoCertificateEntity. </summary>
        /// <param name="commonName"> Common name of the certificate entity. </param>
        /// <param name="organization"> Organization of the certificate entity. </param>
        /// <param name="organizationalUnit"> The organizational unit of the certificate entity. </param>
        /// <param name="state"> Geographical state or province of the certificate entity. </param>
        /// <param name="country"> Country code of the certificate entity. </param>
        internal FirmwareCryptoCertificateEntity(string commonName, string organization, string organizationalUnit, string state, string country)
        {
            CommonName = commonName;
            Organization = organization;
            OrganizationalUnit = organizationalUnit;
            State = state;
            Country = country;
        }

        /// <summary> Common name of the certificate entity. </summary>
        public string CommonName { get; }
        /// <summary> Organization of the certificate entity. </summary>
        public string Organization { get; }
        /// <summary> The organizational unit of the certificate entity. </summary>
        public string OrganizationalUnit { get; }
        /// <summary> Geographical state or province of the certificate entity. </summary>
        public string State { get; }
        /// <summary> Country code of the certificate entity. </summary>
        public string Country { get; }
    }
}