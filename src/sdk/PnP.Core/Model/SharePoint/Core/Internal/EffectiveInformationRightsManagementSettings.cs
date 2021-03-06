using Microsoft.Extensions.Logging;
using PnP.Core.Services;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// EffectiveInformationRightsManagementSettings class, write your custom code here
    /// </summary>
    [SharePointType("SP.EffectiveInformationRightsManagementSettings", Target = typeof(IFile))]
    internal partial class EffectiveInformationRightsManagementSettings
    {
        public EffectiveInformationRightsManagementSettings()
        {
            MappingHandler = (FromJson input) =>
            {
                // implement custom mapping logic
                switch (input.TargetType.Name)
                {
                    case "SettingSource": return JsonMappingHelper.ToEnum<SPEffectiveInformationRightsManagementSettingsSource>(input.JsonElement);
                }

                input.Log.LogDebug(PnPCoreResources.Log_Debug_JsonCannotMapField, input.FieldName);

                return null;
            };
        }
    }
}
