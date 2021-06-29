using System;
using Chip.Minecraft;
using Chip.Minecraft.Operations;
using DaanV2.NBT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Minecraft.Operations {
    [TestClass]
    public class LayerBuilder {
        [TestMethod]
        public void Combine() {
            var World = new FakeWorld();
            var Builder = new LayerBuilder<FakeWorld>(World, 5, 10, new Location2D(5, 5));

            Box Box = Builder.Combine(new Square(new Location2D(5, 5), new Location2D(15, 15)));

            Assert.AreEqual(Box, new Box(10, 5, 10, 20, 15, 20));
        }

        [TestMethod]
        public void Fill1() {
            InternalFillTest(new Square(0, 0, 5, 5), Blocks.Copper, new Location2D(5, 5));
            InternalFillTest(new Square(0, 0, 15, 15), Blocks.Copper, new Location2D(-5, -5));
            InternalFillTest(new Square(0, 0, 31, 31), Blocks.Copper, new Location2D(5, 5));
        }

        internal static void InternalFillTest(Square Area, NBTTagCompound Block, Location2D Offset, Int32 yStart = 5, Int32 Thickness = 10) {
            var World = new FakeWorld();
            var Builder = new LayerBuilder<FakeWorld>(World, yStart, Thickness, Offset);

            Box Box = Builder.Combine(Area);
            var Chunks = (Chip.Minecraft.ChunkBox)Box;
            Int32 Volume = Box.GetVolume();
            Int32 ChunkCount = Chunks.GetVolume();

            Builder.Fill(Area, Block);

            Assert.AreEqual(Box.From.X, Area.From.X + Offset.X);
            Assert.AreEqual(Box.From.Z, Area.From.Z + Offset.Z);

            Assert.AreEqual(World.SubChunkReads, ChunkCount, $"[{Area}] Subchunk reads: {World.SubChunkReads}, expected: {ChunkCount}");
            Assert.AreEqual(World.SubChunkWrites, ChunkCount, $"[{Area}] Subchunk writes: {World.SubChunkReads}, expected: {ChunkCount}");

            Assert.AreEqual(World.CountBlock(Block), Volume);
        }
    }
}
