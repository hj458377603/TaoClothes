using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoClothes.Service.Message.SendMessage
{
    /// <summary>
    /// 发送的消息
    /// </summary>
    internal abstract class SendMessageBase : MessageBase
    {
        #region 字段

        /// <summary>
        /// Xml发送消息模板
        /// </summary>
        protected string XmlTemplate { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// 生成Xml内容
        /// </summary>
        /// <returns></returns>
        internal abstract string GenerateXmlContent();

        #endregion
    }
}
