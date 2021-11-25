using Volo.Abp.Settings;

namespace Acme.MoviesPlatform.Settings
{
    public class MoviesPlatformSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MoviesPlatformSettings.MySetting1));
        }
    }
}
