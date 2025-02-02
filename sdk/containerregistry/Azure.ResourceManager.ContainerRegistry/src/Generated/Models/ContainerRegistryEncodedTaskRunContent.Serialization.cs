// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryEncodedTaskRunContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryEncodedTaskRunContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryEncodedTaskRunContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryEncodedTaskRunContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryEncodedTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryEncodedTaskRunContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("encodedTaskContent"u8);
            writer.WriteStringValue(EncodedTaskContent);
            if (Optional.IsDefined(EncodedValuesContent))
            {
                writer.WritePropertyName("encodedValuesContent"u8);
                writer.WriteStringValue(EncodedValuesContent);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue(Platform);
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(SourceLocation))
            {
                writer.WritePropertyName("sourceLocation"u8);
                writer.WriteStringValue(SourceLocation);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ContainerRegistryEncodedTaskRunContent IJsonModel<ContainerRegistryEncodedTaskRunContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryEncodedTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryEncodedTaskRunContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryEncodedTaskRunContent(document.RootElement, options);
        }

        internal static ContainerRegistryEncodedTaskRunContent DeserializeContainerRegistryEncodedTaskRunContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string encodedTaskContent = default;
            Optional<string> encodedValuesContent = default;
            Optional<IList<ContainerRegistryTaskOverridableValue>> values = default;
            Optional<int> timeout = default;
            ContainerRegistryPlatformProperties platform = default;
            Optional<ContainerRegistryAgentProperties> agentConfiguration = default;
            Optional<string> sourceLocation = default;
            Optional<ContainerRegistryCredentials> credentials = default;
            string type = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> agentPoolName = default;
            Optional<string> logTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedTaskContent"u8))
                {
                    encodedTaskContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedValuesContent"u8))
                {
                    encodedValuesContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item, options));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceLocation"u8))
                {
                    sourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = ContainerRegistryCredentials.DeserializeContainerRegistryCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryEncodedTaskRunContent(type, Optional.ToNullable(isArchiveEnabled), agentPoolName.Value, logTemplate.Value, serializedAdditionalRawData, encodedTaskContent, encodedValuesContent.Value, Optional.ToList(values), Optional.ToNullable(timeout), platform, agentConfiguration.Value, sourceLocation.Value, credentials.Value);
        }

        BinaryData IPersistableModel<ContainerRegistryEncodedTaskRunContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryEncodedTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryEncodedTaskRunContent)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryEncodedTaskRunContent IPersistableModel<ContainerRegistryEncodedTaskRunContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryEncodedTaskRunContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryEncodedTaskRunContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryEncodedTaskRunContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryEncodedTaskRunContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
