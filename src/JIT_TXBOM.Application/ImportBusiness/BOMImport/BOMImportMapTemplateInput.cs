using System.ComponentModel.DataAnnotations;

namespace JIT_TXBOM.ImportBusiness.BOMImport
{
    /// <summary>
    /// BOM导入对应模板映身对象
    /// </summary>
    public class BOMImportMapTemplateInput:BOMImportTestOutput
    {
        /// <summary>
        /// 对应模板ID，由用户在前端选定对应模板
        /// </summary>

        [Required]
        public int MaterialTemplateID { get; set; }
    }
}