using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaoClothes.Service;
using System.Web;
using System.Net;
using TaoClothes.Service.Utility;
using System.Web.Routing;
using System.IO;
using TaoClothes.Service.Request;
using System.Collections.Generic;
using TaoClothes.DAL.Dao;
using TaoClothes.Entity;

namespace TaoClothes.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckSignature()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("name", "jun");
            dic.Add("signature", "babb2bb874eb3f8304f6d69987bf7b62c2837e18");
            dic.Add("timestamp", "1341554");
            dic.Add("nonce", "523");
            dic.Add("echostr", "good");
            HttpGetRequest request = new HttpGetRequest(dic);

            WeixinService service = new WeixinService(request);
            string responseStr = service.GetResponse();
            return;
        }

        [TestMethod]
        public void TestGetTextMessage()
        {
            string content = @"<xml>
                                   <ToUserName><![CDATA[toUser]]></ToUserName>
                                   <FromUserName><![CDATA[fromUser]]></FromUserName> 
                                   <CreateTime>1348831860</CreateTime>
                                   <MsgType><![CDATA[text]]></MsgType>
                                   <Content><![CDATA[this is a test]]></Content>
                                   <MsgId>1234567890123456</MsgId>
                               </xml>";
            HttpPostRequest request = new HttpPostRequest(content);
            WeixinService service = new WeixinService(request);
            string responseStr = service.GetResponse();
            return;
        }

        [TestMethod]
        public void TestGetGoodsById()
        {
            GoodsDao dao = new GoodsDao();
            Goods goods = dao.SelectByGoodsId("1");

            return;
        }

        [TestMethod]
        public void TestGetGoodsAttrsByGoodsId()
        {
            GoodsAttrDao goodsAttrDap = new GoodsAttrDao();
            List<GoodsAttr> attrs = goodsAttrDap.SelectByGoodsId("16");

            return;
        }
    }
}
