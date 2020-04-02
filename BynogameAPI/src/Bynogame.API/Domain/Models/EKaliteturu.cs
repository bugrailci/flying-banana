using System.ComponentModel;

namespace BYNOGAME.API.Domain.Models
{
    public enum EKaliteturu : byte
    {
        [Description("FN")]
        Factory_new = 1,

        [Description("WW")]
        Well_worn = 2,

        [Description("MR")]
        Mid_Range = 3,

        [Description("BS")]
        Battle_scarred = 4
    }
}