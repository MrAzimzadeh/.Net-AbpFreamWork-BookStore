using BookStoreApb.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BookStoreApb.Permissions;

public class BookStoreApbPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStoreApbPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreApbPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreApbResource>(name);
    }
}
