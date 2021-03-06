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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public static NBTTagCompound ToNBT(Block Process) {
            var Builder = new CompoundBuilder("", 3);
            Builder.Add("name", Process.ID);

            if (Process.States == null || Process.States.Count == 0) {

            }
            else {
                CompoundBuilder States = Builder.AddSubCompound("states", Process.States.Count);

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
            }

            Builder.Add("version", 0);

            return Builder.GetResult();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Block ToBlock(NBTTagCompound data) {
            var Out = new Block {
                ID = data.GetSubValue<String>("name")
            };

            ITag States = data.GetSubTag("states");

            for (Int32 I = 0; I < States.Count; I++) {
                ITag State = States.GetSubTag(I);

                String Name = State.Name;
                NBTTagType Type = State.Type;

                switch (Type) {
                    case NBTTagType.Byte:
                        Out.States.Add(new BlockState(Name, "byte", State.GetValue()));
                        break;

                    case NBTTagType.Int:
                        Out.States.Add(new BlockState(Name, "int", State.GetValue()));
                        break;

                    case NBTTagType.String:
                        Out.States.Add(new BlockState(Name, "string", State.GetValue()));
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return Out;
        }
    }
}
