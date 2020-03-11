namespace JIT_TXBOM.ImportBusiness.MaterialTemplate
{
    public class MaterialTemplateGetListInput
    {
        /// <summary>
        /// 物料ID，即物料ItiemID字段
        /// </summary>
        public int FItemID { get; set; }

        /// <summary>
        /// 帐套ID
        /// </summary>
        public int SetBookID { get; set; }
    }
}