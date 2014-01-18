using TaoClothes.Service.Handler.HandlerInterface;
using TaoClothes.Service.Message.ReceiveMessage;
using TaoClothes.Service.Message.SendMessage;

namespace TaoClothes.Service.Handler.HandlerImplement
{
    /// <summary>
    /// 文本信息处理
    /// </summary>
    internal class TextHandler : IHandler
    {
        #region 字段

        /// <summary>
        /// 请求的XML
        /// </summary>
        private string RequestXml { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="requestXml">请求的xml</param>
        internal TextHandler(string requestXml)
        {
            this.RequestXml = requestXml;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        public string HandleRequest()
        {
            ReceiveTextMessage receiveTextMessage = new ReceiveTextMessage(this.RequestXml);
            SendTextMessage sendTextMessage = new SendTextMessage();
            sendTextMessage.ToUserName = receiveTextMessage.FromUserName;
            sendTextMessage.FromUserName = receiveTextMessage.ToUserName;
            sendTextMessage.Content = "测试发送文本消息";
            return sendTextMessage.GenerateXmlContent();
        }

        #endregion
    }
}
