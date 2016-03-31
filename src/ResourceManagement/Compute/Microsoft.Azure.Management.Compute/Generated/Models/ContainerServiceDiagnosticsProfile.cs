// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class ContainerServiceDiagnosticsProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ContainerServiceDiagnosticsProfile class.
        /// </summary>
        public ContainerServiceDiagnosticsProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ContainerServiceDiagnosticsProfile class.
        /// </summary>
        public ContainerServiceDiagnosticsProfile(ContainerServiceVMDiagnostics vmDiagnostics = default(ContainerServiceVMDiagnostics))
        {
            VmDiagnostics = vmDiagnostics;
        }

        /// <summary>
        /// Profile for container service VM diagnostic agent
        /// </summary>
        [JsonProperty(PropertyName = "vmDiagnostics")]
        public ContainerServiceVMDiagnostics VmDiagnostics { get; set; }

    }
}
