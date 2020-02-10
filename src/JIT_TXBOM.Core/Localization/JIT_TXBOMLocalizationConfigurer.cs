using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace JIT_TXBOM.Localization
{
    public static class JIT_TXBOMLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(JIT_TXBOMConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(JIT_TXBOMLocalizationConfigurer).GetAssembly(),
                        "JIT_TXBOM.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
