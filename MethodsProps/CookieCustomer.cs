namespace CSh10.MethodsProps;

public class CookieCustomer
{
  public int Id { get; }
  private string _name;
  public string Name
  {
    get => _name;
    set
    {
      ValidateName(value, nameof(Name));
      _name = value;
    }
  }
  public CookieCustomer(int id, string name, string? notes=null)
  {
    ValidateName(name, nameof(name));
    ValidateId(id, nameof(id));
    Id = id;
    _name = name;
    Notes = notes;
  }
  public string? Notes { get; set; }

  // public string? _notes;
  // public string? Notes
  // {
  //   get => _notes;
  //   set => _notes = value;
  // }
  public char NameFirstChar => Name[0];

  private void ValidateName(string name, string paramName)
  {
    if (string.IsNullOrEmpty(name))
      throw new ArgumentException("Customer name cannot be null or whitespace", nameof(name));
  }

  private void ValidateId(int value, string paramName)
  {
    if (value <= 0)
      throw new ArgumentException($"Customer ID must be >0. Actual value was {value}", paramName);
  }

  public override string ToString() => $"Customer Id={Id}, Name={Name}";
}