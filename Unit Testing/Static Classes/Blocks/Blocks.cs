using DaanV2.NBT;

namespace UnitTesting {
    ///DOLATER <summary>add description for class: Blocks</summary>
    public static partial class Blocks {
        public static readonly NBTTagCompound AirBlock;
        public static readonly NBTTagCompound Copper;

        static Blocks() {
            AirBlock = new NBTTagCompound {
                new NBTTagString("name", "minecraft:air")
            };
            Copper = new NBTTagCompound {
                new NBTTagString("name", "minecraft:copper")
            };
        }
    }
}
