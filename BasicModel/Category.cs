using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModel
{
    public class Category
    {
        public int CategoryID { get; set; }

        /// <summary>
        /// 栏目类型
        /// 0-常规栏目；1-单页；2-外部链接
        /// </summary>
        public int CategoryType { get; set; }

        /// <summary>
        /// 父栏目ID
        /// 顶级栏目的父栏目ID为0
        /// </summary>
        public int ParentID { get; set; }

        /// <summary>
        /// 栏目深度
        /// 【表示栏目所在的层次，根栏目为0，以此类推】
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// 栏目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 栏目说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 栏目顺序【同级栏目数字越小越靠前】
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 打开方式
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// 栏目状态
        /// 0-隐藏；1-正常；2-删除
        /// </summary>
        public int Status { get; set; }

    }
}
