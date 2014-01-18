using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Entity;

namespace TaoClothes.DAL.Dao
{
    public class GoodsAttrDao
    {
        public List<GoodsAttr> SelectByGoodsId(string goodsId)
        {
            List<GoodsAttr> goodsAttrs = Mapper.GetMaper.QueryForList<GoodsAttr>("ecs_goods_attr.SelectBygoods_id", goodsId).ToList();
            return goodsAttrs;
        }
    }
}
