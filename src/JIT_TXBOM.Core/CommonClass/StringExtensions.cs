using Abp;

namespace JIT_TXBOM.CommonClass
{
    public static class StringExtensions
    {
        public static int ToInt(this string str)
        {
            int result;
            if (int.TryParse(str,out result))
            {
                return result;
            }

            throw new AbpException($"{str} 不能转换为Int");
        }
    }
}