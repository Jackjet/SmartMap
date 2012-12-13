using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart.Map
{
    /// <summary>
    /// 增量
    /// </summary>
    public class Incremental
    {
        /// <summary>
        /// 增量值
        /// </summary>
        public float Increment { get; set; }

        /// <summary>
        /// 增量类型
        /// </summary>
        public IncrementalType IncrementalType { get; set; }
    }
}
