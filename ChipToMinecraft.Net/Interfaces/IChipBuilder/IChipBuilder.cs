using System;

namespace Chip {
    ///DOLATER <summary>add description for interface: IChipBuilder</summary>
    public interface IChipBuilder {
        /// <summary>
        /// 
        /// </summary>
        public Chip.Project.Project Project { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SpecificationFile"></param>
        /// <returns></returns>
        public Boolean Process();
    }
}
