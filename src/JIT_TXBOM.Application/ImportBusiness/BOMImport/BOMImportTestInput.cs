using System.ComponentModel.DataAnnotations;

namespace JIT_TXBOM.ImportBusiness.BOMImport
{
    /// <summary>
    /// BOM导入对象
    /// </summary>
    public class BOMImportTestInput
    {
        /// <summary>
        /// BOM层级
        /// </summary>
        [Required]
        public int Level { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        [Required]
        public string FNumber { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 单位用量
        /// </summary>
        [Required]
        public decimal QtyPer { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        

    }
}