namespace dotNetStore.Models;

public class CategorieProduit
{
    public int Id { get; set; }
    public string Categorie { get; set; }
    public string? SousCategorie { get; set; }
    public string? Photo { get; set; }
}
