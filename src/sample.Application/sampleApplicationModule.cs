using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sample.Authorization;

namespace sample
{
    [DependsOn(
        typeof(sampleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class sampleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<sampleAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(sampleApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
