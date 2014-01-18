using System.Xml;
using TaoClothes.Service.Handler.HandlerImplement;
using TaoClothes.Service.Handler.HandlerInterface;

namespace TaoClothes.Service.Handler
{
    /// <summary>
    /// 处理器工厂类
    /// </summary>
    internal class HandlerFactory
    {
        /// <summary>
        /// 创建处理器
        /// </summary>
        /// <param name="requestXml">请求的xml</param>
        /// <returns>IHandler对象</returns>
        internal static IHandler CreateHandler(string requestXml)
        {
            IHandler handler = null;
            if (!string.IsNullOrEmpty(requestXml))
            {
                //解析数据
                XmlDocument doc = new System.Xml.XmlDocument();
                doc.LoadXml(requestXml);
                XmlNode node = doc.SelectSingleNode("/xml/MsgType");
                if (node != null)
                {
                    XmlCDataSection section = node.FirstChild as XmlCDataSection;
                    if (section != null)
                    {
                        string msgType = section.Value;

                        //switch (msgType)
                        //{
                        //    case "text":
                        //        handler = new TextHandler(requestXml);
                        //        break;
                        //    //case "event":
                        //    //    handler = new EventHandler(requestXml);
                        //    //    break;
                        //    default: break;
                        //}
                        handler = new NewsHandler(requestXml);
                    }
                }
            }

            return handler;
        }
    }
}
