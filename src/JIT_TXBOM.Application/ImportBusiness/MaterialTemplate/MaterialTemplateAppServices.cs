using Abp.Application.Services;
using Abp.Domain.Repositories;
using JIT_TXBOM.Material;

namespace JIT_TXBOM.ImportBusiness.MaterialTemplate
{
    public class MaterialTemplateAppServices : CrudAppService<MaterialTemplateModel, MaterialTemplateModelDTO>
    {
        public MaterialTemplateAppServices(IRepository<MaterialTemplateModel, int> repository) : base(repository)
        {

        }
    }
}