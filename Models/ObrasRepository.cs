namespace Biblioteca.Models;

public class ObrasRepository
{
    private readonly List<Obras> obras = new() { };

    private static ObrasRepository? instance;
    private ObrasRepository() { }
    public static ObrasRepository Instance
    {
        get{
            instance ??= new ObrasRepository();
            return instance;
        }
    }
    public void Add(Obras obra)
    {
        obras.Add(obra);
    }
    public List<Obras> GetAll()
    {
        return obras;
    }
    public Obras? Get(int id)
    {
        return obras.FirstOrDefault(p => p.Id == id);
    }
}