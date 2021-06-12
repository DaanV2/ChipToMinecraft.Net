using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Chip.Minecraft.Serialization {
    public partial class LocationConverter : JsonConverter<Location> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Location Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            Location Out = new Location();

            if (reader.TokenType ==  JsonTokenType.StartArray) {
                Out.X = reader.GetInt32();
                Out.Y = reader.GetInt32();
                Out.Z = reader.GetInt32();
            }

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
