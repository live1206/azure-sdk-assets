// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Binary hardening of a firmware. </summary>
    public partial class BinaryHardening
    {
        /// <summary> Initializes a new instance of BinaryHardening. </summary>
        internal BinaryHardening()
        {
        }

        /// <summary> Initializes a new instance of BinaryHardening. </summary>
        /// <param name="binaryHardeningId"> ID for the binary hardening result. </param>
        /// <param name="architecture"> The architecture of the uploaded firmware. </param>
        /// <param name="path"> path for binary hardening. </param>
        /// <param name="class"> class for binary hardening. </param>
        /// <param name="runpath"> The runpath of the uploaded firmware. </param>
        /// <param name="rpath"> The rpath of the uploaded firmware. </param>
        /// <param name="nx"> NX flag. </param>
        /// <param name="pie"> PIE flag. </param>
        /// <param name="relro"> RELRO flag. </param>
        /// <param name="canary"> Canary flag. </param>
        /// <param name="stripped"> Stripped flag. </param>
        internal BinaryHardening(string binaryHardeningId, string architecture, string path, string @class, string runpath, string rpath, NxFlag? nx, PieFlag? pie, RelroFlag? relro, CanaryFlag? canary, StrippedFlag? stripped)
        {
            BinaryHardeningId = binaryHardeningId;
            Architecture = architecture;
            Path = path;
            Class = @class;
            Runpath = runpath;
            Rpath = rpath;
            Nx = nx;
            Pie = pie;
            Relro = relro;
            Canary = canary;
            Stripped = stripped;
        }

        /// <summary> ID for the binary hardening result. </summary>
        public string BinaryHardeningId { get; }
        /// <summary> The architecture of the uploaded firmware. </summary>
        public string Architecture { get; }
        /// <summary> path for binary hardening. </summary>
        public string Path { get; }
        /// <summary> class for binary hardening. </summary>
        public string Class { get; }
        /// <summary> The runpath of the uploaded firmware. </summary>
        public string Runpath { get; }
        /// <summary> The rpath of the uploaded firmware. </summary>
        public string Rpath { get; }
        /// <summary> NX flag. </summary>
        public NxFlag? Nx { get; }
        /// <summary> PIE flag. </summary>
        public PieFlag? Pie { get; }
        /// <summary> RELRO flag. </summary>
        public RelroFlag? Relro { get; }
        /// <summary> Canary flag. </summary>
        public CanaryFlag? Canary { get; }
        /// <summary> Stripped flag. </summary>
        public StrippedFlag? Stripped { get; }
    }
}