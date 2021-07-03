using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Chip.Minecraft.Serialization {
    public partial class LocationConverter : JsonConverter<Location> {
        /// <summary> </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Location Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            Location Out;

            if (reader.TokenType == JsonTokenType.StartArray) {
                Out = new Location(reader.GetInt32(), reader.GetInt32(), reader.GetInt32());
            }
            else {
                Out = new Location();
            }

            return Out;
        }

        /// <summary> </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, Location value, JsonSerializerOptions options) {
            writer.WriteStartArray();

            writer.WriteNumberValue(value.X);
            writer.WriteNumberValue(value.Y);
            writer.WriteNumberValue(value.Z);

            writer.WriteEndArray();
        }
    }
}
