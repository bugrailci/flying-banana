using System.ComponentModel;

namespace BYNOGAME.API.Domain.Models
{
    public enum EKaliteturu : byte
    {
        [Description("FN")]
        factory_new = 1,

        [Description("MW")]
        minimal_wear = 2,

        [Description("WW")]
        well_worn = 3,

        [Description("FT")]
        field_tested = 4,

        [Description("BS")]
        battle_scarred = 5,

    }
}