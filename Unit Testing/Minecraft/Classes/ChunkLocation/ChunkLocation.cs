using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Minecraft {
    [TestClass]
    public partial class ChunkLocation {
        [TestMethod]
        public void LocationToChunk() {
            InternalLocationToChunk(0, 0, 0, 0, 0, 0);

            InternalLocationToChunk(16, 16, 16, 1, 1, 1);
            InternalLocationToChunk(15, 15, 15, 0, 0, 0);
        }

        public static void InternalLocationToChunk(Int32 LX, Int32 LY, Int32 LZ, Int32 ExpectX, Int32 ExpectY, Int32 ExpectZ) {
            InternalLocationToChunk(new Chip.Minecraft.Location(LX, LY, LZ), new Chip.Minecraft.ChunkLocation(ExpectX, ExpectY, ExpectZ));
        }

        public static void InternalLocationToChunk(Chip.Minecraft.Location Conv, Chip.Minecraft.ChunkLocation Expect) {
            var C = (Chip.Minecraft.ChunkLocation)Conv;

            Assert.AreEqual(C, Expect);
        }
    }
}
