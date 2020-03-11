using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace JIT_TXBOM.LocalMaterialMapCustomMaterial
{
    /// <summary>
    /// 客户编码与本地编码对应关系
    /// </summary>
    [AutoMapFrom(typeof(LocalMaterialMapCustomMaterial))]
    [AutoMapTo(typeof(LocalMaterialMapCustomMaterial))]
    public class LocalMaterialMapCustomMaterialDTO:EntityDto
    {
        /// <summary>
        /// 客户ID
        /// </summary>
        public int CustomID { get; set; }

        /// <summary>
        /// 本地物料编码
        /// </summary>
        public string LocalFNumber { get; set; }

        /// <summary>
        /// 客户物料编码
        /// </summary>
        public string CustomFNumber { get; set; }
    }
}