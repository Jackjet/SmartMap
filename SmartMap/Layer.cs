using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart.Map
{
    /// <summary>
    /// 图层
    /// </summary>
    public class Layer
    {
        /// <summary>
        /// 图层名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图层比例1:X
        /// </summary>
        public float Scale { get; set; }

        /// <summary>
        /// 瓦片区域
        /// </summary>
        public LayerArea Area { get; set; }
    }
}
