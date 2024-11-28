using System.Net.NetworkInformation;

internal static class AppSkin
{
    public static MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

    public static void Initialize()
    {
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
            MaterialSkin.Primary.Indigo500,
            MaterialSkin.Primary.Indigo700,
            MaterialSkin.Primary.Indigo100,
            MaterialSkin.Accent.Pink200,
            MaterialSkin.TextShade.WHITE);
    }
}