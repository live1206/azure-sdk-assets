// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Determines the type of workload a node can run. </summary>
    public readonly partial struct WorkloadRuntime : IEquatable<WorkloadRuntime>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadRuntime"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadRuntime(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OciContainerValue = "OCIContainer";
        private const string WasmWasiValue = "WasmWasi";
        private const string KataMshvVmIsolationValue = "KataMshvVmIsolation";

        /// <summary> Nodes will use Kubelet to run standard OCI container workloads. </summary>
        public static WorkloadRuntime OciContainer { get; } = new WorkloadRuntime(OciContainerValue);
        /// <summary> Nodes will use Krustlet to run WASM workloads using the WASI provider (Preview). </summary>
        public static WorkloadRuntime WasmWasi { get; } = new WorkloadRuntime(WasmWasiValue);
        /// <summary> Nodes can use (Kata + Cloud Hypervisor + Hyper-V) to enable Nested VM-based pods (Preview). Due to the use Hyper-V, AKS node OS itself is a nested VM (the root OS) of Hyper-V. Thus it can only be used with VM series that support Nested Virtualization such as Dv3 series. </summary>
        public static WorkloadRuntime KataMshvVmIsolation { get; } = new WorkloadRuntime(KataMshvVmIsolationValue);
        /// <summary> Determines if two <see cref="WorkloadRuntime"/> values are the same. </summary>
        public static bool operator ==(WorkloadRuntime left, WorkloadRuntime right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadRuntime"/> values are not the same. </summary>
        public static bool operator !=(WorkloadRuntime left, WorkloadRuntime right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkloadRuntime"/>. </summary>
        public static implicit operator WorkloadRuntime(string value) => new WorkloadRuntime(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadRuntime other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadRuntime other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}