using Velaphi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Velaphi.Permissions
{
    public class VelaphiPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(VelaphiPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(VelaphiPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<VelaphiResource>(name);
        }
    }
}
