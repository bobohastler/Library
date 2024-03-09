namespace LibraryWinForm.Forms;

public static class FontSettings
{
    private static readonly string FontFamily = "Segoe UI";
    private static readonly float SmallSize = 8f;
    private static readonly float RegularSize = 14f;
    private static readonly float LargeSize = 24f;
    
    public static Font Regular => new Font(FontFamily, RegularSize, FontStyle.Regular, GraphicsUnit.Point);
    public static Font LargeRegular => new Font(FontFamily, LargeSize, FontStyle.Regular, GraphicsUnit.Point);
    public static Font SmallRegular => new Font(FontFamily, SmallSize, FontStyle.Regular, GraphicsUnit.Point);
    public static Font Bold => new Font(FontFamily, RegularSize, FontStyle.Bold, GraphicsUnit.Point);
    public static Font LargeBold => new Font(FontFamily, LargeSize, FontStyle.Bold, GraphicsUnit.Point);
    public static Font SmallBold => new Font(FontFamily, SmallSize, FontStyle.Bold, GraphicsUnit.Point);
    public static Font Italic => new Font(FontFamily, RegularSize, FontStyle.Italic, GraphicsUnit.Point);
    public static Font LargeItalic => new Font(FontFamily, LargeSize, FontStyle.Italic, GraphicsUnit.Point);
    public static Font SmallItalic => new Font(FontFamily, SmallSize, FontStyle.Italic, GraphicsUnit.Point);
    
}