using System.Threading.Tasks;
using sample.Configuration.Dto;

namespace sample.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
