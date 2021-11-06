using System;

namespace Chip {
    ///DOLATER <summary>add description for interface: IChipBuilder</summary>
    public interface IChipBuilder {
        /// <summary>
        /// 
        /// </summary>
        public BuilderOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SpecificationFile"></param>
        /// <returns></returns>
        public Boolean Process(System.String SpecificationFile);
    }
}
