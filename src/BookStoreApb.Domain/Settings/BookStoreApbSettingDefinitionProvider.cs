using Volo.Abp.Settings;

namespace BookStoreApb.Settings;

public class BookStoreApbSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreApbSettings.MySetting1));
    }
}
