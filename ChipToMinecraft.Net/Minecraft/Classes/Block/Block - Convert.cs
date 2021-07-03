using System;
using DaanV2.NBT;
using DaanV2.NBT.Builders;

namespace Chip.Minecraft {
    public partial class Block {
        /// <summary> </summary>
        /// <returns></returns>
        public NBTTagCompound ToNBT() {
            return ToNBT(this);
        }

        public static NBTTagCompound ToNBT(Block Process) {
            var Builder = new CompoundBuilder("", 3);
            Builder.Add("name", Process.ID);

            if (Process.States == null || Process.States.Count == 0) {

            }
            else {
                var States = new CompoundBuilder("states", Process.States.Count);

                for (Int32 I = 0; I < Process.States.Count; I++) {
                    BlockState State = Process.States[I];

                    switch (State.Type) {
                        case "byte":
                            Int32 Value = (Int32)State.Value;
                            States.Add(State.Name, (Byte)Value);
                            break;

                        case "string":
                            States.Add(State.Name, (String)State.Value);
                            break;

                        case "int":
                            States.Add(State.Name, (Int32)State.Value);
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                }


                Builder.Add(States.GetResult());
            }

            Builder.Add("version", 0);

            return Builder.GetResult();
        }
    }
}
