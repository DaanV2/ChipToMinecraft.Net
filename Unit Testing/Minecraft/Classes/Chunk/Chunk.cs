using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Minecraft {
    [TestClass]
    public partial class Chunk {
        [TestMethod]
        public void ChunkCoordinate() {
            for (Int32 I = 0; I < 16; I++) {
                Assert.IsTrue(Chip.Minecraft.Chunk.ChunkCoordinate(I) == 0);
            }

            for (Int32 I = -15; I < 0; I++) {
                Assert.IsTrue(Chip.Minecraft.Chunk.ChunkCoordinate(I) == -1);
            }
        }

        [TestMethod]
        public void WorldCoordinate() {
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(-1) == -16);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(0) == 0);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(1) == 16);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(2) == 32);
        }

        [TestMethod]
        public void WorldCoordinate2() {
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(-1, 0) == -16);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(-1, 1) == -15);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(-1, 15) == -1);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(2, 0) == 32);
            Assert.IsTrue(Chip.Minecraft.Chunk.WorldCoordinate(2, 3) == 35);
        }

        [TestMethod]
        public void RelativeChunkCoordinate() {
            Assert.IsTrue(Chip.Minecraft.Chunk.RelativeChunkCoordinate(0) == 0);
            Assert.IsTrue(Chip.Minecraft.Chunk.RelativeChunkCoordinate(1) == 1);
            Assert.IsTrue(Chip.Minecraft.Chunk.RelativeChunkCoordinate(16) == 0);
        }

        [TestMethod]
        public void StartOfChunk() {
            for (Int32 I = -2; I < 3; I++) {
                Int32 Start = Chip.Minecraft.Chunk.WorldCoordinate(I);

                Assert.IsTrue(Chip.Minecraft.Chunk.CoordinateIsStartOfChunk(Start));

                for (Int32 J = 1; J < 16; J++) {
                    Assert.IsFalse(Chip.Minecraft.Chunk.CoordinateIsStartOfChunk(Start + J));
                }
            }

        }
    }
}
