namespace CSh10.Oop;

public interface IPhotoProvider
{
  Image? GetPhoto();
}

public class ModelPhotoProvider : IPhotoProvider
{
  // private Image? _photo;
  private Lazy<Image?> _photo;
  private string _filePath;

  public ModelPhotoProvider(string fileName)
  {
    _filePath = DataFileFinder.GetFilePath(fileName);
    _photo = new Lazy<Image?>(() => File.Exists(_filePath) ? Image.FromFile(_filePath) : null);
  }

  public Image? GetPhoto() => _photo.Value;

  public static class PhotoProviderFactory
  {
    public static IPhotoProvider Create(string fileName)
    {
      string filePath = DataFileFinder.GetFilePath(fileName);
      if (File.Exists(filePath))
        return new ModelPhotoProvider(filePath);
      else
        return MissingPhotoProvider.Instance;
    }
  }
  // public Image? GetPhoto()
  // {
  //   if (_photo == null && File.Exists(_filePath))
  //     _photo = Image.FromFile(_filePath);
  //   return _photo;
  // }
}