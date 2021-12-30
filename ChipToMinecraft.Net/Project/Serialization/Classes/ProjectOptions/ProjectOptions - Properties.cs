using System;
using System.Text.Json.Serialization;

namespace Chip.Project.Serialization {
    public partial class ProjectOptions {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("concurrency")]
        public Int32 Concurrency {
            get => this._Concurrency;
            set {
                if (value < 1) {
                    this._Concurrency = Environment.ProcessorCount;
                }
                else {
                    this._Concurrency = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("multi-thread")]
        public Boolean MultiThread { get => this._MultiThread; set => this._MultiThread = value; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cache-chunks")]
        public Boolean CacheChunks { get => cacheChunks; set => cacheChunks = value; }
    }
}
