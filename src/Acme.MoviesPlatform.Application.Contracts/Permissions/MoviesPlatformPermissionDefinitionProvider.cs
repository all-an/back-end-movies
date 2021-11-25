using Acme.MoviesPlatform.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.MoviesPlatform.Permissions
{
    public class MoviesPlatformPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MoviesPlatformPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(MoviesPlatformPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MoviesPlatformResource>(name);
        }
    }
}
