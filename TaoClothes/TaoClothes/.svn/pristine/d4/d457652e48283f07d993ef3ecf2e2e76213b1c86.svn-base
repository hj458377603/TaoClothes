using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using TaoClothes.Service;
using TaoClothes.Service.Request;

namespace TaoClothes.UI
{
    /// <summary>
    /// TaoClothes 的摘要说明
    /// </summary>
    public class TaoClothes : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string responseStr = string.Empty;

            if (context.Request.HttpMethod.ToUpper().Equals("GET"))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                string signature = context.Request["signature"];
                string timestamp = context.Request["timestamp"];
                string nonce = context.Request["nonce"];
                string echostr = context.Request["echostr"];

                dic.Add("signature", signature);
                dic.Add("timestamp", timestamp);
                dic.Add("nonce", nonce);
                dic.Add("echostr", echostr);

                HttpGetRequest request = new HttpGetRequest(dic);
                WeixinService service = new WeixinService(request);
                responseStr = service.GetResponse();
            }
            else
                if (context.Request.HttpMethod.ToUpper().Equals("POST"))
                {
                    using (Stream s = context.Request.InputStream)
                    {
                        using (StreamReader reader = new StreamReader(s, Encoding.UTF8))
                        {
                            string content = reader.ReadToEnd();

                            HttpPostRequest request = new HttpPostRequest(content);
                            WeixinService service = new WeixinService(request);
                            responseStr = service.GetResponse();
                        }
                    }
                }

            context.Response.Write(responseStr);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}