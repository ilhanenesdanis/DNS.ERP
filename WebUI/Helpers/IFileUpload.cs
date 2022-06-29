namespace WebUI.Helpers
{
    public interface IFileUpload
    {
        string FileUpload(IFormFile file);
        string DeleteImage(string Name);
        string UpdateFile(IFormFile file, string Name);
        List<string> FileListUpload(List<IFormFile> files);
        //string ConvertToWebP(IFormFile file); TODO:Webp Dönüştürme Araştırılacak
    }
}
