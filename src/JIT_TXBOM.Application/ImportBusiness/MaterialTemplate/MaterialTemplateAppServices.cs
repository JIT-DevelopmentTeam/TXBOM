using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using JIT_TXBOM.Material;

namespace JIT_TXBOM.ImportBusiness.MaterialTemplate
{
    /// <summary>
    /// 物料模板管理接口
    /// </summary>
    public class MaterialTemplateAppServices : CrudAppService<MaterialTemplateModel, MaterialTemplateModelDTO>
    {
        public MaterialTemplateAppServices(IRepository<MaterialTemplateModel, int> repository) : base(repository)
        {

        }

        /// <summary>
        /// 通过物料ID获取物料模板
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<MaterialTemplateModel> GetByFItemID(MaterialTemplateGetListInput input)
        {
            var result = Repository.GetAll().Where(p => p.FItemID.Equals(input.FItemID)&&p.SetBookID.Equals(input.SetBookID)).ToList();

            return result;
        }
    }
}