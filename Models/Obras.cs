namespace Biblioteca.Models;

public class Obras {
    public int Id {get; set;}
    public string Titulo {get; set;}
    public string Editora {get; set;}
    public string Foto {get; set;}
    public List<string> Autores {get; set;}

    public Obras(int id, string titulo, string editora, string foto, List<string> autores)
    {
        this.Id = id;
        this.Titulo = titulo;
        this.Editora = editora;
        this.Foto = foto;
        this.Autores = autores;
    }
}