using System;
using Chip.Minecraft;
using DaanV2.NBT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Minecraft {
    [TestClass]
    public partial class WorldExtension {
        [TestMethod]
        public void Fill1() {
            var World = new FakeWorld();

            World.Fill(new Box(0, 0, 0, 79, 0, 0), Blocks.Copper);

            Assert.AreEqual(World.SubChunkReads, 5);
            Assert.AreEqual(World.SubChunkWrites, 5);

            Assert.AreEqual(World.CountBlock(Blocks.Copper), 80);
        }

        [TestMethod]
        public void Fill2() {
            var World = new FakeWorld();

            World.Fill(new Box(0, 0, 0, 4, 4, 4), Blocks.Copper);

            Assert.AreEqual(World.SubChunkReads, 1);
            Assert.AreEqual(World.SubChunkWrites, 1);

            Assert.AreEqual(World.CountBlock(Blocks.Copper), 5 * 5 * 5);
        }

        [TestMethod]
        public void Fill3() {
            var World = new FakeWorld();

            World.Fill(new Box(15, 15, 15, 15 + 4, 15 + 4, 15 + 4), Blocks.Copper);

            Assert.AreEqual(World.SubChunkReads, 8);
            Assert.AreEqual(World.SubChunkWrites, 8);

            Assert.AreEqual(World.CountBlock(Blocks.Copper), 5 * 5 * 5);
        }

        [TestMethod]
        public void Fill4() {
            InternalFillTest(new Box(0, 0, 0, 15, 15, 15), Blocks.Copper);
            InternalFillTest(new Box(0, 0, 0, 47, 47, 47), Blocks.Copper);
            InternalFillTest(new Box(0, 0, 0, 79, 79, 79), Blocks.Copper);

            InternalFillTest(new Box(0, 0, 0, 44, 44, 44), Blocks.Copper);

            InternalFillTest(new Box(2, 10, 10, 4, 12, 102), Blocks.Copper);


            InternalFillTest(new Box(-47, -47, -47, -15, -15, -15), Blocks.Copper);
            InternalFillTest(new Box(-79, -79, -79, -15, -15, -15), Blocks.Copper);
        }



        internal static void InternalFillTest(Box Area, NBTTagCompound Block) {
            var Chunks = (Chip.Minecraft.ChunkBox)Area;
            Int32 Volume = Area.GetVolume();
            Int32 ChunkCount = Chunks.GetVolume();

            var World = new FakeWorld();
            World.Fill(Area, Block);

            Assert.AreEqual(World.SubChunkReads, ChunkCount, $"[{Area}] Subchunk reads: {World.SubChunkReads}, expected: {ChunkCount}");
            Assert.AreEqual(World.SubChunkWrites, ChunkCount, $"[{Area}] Subchunk writes: {World.SubChunkReads}, expected: {ChunkCount}");

            Assert.AreEqual(World.CountBlock(Block), Volume);
        }
    }
}
