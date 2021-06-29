using System;
using System.Collections;
using System.Collections.Generic;

namespace Chip.Minecraft {
    public partial struct Range : IEnumerable<Int32> {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return new RangeEnumerator(this);
        }

        /// <summary>
        /// 
        /// </summary>
        public class RangeEnumerator : IEnumerator<Int32> {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="r"></param>
            public RangeEnumerator(Range r) {
                this._data = r;
                this._index = r.Start;
            }

            /// <summary>
            /// 
            /// </summary>
            private Range _data;

            /// <summary>
            /// 
            /// </summary>
            private Int32 _index;



            public Int32 Current => this._index;

            Object IEnumerator.Current => this._index;

            public void Dispose() { }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public Boolean MoveNext() {
                this._index++;

                return this._index <= this._data.End;
            }

            /// <summary>
            /// 
            /// </summary>
            public void Reset() {
                this._index = this._data.Start;
            }
        }
    }
}
