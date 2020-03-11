using System.Collections.Generic;
using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace JIT_TXBOM.LocalMaterialMapCustomMaterial
{
    public class LocalMaterialMapCustomMaterial:Entity
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