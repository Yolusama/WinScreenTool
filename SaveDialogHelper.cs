using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace ScreenTools;

public static class SaveDialogHelper
{
    private static readonly String[] supportFormats = new String[] { ".png",".jpg", ".jpeg",".jpe",".jfif",".bmp" };
    private static readonly String[] jpegFormats = new String[] { ".jpg", ".jpe", ".jfif"};
    
    private static String Format(string suffix){
        foreach (var format in supportFormats)
        {
            Regex regex = new Regex(format, RegexOptions.IgnoreCase);
            if (regex.IsMatch(suffix))
            {
                return format;
            }
        }

        return supportFormats.First();
    }

    public static void OpenToSaveImage(Image image)
    {
        SaveFileDialog dialog = new SaveFileDialog();
        dialog.Filter = "PNG(*.png)|*.png|JPEG(*.jpeg;*.jpg;*.jpe;*jfif)|*.jpg;*.jpeg;*.jpe;*jfif|BMP(*.bmp)|*.bmp";
        dialog.Title = "保存";
        string savePath = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
        dialog.FileName = savePath + " ScreenShot(屏幕截图)";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            string suffix = dialog.FileName.Substring(dialog.FileName.LastIndexOf('.'));
            String format = Format(suffix);
            
            ImageFormat formatType = ImageFormat.Png;
            if(jpegFormats.Contains(format))
                formatType = ImageFormat.Jpeg;
            else if (format == ".png")
                formatType = ImageFormat.Png;
            else
                formatType = ImageFormat.Bmp;
            image.Save(dialog.FileName, formatType);
        }
    }
}