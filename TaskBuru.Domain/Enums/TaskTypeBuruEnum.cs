using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBuru.Domain.Enums
{
    public enum TaskTypeBuruEnum
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
