using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;

namespace JIT_TXBOM.LocalMaterialMapCustomMaterial
{
    /// <summary>
    /// 本地物料编码与客户物料编码对应关系管理接口
    /// </summary>
    public class LocalMaterialMapCustomMaterialAppServices:CrudAppService<LocalMaterialMapCustomMaterial,LocalMaterialMapCustomMaterialDTO>
    {
        public LocalMaterialMapCustomMaterialAppServices(IRepository<LocalMaterialMapCustomMaterial, int> repository) : base(repository)
        {
        }

        /// <summary>
        /// 根据物料编码获取对应关系
        /// </summary>
        /// <param name="FNumber">物料编码</param>
        /// <returns></returns>
        public List<LocalMaterialMapCustomMaterialDTO> GetByLocalItemFumber(string FNumber)
        {
            var data = Repository.GetAll().Where(p => p.LocalFNumber.Equals(FNumber)).ToList();

            List<LocalMaterialMapCustomMaterialDTO> result = new List<LocalMaterialMapCustomMaterialDTO>();

            foreach (var item in data)
            {
                var resultItem=new LocalMaterialMapCustomMaterialDTO();

                resultItem= ObjectMapper.Map<LocalMaterialMapCustomMaterial, LocalMaterialMapCustomMaterialDTO>(item,resultItem);

                result.Add(resultItem);
            }
            

            return result;
        }
    }
}