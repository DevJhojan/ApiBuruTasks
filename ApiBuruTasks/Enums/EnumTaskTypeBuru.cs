using System.ComponentModel;

namespace ApiBuruTasks.Enums
{
    public enum EnumTaskTypeBuru
    {
        [Description("Import But Urgent")]
        IMPORT_URGENT,
        [Description("Import But Not Urgent")]
        IMPORT_NOT_URGENT,
        [Description("Not Import But Urgent")]
        NOT_IMPORT_URGENT,
        [Description("Not Import Not Urgent")]
        NOT_IMPORT_NOT_URGENT,
    }
}
