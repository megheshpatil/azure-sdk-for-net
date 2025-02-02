// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Filtering criteria for querying threat intelligence indicators. </summary>
    public partial class ThreatIntelligenceFilteringCriteria
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

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceFilteringCriteria"/>. </summary>
        public ThreatIntelligenceFilteringCriteria()
        {
            SortBy = new ChangeTrackingList<ThreatIntelligenceSortingCriteria>();
            Sources = new ChangeTrackingList<string>();
            PatternTypes = new ChangeTrackingList<string>();
            ThreatTypes = new ChangeTrackingList<string>();
            Ids = new ChangeTrackingList<string>();
            Keywords = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceFilteringCriteria"/>. </summary>
        /// <param name="pageSize"> Page size. </param>
        /// <param name="minConfidence"> Minimum confidence. </param>
        /// <param name="maxConfidence"> Maximum confidence. </param>
        /// <param name="minValidUntil"> Start time for ValidUntil filter. </param>
        /// <param name="maxValidUntil"> End time for ValidUntil filter. </param>
        /// <param name="isIncludeDisabled"> Parameter to include/exclude disabled indicators. </param>
        /// <param name="sortBy"> Columns to sort by and sorting order. </param>
        /// <param name="sources"> Sources of threat intelligence indicators. </param>
        /// <param name="patternTypes"> Pattern types. </param>
        /// <param name="threatTypes"> Threat types of threat intelligence indicators. </param>
        /// <param name="ids"> Ids of threat intelligence indicators. </param>
        /// <param name="keywords"> Keywords for searching threat intelligence indicators. </param>
        /// <param name="skipToken"> Skip token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceFilteringCriteria(int? pageSize, int? minConfidence, int? maxConfidence, DateTimeOffset? minValidUntil, DateTimeOffset? maxValidUntil, bool? isIncludeDisabled, IList<ThreatIntelligenceSortingCriteria> sortBy, IList<string> sources, IList<string> patternTypes, IList<string> threatTypes, IList<string> ids, IList<string> keywords, string skipToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PageSize = pageSize;
            MinConfidence = minConfidence;
            MaxConfidence = maxConfidence;
            MinValidUntil = minValidUntil;
            MaxValidUntil = maxValidUntil;
            IsIncludeDisabled = isIncludeDisabled;
            SortBy = sortBy;
            Sources = sources;
            PatternTypes = patternTypes;
            ThreatTypes = threatTypes;
            Ids = ids;
            Keywords = keywords;
            SkipToken = skipToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Page size. </summary>
        public int? PageSize { get; set; }
        /// <summary> Minimum confidence. </summary>
        public int? MinConfidence { get; set; }
        /// <summary> Maximum confidence. </summary>
        public int? MaxConfidence { get; set; }
        /// <summary> Start time for ValidUntil filter. </summary>
        public DateTimeOffset? MinValidUntil { get; set; }
        /// <summary> End time for ValidUntil filter. </summary>
        public DateTimeOffset? MaxValidUntil { get; set; }
        /// <summary> Parameter to include/exclude disabled indicators. </summary>
        public bool? IsIncludeDisabled { get; set; }
        /// <summary> Columns to sort by and sorting order. </summary>
        public IList<ThreatIntelligenceSortingCriteria> SortBy { get; }
        /// <summary> Sources of threat intelligence indicators. </summary>
        public IList<string> Sources { get; }
        /// <summary> Pattern types. </summary>
        public IList<string> PatternTypes { get; }
        /// <summary> Threat types of threat intelligence indicators. </summary>
        public IList<string> ThreatTypes { get; }
        /// <summary> Ids of threat intelligence indicators. </summary>
        public IList<string> Ids { get; }
        /// <summary> Keywords for searching threat intelligence indicators. </summary>
        public IList<string> Keywords { get; }
        /// <summary> Skip token. </summary>
        public string SkipToken { get; set; }
    }
}
