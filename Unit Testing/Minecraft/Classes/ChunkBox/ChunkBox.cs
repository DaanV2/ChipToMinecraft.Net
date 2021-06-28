using Chip.Minecraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Minecraft {
    [TestClass]
    public partial class ChunkBox {
        [TestMethod]
        public void BoxToChunk() {
            InternalBoxToChunk(new Chip.Minecraft.Box(0, 0, 0, 31, 31, 31), new Chip.Minecraft.ChunkBox(0, 0, 0, 1, 1, 1));
        }

        public void Length() {
            var Box = new Chip.Minecraft.ChunkBox(0, 0, 0, 15, 15, 15);

            Assert.AreEqual(Box.GetLength(), 16);
        }

        public void Height() {
            var Box = new Chip.Minecraft.ChunkBox(0, 0, 0, 15, 15, 15);

            Assert.AreEqual(Box.GetHeight(), 16);
        }

        public void Width() {
            var Box = new Chip.Minecraft.ChunkBox(0, 0, 0, 15, 15, 15);

            Assert.AreEqual(Box.GetWidth(), 16);
        }

        public static void InternalBoxToChunk(Chip.Minecraft.Box Conv, Chip.Minecraft.ChunkBox Expect) {
            var C = (Chip.Minecraft.ChunkBox)Conv;

            Assert.AreEqual(C, Expect);
        }
    }
}
