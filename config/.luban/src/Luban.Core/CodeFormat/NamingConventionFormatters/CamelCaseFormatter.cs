using Luban.Utils;

namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("camel")]
public class CamelCaseFormatter : INamingConventionFormatter
{
    // camel	先按'_'分割原始名，获得原子名列表，再使用Camel风格拼成最终名	aa_bb_cc => aaBbCc
    public string FormatName(string fieldName)
    {
        return TypeUtil.ToCamelCase(fieldName);
    }
}
