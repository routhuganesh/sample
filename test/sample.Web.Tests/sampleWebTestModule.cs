using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sample.EntityFrameworkCore;
using sample.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace sample.Web.Tests
{
    [DependsOn(
        typeof(sampleWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class sampleWebTestModule : AbpModule
    {
        public sampleWebTestModule(sampleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(sampleWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(sampleWebMvcModule).Assembly);
        }
    }
}