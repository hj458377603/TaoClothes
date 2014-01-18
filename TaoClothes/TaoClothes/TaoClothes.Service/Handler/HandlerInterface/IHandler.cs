using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoClothes.Service.Handler.HandlerInterface
{
    /// <summary>
    /// 处理接口
    /// </summary>
    internal interface IHandler
    {
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        string HandleRequest();
    }
}
