/****************************************
** 文件名: ecs_goods_attr.cs
** 作者: Jun
** 创建时间: 2014/1/17 10:26:51
****************************************/

using System;

namespace TaoClothes.Entity
{
    /// <summary>
    /// 商品属性类
    /// </summary>
    public class GoodsAttr
    {
        #region goods_attr_id
        /// <summary>
        /// 
        /// </summary>
        public int goods_attr_id
        {
            set;
            get;
        }
        #endregion

        #region goods_id
        /// <summary>
        /// 
        /// </summary>
        public int goods_id
        {
            set;
            get;
        }
        #endregion

        #region attr_id
        /// <summary>
        /// 
        /// </summary>
        public Int16 attr_id
        {
            set;
            get;
        }
        #endregion

        #region attr_value
        /// <summary>
        /// 
        /// </summary>
        public string attr_value
        {
            set;
            get;
        }
        #endregion

        #region attr_price
        /// <summary>
        /// 
        /// </summary>
        public string attr_price
        {
            set;
            get;
        }
        #endregion

    }
}


