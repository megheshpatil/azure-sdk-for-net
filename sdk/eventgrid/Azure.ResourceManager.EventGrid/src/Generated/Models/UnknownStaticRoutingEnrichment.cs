// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The UnknownStaticRoutingEnrichment. </summary>
    internal partial class UnknownStaticRoutingEnrichment : StaticRoutingEnrichment
    {
        /// <summary> Initializes a new instance of <see cref="UnknownStaticRoutingEnrichment"/>. </summary>
        /// <param name="key"> Static routing enrichment key. </param>
        /// <param name="valueType"> Static routing enrichment value type. For e.g. this property value can be 'String'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownStaticRoutingEnrichment(string key, StaticRoutingEnrichmentType valueType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(key, valueType, serializedAdditionalRawData)
        {
            ValueType = valueType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownStaticRoutingEnrichment"/> for deserialization. </summary>
        internal UnknownStaticRoutingEnrichment()
        {
        }
    }
}
