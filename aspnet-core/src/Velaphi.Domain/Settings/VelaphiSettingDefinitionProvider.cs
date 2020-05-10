using Volo.Abp.Settings;

namespace Velaphi.Settings
{
    public class VelaphiSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(VelaphiSettings.MySetting1));
        }
    }
}
