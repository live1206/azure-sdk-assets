// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies settings related to VM Guest Patching on Linux. </summary>
    public partial class LinuxPatchSettings
    {
        /// <summary> Initializes a new instance of LinuxPatchSettings. </summary>
        public LinuxPatchSettings()
        {
        }

        /// <summary> Initializes a new instance of LinuxPatchSettings. </summary>
        /// <param name="patchMode"> Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual machine scale set with OrchestrationMode as Flexible.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - The virtual machine's default patching configuration is used. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The virtual machine will be automatically updated by the platform. The property provisionVMAgent must be true. </param>
        /// <param name="assessmentMode"> Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - You control the timing of patch assessments on a virtual machine. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true. </param>
        /// <param name="automaticByPlatformSettings"> Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on Linux. </param>
        internal LinuxPatchSettings(LinuxVmGuestPatchMode? patchMode, LinuxPatchAssessmentMode? assessmentMode, LinuxVmGuestPatchAutomaticByPlatformSettings automaticByPlatformSettings)
        {
            PatchMode = patchMode;
            AssessmentMode = assessmentMode;
            AutomaticByPlatformSettings = automaticByPlatformSettings;
        }

        /// <summary> Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual machine scale set with OrchestrationMode as Flexible.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - The virtual machine's default patching configuration is used. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The virtual machine will be automatically updated by the platform. The property provisionVMAgent must be true. </summary>
        public LinuxVmGuestPatchMode? PatchMode { get; set; }
        /// <summary> Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - You control the timing of patch assessments on a virtual machine. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true. </summary>
        public LinuxPatchAssessmentMode? AssessmentMode { get; set; }
        /// <summary> Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on Linux. </summary>
        public LinuxVmGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSettings { get; set; }
    }
}