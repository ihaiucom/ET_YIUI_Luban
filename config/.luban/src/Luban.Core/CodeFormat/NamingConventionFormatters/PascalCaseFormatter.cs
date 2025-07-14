using Luban.Utils;

namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("pascal")]
public class PascalCaseFormatter : INamingConventionFormatter
{
    // pascal	先按'_'分割原始名，获得原子名列表，再使用Pascal风格拼成最终名	aa_bb_cc => AaBbCc
    public string FormatName(string name)
    {
        return TypeUtil.ToPascalCase(name);
    }
}
