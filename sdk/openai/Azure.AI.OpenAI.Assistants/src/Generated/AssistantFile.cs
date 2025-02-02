// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Information about a file attached to an assistant, as used by tools that can read files. </summary>
    public partial class AssistantFile
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

        /// <summary> Initializes a new instance of <see cref="AssistantFile"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="assistantId"> The assistant ID that the file is attached to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="assistantId"/> is null. </exception>
        internal AssistantFile(string id, DateTimeOffset createdAt, string assistantId)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (assistantId == null)
            {
                throw new ArgumentNullException(nameof(assistantId));
            }

            Id = id;
            CreatedAt = createdAt;
            AssistantId = assistantId;
        }

        /// <summary> Initializes a new instance of <see cref="AssistantFile"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always 'assistant.file'. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="assistantId"> The assistant ID that the file is attached to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssistantFile(string id, string @object, DateTimeOffset createdAt, string assistantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            AssistantId = assistantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssistantFile"/> for deserialization. </summary>
        internal AssistantFile()
        {
        }

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; }

        /// <summary> The Unix timestamp, in seconds, representing when this object was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The assistant ID that the file is attached to. </summary>
        public string AssistantId { get; }
    }
}
