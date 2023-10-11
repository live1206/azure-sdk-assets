// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> DatabricksSparkPython activity. </summary>
    public partial class DatabricksSparkPythonActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DatabricksSparkPythonActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="pythonFile"> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="pythonFile"/> is null. </exception>
        public DatabricksSparkPythonActivity(string name, DataFactoryElement<string> pythonFile) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(pythonFile, nameof(pythonFile));

            PythonFile = pythonFile;
            Parameters = new ChangeTrackingList<BinaryData>();
            Libraries = new ChangeTrackingList<IDictionary<string, BinaryData>>();
            ActivityType = "DatabricksSparkPython";
        }

        /// <summary> Initializes a new instance of DatabricksSparkPythonActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="pythonFile"> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </param>
        /// <param name="parameters"> Command line parameters that will be passed to the Python file. </param>
        /// <param name="libraries"> A list of libraries to be installed on the cluster that will execute the job. </param>
        internal DatabricksSparkPythonActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> pythonFile, IList<BinaryData> parameters, IList<IDictionary<string, BinaryData>> libraries) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            PythonFile = pythonFile;
            Parameters = parameters;
            Libraries = libraries;
            ActivityType = activityType ?? "DatabricksSparkPython";
        }

        /// <summary> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PythonFile { get; set; }
        /// <summary>
        /// Command line parameters that will be passed to the Python file.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IList<BinaryData> Parameters { get; }
        /// <summary> A list of libraries to be installed on the cluster that will execute the job. </summary>
        public IList<IDictionary<string, BinaryData>> Libraries { get; }
    }
}