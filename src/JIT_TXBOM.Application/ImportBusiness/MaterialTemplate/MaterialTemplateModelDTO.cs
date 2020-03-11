using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JIT_TXBOM.Material;

namespace JIT_TXBOM.ImportBusiness.MaterialTemplate
{
    /// <summary>
    /// 物料导入模板对象
    /// </summary>
    [AutoMapFrom(typeof(MaterialTemplateModel))]
    [AutoMapTo(typeof(MaterialTemplateModel))]
    public class MaterialTemplateModelDTO:EntityDto
    {
        /// <summary>
        /// 物料内码
        /// </summary>
        public int FItemID { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [Required(ErrorMessage = "模板名称不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 模板JSON
        /// </summary>
        [Required(ErrorMessage = "物料模板JSON不能为空")]
        public string Template { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        public string FNumber { get; set; }

        /// <summary>
        /// K3帐套ID
        /// </summary>
        public int SetBookID { get; set; }
    }
}