﻿using System;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class FillSubChunk {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="Area"></param>
        /// <param name="block"></param>
        public static void Fill<T>(T World, Box Area, NBTTagCompound block)
            where T : IWorld {
            //TODO
        }
    }
}
