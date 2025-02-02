// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The KPI GroupBy field metadata. </summary>
    public partial class KpiGroupByMetadata
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KpiGroupByMetadata"/>. </summary>
        internal KpiGroupByMetadata()
        {
            DisplayName = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KpiGroupByMetadata"/>. </summary>
        /// <param name="displayName"> The display name. </param>
        /// <param name="fieldName"> The name of the field. </param>
        /// <param name="fieldType"> The type of the field. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiGroupByMetadata(IReadOnlyDictionary<string, string> displayName, string fieldName, string fieldType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            FieldName = fieldName;
            FieldType = fieldType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The display name. </summary>
        public IReadOnlyDictionary<string, string> DisplayName { get; }
        /// <summary> The name of the field. </summary>
        public string FieldName { get; }
        /// <summary> The type of the field. </summary>
        public string FieldType { get; }
    }
}
