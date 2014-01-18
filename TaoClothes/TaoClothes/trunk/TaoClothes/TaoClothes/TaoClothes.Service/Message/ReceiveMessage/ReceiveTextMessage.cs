using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaoClothes.Service.Request;

namespace TaoClothes.Service.Message.ReceiveMessage
{
    /// <summary>
    /// 接收的文本消息
    /// </summary>
    internal class ReceiveTextMessage : ReceiveMessageBase
    {
        #region 字段

        /// <summary>
        /// 内容
        /// </summary>
        internal string Content { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        internal ReceiveTextMessage(string xmlString)
        {
            this.MsgType = "text";
            Init(xmlString);
        }

        #endregion

        #region 方法
        /// <summary>
        ///  初始化
        /// </summary>
        /// <param name="xmlString">xml数据源</param>
        internal override void Init(string xmlString)
        {
            if (!string.IsNullOrEmpty(xmlString))
            {
                XElement element = XElement.Parse(xmlString);
                if (element != null)
                {
                    this.FromUserName = element.Element(ConstString.CONST_FROM_USERNAME).Value;
                    this.ToUserName = element.Element(ConstString.CONST_TO_USERNAME).Value;
                    this.CreateTime = element.Element(ConstString.CONST_CREATE_TIME).Value;
                    this.Content = element.Element(ConstString.CONST_CONTENT).Value;
                    this.MsgId = element.Element(ConstString.CONST_MSG_ID).Value;
                }
            }
        }
        #endregion
    }
}
