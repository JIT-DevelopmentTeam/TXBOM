using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace JIT_TXBOM.ImportBusiness.K3ApiUrl
{
    /// <summary>
    /// 连接管理实体
    /// </summary>
    [AutoMapFrom(typeof(K3APIUrl.K3ApiUrl))]
    [AutoMapTo(typeof(K3APIUrl.K3ApiUrl))]
    public class K3ApiUrlDTO : EntityDto
    {
        /// <summary>
        /// 连接名称（帐套名称）
        /// </summary>
        [Required(ErrorMessage = "连接名称不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 账套密钥
        /// </summary>
        [Required(ErrorMessage = "账套密钥不能为空，请联系K3系统管理员获取")]
        public string AuthorityCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}