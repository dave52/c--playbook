namespace CSh10.Oop;

public class ModelBase
{
  private string _otherInfo = "";
  public string Name { get; }
  public int Id { get; }
  public IPhotoProvider PhotoProvider { get; }

  public ModelBase(int id, string name, string photoFileName)
  {
    Id = id;
    Name = name;
    PhotoProvider = PhotoProviderFactory.Create(photoFileName);
  }

  public override string ToString() => Name;
}