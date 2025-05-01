using System.ComponentModel.DataAnnotations;
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

        var booksPermission = myGroup.AddPermission(BookStoreApbPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookStoreApbPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookStoreApbPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookStoreApbPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = myGroup.AddPermission(
            BookStoreApbPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            BookStoreApbPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
            BookStoreApbPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
            BookStoreApbPermissions.Authors.Delete, L("Permission:Authors.Delete"));
        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreApbPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreApbResource>(name);
    }
}
