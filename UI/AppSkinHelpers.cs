using MaterialSkin;
using System.Net.NetworkInformation;

internal static class AppSkinHelper
{
    public static MaterialSkin.MaterialSkinManager msm = MaterialSkin.MaterialSkinManager.Instance;

    public static void Initialize()
    {
        msm.EnforceBackcolorOnAllComponents = true;
        ToggleDark();
    }

    public static bool IsDark()
    {
        return msm.Theme == MaterialSkinManager.Themes.DARK;
    }

    public static void ToggleDark()
    {
        if (IsDark())
        {
            msm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Amber800,
                MaterialSkin.Primary.Amber900,
                MaterialSkin.Primary.Amber200,
                MaterialSkin.Accent.Orange400,
                MaterialSkin.TextShade.BLACK);
        } else
        {
            msm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Amber800,
                MaterialSkin.Primary.Amber900,
                MaterialSkin.Primary.Amber200,
                MaterialSkin.Accent.Orange700,
                MaterialSkin.TextShade.WHITE);
        }
    }
}