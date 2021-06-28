using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Minecraft.Operations {
    [TestClass]
    public partial class FillEntireSubChunk {
        [TestMethod]
        public void GetFullSubChunk() {
            Chip.Minecraft.Box? Out = Chip.Minecraft.Operations.FillEntireSubChunk.GetFullSubChunk(new Chip.Minecraft.Box(0, 0, 0, 33, 33, 33));

            if (Out.HasValue) {
                Assert.AreEqual(new Chip.Minecraft.Box(16, 16, 16, 31, 31, 31), Out.Value);
            }
            else {
                Assert.Fail("Expected a box to be returned");
            }
        }
    }
}
