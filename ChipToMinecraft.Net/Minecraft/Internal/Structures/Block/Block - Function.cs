using System.IO;
using DaanV2.NBT;
using DaanV2.NBT.Serialization;

namespace Chip.Minecraft.Internal {
    public readonly partial struct Block {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public NBTTagCompound ToNBT() {
            var Stream = new MemoryStream(this.Data);
            var Context = new SerializationContext(DaanV2.Binary.Endianness.LittleEndian, Stream);

            var tag = NBTReader.Read(Context) as NBTTagCompound;
            return tag;
        }

        public Minecraft.Block ToBlock() {
            return Minecraft.Block.ToNBT();
        }
    }
}
