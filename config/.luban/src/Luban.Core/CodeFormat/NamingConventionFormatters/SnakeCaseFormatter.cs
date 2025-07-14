using Luban.Utils;

namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("snake")]
public class SnakeCaseFormatter : INamingConventionFormatter
{
    // snake	下划线风格，等同于none风格	aa_bb_cc => aa_bb_cc
    public string FormatName(string name)
    {
        return TypeUtil.ToUnderScores(name);
    }
}
