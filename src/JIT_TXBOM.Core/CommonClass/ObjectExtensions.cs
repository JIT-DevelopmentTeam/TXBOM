using Newtonsoft.Json;

namespace JIT_TXBOM.CommonClass
{
    /// <summary>
    /// 基类的扩展方法集合
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// 把对象实例转换为JSON字符串
        /// </summary>
        /// <param name="obj">对象实现</param>
        /// <returns>序列化后的JSON字符串</returns>
        public static string ToJsonStr(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }
}