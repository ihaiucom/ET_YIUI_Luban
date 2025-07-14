namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("upper")]
public class UpperCaseFormatter : INamingConventionFormatter
{
    // upper	直接将原始名全大写	aa_bb_cc => AA_BB_CC
    public string FormatName(string name)
    {
        return name.ToUpperInvariant();
    }
}
