using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using sample.Configuration.Dto;

namespace sample.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : sampleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
