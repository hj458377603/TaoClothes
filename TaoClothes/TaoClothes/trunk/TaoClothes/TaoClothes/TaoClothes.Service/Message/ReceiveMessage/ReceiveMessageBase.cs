
namespace TaoClothes.Service.Message.ReceiveMessage
{
    /// <summary>
    /// 接收的消息
    /// </summary>
    internal abstract class ReceiveMessageBase : MessageBase
    {
        #region 字段
        /// <summary>
        /// 消息ID
        /// </summary>
        internal string MsgId { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        internal ReceiveMessageBase() { }

        internal ReceiveMessageBase(string xmlString)
        {
            Init(xmlString);
        }
        #endregion

        #region 方法

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="xmlString"></param>
        internal abstract void Init(string xmlString);
        #endregion
    }
}
