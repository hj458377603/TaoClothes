using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Service.Request;

namespace TaoClothes.Service.Message.SendMessage
{
    internal class SendNewsMessage : SendMessageBase
    {
        #region 字段

        /// <summary>
        /// 图文消息个数，限制为10条以内
        /// </summary>
        internal int ArticleCount { get; private set; }

        /// <summary>
        /// 多条图文消息信息，默认第一个item为大图,注意，如果图文数超过10，则将会无响应
        /// </summary>
        internal List<Article> Articles { get; set; }

        #endregion

        #region 构造方法

        /// <summary>
        /// 构造方法
        /// </summary>
        internal SendNewsMessage()
        {
            Init();
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        internal SendNewsMessage(string toUserName, string fromUserName, string content)
        {
            Init();
        }
        #endregion

        #region 方法

        /// <summary>
        /// 生成Xml格式发送消息
        /// </summary>
        /// <returns></returns>
        internal override string GenerateXmlContent()
        {
            this.CreateTime = CommonHelper.GetNowTime();
            this.MsgType = "news";

            StringBuilder articlesStringBuilder = new StringBuilder();

            if (this.Articles != null)
            {
                this.ArticleCount = this.Articles.Count > 10 ? 10 : this.Articles.Count;

                if (this.Articles.Count > 10)
                {
                    this.Articles = this.Articles.Take(10).ToList();
                }

                //                @"<item>
                //                    <Title><![CDATA[{0}]]></Title> 
                //                    <Description><![CDATA[{1}]]></Description>
                //                    <PicUrl><![CDATA[{2}]]></PicUrl>
                //                    <Url><![CDATA[{3}]]></Url>
                //                </item>";
                string itemTemplate = @"<item><Title><![CDATA[{0}]]></Title><Description><![CDATA[{1}]]></Description><PicUrl><![CDATA[{2}]]></PicUrl><Url><![CDATA[{3}]]></Url></item>";

                foreach (var item in Articles)
                {
                    articlesStringBuilder.Append(string.Format(itemTemplate, item.Title, item.Description, item.PicUrl, item.Url));
                }
            }

            return string.Format(this.XmlTemplate, this.ToUserName, this.FromUserName, this.CreateTime, this.MsgType, this.ArticleCount, articlesStringBuilder.ToString());
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            //            @"<xml>
            //                <ToUserName><![CDATA[{0}]]></ToUserName>
            //                <FromUserName><![CDATA[{1}]]></FromUserName>
            //                <CreateTime>{2}</CreateTime>
            //                <MsgType><![CDATA[{3}]]></MsgType>
            //                <ArticleCount>{4}</ArticleCount>
            //                <Articles>
            //                    {5}
            //                </Articles>
            //            </xml>
            this.XmlTemplate = @"<xml><ToUserName><![CDATA[{0}]]></ToUserName><FromUserName><![CDATA[{1}]]></FromUserName><CreateTime>{2}</CreateTime><MsgType><![CDATA[{3}]]></MsgType><ArticleCount>{4}</ArticleCount><Articles>{5}</Articles></xml> ";

            this.Articles = new List<Article>();
        }

        #endregion
    }
}
