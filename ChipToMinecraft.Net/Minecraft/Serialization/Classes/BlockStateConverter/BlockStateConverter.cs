using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Chip.Minecraft.Serialization {
    ///DOLATER <summary>add description for class: BlockStateConverter</summary>
    public partial class BlockStateConverter : JsonConverter<BlockState> {
        /// <inheritdoc/>
        public override BlockState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            var Result = new BlockState();
            ReadOnlySpan<Byte> value = ReadOnlySpan<Byte>.Empty;

            //Check if the json is at an object
            if (reader.TokenType != JsonTokenType.StartObject) throw new JsonException();
            reader.Read();

            while (reader.TokenType != JsonTokenType.EndObject) {
                if (reader.TokenType == JsonTokenType.PropertyName) {
                    String Property = reader.GetString();
                    reader.Read();

                    switch (Property) {
                        case "name":
                            Result.Name = reader.GetString();
                            break;

                        case "type":
                            Result.Type = reader.GetString();
                            break;

                        case "value":
                            value = reader.ValueSpan;
                            break;
                    }
                }

                reader.Read();
            }

            if (value != ReadOnlySpan<Byte>.Empty) {
                String str = UTF8Encoding.UTF8.GetString(value);
                switch (Result.Type) {
                    case "string":
                        Result.Value = str;
                        break;

                    case "byte":
                        Result.Value = Byte.Parse(str);
                        break;

                    case "int":
                        Result.Value = Int32.Parse(str);
                        break;

                    default:
                        break;
                }
            }

            return Result;
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, BlockState value, JsonSerializerOptions options) {
            writer.WriteStartObject();

            writer.WriteString("name", value.Name);
            writer.WriteString("type", value.Type);

            switch (value.Type) {
                case "string":
                    writer.WriteString("value", (String)value.Value);
                    break;

                case "byte":
                    writer.WriteNumber("value", (Byte)value.Value);
                    break;

                case "int":
                    writer.WriteNumber("value", (Int32)value.Value);
                    break;

                default:
                    writer.WriteString("value", value.Value.ToString());
                    break;
            }

            writer.WriteEndObject();
        }
    }
}
