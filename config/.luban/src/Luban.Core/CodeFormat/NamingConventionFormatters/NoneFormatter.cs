namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("none")]
public class NoneFormatter : INamingConventionFormatter
{
    // none	保持原样	aa_bb_cc => aa_bb_cc
    public string FormatName(string name)
    {
        return name;
    }
}
