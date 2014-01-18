using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaoClothes.DAL.Dao;
using TaoClothes.Entity;

namespace TaoClothes.UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string goodsId = string.Empty;
            if (Request.QueryString.AllKeys.Contains("goodsId"))
            {
                goodsId = Request["goodsId"];
            }
            else
            {
                // 默认展示16号商品
                goodsId = "16";
            }
            #region 商品基本属性

            GoodsDao dao = new GoodsDao();
            Goods goods = dao.SelectByGoodsId(goodsId);
            this.productName.Text = goods.goods_name;
            this.marketPrice.Text = goods.market_price.ToString();
            this.price.Text = goods.shop_price.ToString();
            this.storeNum.Text = goods.goods_number.ToString();
            this.productPic.Src = "http://www.womanquan.com/" + goods.goods_img;

            // 商品描述
            string str = goods.goods_desc;
            string regexPattern = "<img";
            Regex regex = new Regex(regexPattern);
            MatchCollection matches = regex.Matches(str);

            // 给商品详情描述中的图片添加宽度已适应不同分辨率屏幕要求
            // 商品描述只能维护图片
            foreach (Match item in matches)
            {
                str = str.Replace(item.Value, "<img width='100%'");
            }
            this.descriptionContent.InnerHtml = str;

            #endregion

            #region 商品附加属性
            GoodsAttrDao goodsAttrDap = new GoodsAttrDao();
            List<GoodsAttr> attrs = goodsAttrDap.SelectByGoodsId(goodsId);
            this.ColorList.DataSource = attrs.Where(item => item.attr_id == 3).ToList();
            this.ColorList.DataBind();
            this.SizeList.DataSource = attrs.Where(item => item.attr_id == 4).ToList();
            this.SizeList.DataBind();
            #endregion
        }
    }
}