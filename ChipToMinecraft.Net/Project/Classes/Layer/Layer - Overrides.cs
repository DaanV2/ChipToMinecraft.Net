using System;
using System.Collections.Generic;
using DaanV2.NBT;

namespace Chip.Project {
    public partial class Layer : IEquatable<Layer> {
        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as Layer);
        }

        /// <inheritdoc/>
        public Boolean Equals(Layer other) {
            return other != null &&
                   this.Filepath == other.Filepath &&
                   this.StartLocation.Equals(other.StartLocation) &&
                   this.Scale == other.Scale &&
                   this.Thickness == other.Thickness &&
                   EqualityComparer<NBTTagCompound>.Default.Equals(this.Block, other.Block);
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Filepath, this.StartLocation, this.Scale, this.Thickness, this.Block);
        }

        /// <inheritdoc/>
        public static Boolean operator ==(Layer left, Layer right) {
            return EqualityComparer<Layer>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static Boolean operator !=(Layer left, Layer right) {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override String ToString() {
            return $"{this.Block} at: {this.StartLocation} thickness:{this.Thickness} scale:{this.Scale} from:{this.Filepath}";
        }
    }
}
