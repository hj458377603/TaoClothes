using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Entity;

namespace TaoClothes.DAL.Dao
{
    public class GoodsDao
    {
        public Goods SelectByGoodsId(string goodsId)
        {
            Goods goods = Mapper.GetMaper.QueryForObject("ecs_goods.SelectBygoods_id", goodsId) as Goods;
            return goods;
        }
    }
}
