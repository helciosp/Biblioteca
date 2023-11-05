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
    public Obras? Update(Obras obra)
    {
        int index = obras.FindIndex(p => p.Id == obra.Id);
        if(index == -1)
            return null;
        obras[index] = obra;
        return obras[index];
    }
    public void Delete(Obras obra)
    {
        obras.Remove(obra);
    }
}