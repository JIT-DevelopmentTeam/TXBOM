using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;

namespace JIT_TXBOM.ImportBusiness.BOMImport
{
    /// <summary>
    /// BOM导入接口服务
    /// </summary>
    public class BomImportAppServices : IApplicationService
    {
        private readonly IMapper mapper;

        private readonly IRepository<LocalMaterialMapCustomMaterial.LocalMaterialMapCustomMaterial>
            materialmapRepository;

        public BomImportAppServices(
            IRepository<LocalMaterialMapCustomMaterial.LocalMaterialMapCustomMaterial> materialmapRepository,
            IMapper mapper)
        {
            this.materialmapRepository = materialmapRepository;
            this.mapper = mapper;
        }

        /// <summary>
        ///  检查物料编码对应关系
        /// </summary>
        /// <param name="CustID">客户ID</param>
        /// <param name="input">BOM导入数据</param>
        /// <returns></returns>
        public List<BOMImportTestOutput> TestBomImportData(int CustID, List<BOMImportTestInput> input)
        {
            var resultData = new List<BOMImportTestOutput>();
            var mapList = materialmapRepository.GetAll().Where(p => p.CustomID.Equals(CustID)).ToList();

            input.ForEach(p =>
            {
                var map = mapList.SingleOrDefault(m => m.CustomFNumber.Equals(p.FNumber));

                var resultItem = mapper.Map<BOMImportTestInput, BOMImportTestOutput>(p);

                if (map != null)
                {
                    resultItem.TestOK = true;
                    resultItem.LocalFNumber = map.LocalFNumber;
                }

                resultData.Add(resultItem);
            });

            return resultData;
        }

        
    }
}