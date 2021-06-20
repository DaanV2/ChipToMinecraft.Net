using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Chip.Minecraft;

namespace Chip.Serialization.Converters {
    ///DOLATER <summary>add description for class: LocationSerializer</summary>
    public partial class LocationSerializer : JsonConverter<Location> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Location Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            var Out = new Location {
                X = reader.GetInt32(),
                Y = reader.GetInt32(),
                Z = reader.GetInt32()
            };

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
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
