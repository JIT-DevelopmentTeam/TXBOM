using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace JIT_TXBOM.K3APIUrl
{
    /// <summary>
    /// K3API连接信息对象
    /// </summary>
    public class K3ApiUrl:Entity
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

        public string Token { get; set; }

        public DateTime TokenExpiredTime { get; set; }
    }
}