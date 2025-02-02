// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsQueryCompilationResult : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsQueryCompilationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsQueryCompilationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsQueryCompilationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings"u8);
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Functions))
            {
                writer.WritePropertyName("functions"u8);
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        StreamAnalyticsQueryCompilationResult IJsonModel<StreamAnalyticsQueryCompilationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsQueryCompilationResult(document.RootElement, options);
        }

        internal static StreamAnalyticsQueryCompilationResult DeserializeStreamAnalyticsQueryCompilationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StreamAnalyticsQueryCompilationError>> errors = default;
            Optional<IReadOnlyList<string>> warnings = default;
            Optional<IReadOnlyList<string>> inputs = default;
            Optional<IReadOnlyList<string>> outputs = default;
            Optional<IReadOnlyList<string>> functions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamAnalyticsQueryCompilationError> array = new List<StreamAnalyticsQueryCompilationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamAnalyticsQueryCompilationError.DeserializeStreamAnalyticsQueryCompilationError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("functions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamAnalyticsQueryCompilationResult(Optional.ToList(errors), Optional.ToList(warnings), Optional.ToList(inputs), Optional.ToList(outputs), Optional.ToList(functions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsQueryCompilationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationResult)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsQueryCompilationResult IPersistableModel<StreamAnalyticsQueryCompilationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsQueryCompilationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsQueryCompilationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
