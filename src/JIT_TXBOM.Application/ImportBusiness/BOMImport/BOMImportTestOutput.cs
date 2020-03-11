using Abp.AutoMapper;

namespace JIT_TXBOM.ImportBusiness.BOMImport
{
    /// <summary>
    /// BOM导入返回结果
    /// </summary>
    [AutoMapFrom(typeof(BOMImportTestInput))]
    public class BOMImportTestOutput
    {
        /// <summary>
        /// BOM层级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        public string FNumber { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 单位用量
        /// </summary>
        public decimal QtyPer { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 本地对应物料编码
        /// </summary>
        public string LocalFNumber { get; set; }

        /// <summary>
        /// 是否检测通过
        /// </summary>
        public bool TestOK { get; set; }
    }
}