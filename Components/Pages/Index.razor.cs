using dotNetStore.Data;
using dotNetStore.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace dotNetStore.Components.Pages;

public partial class Index
{
    [Inject] private ApplicationDbContext _DbContext { get; set; }

    public List<Produit> Produits { get; set; }
    public List<Produit> ReductionsFolles { get; set; }
    public List<Produit> TopVentes { get; set; }
    public List<Produit> Autres1 { get; set; }
    public List<Produit> Autres2 { get; set; }
    public List<Produit> Autres3 { get; set; }
    int AutresColumns1 = 0; int AutresColumns2 = 0; int AutresColumns3 = 0;

    protected override void OnInitialized()
    {
        Produits = _DbContext.Produits.Include(p => p.Categorie).Where(p => p.ReductionFolle || p.TopVente || p.Autre1 || p.Autre2 || p.Autre3).ToList();
        ReductionsFolles = Produits.Where(p => p.ReductionFolle).ToList();
        TopVentes = Produits.Where(p => p.TopVente).ToList();
        Autres1 = Produits.Where(p => p.Autre1).ToList();
        Autres2 = Produits.Where(p => p.Autre2).ToList();
        Autres3 = Produits.Where(p => p.Autre3).ToList();

        AutresColumns1 = Autres1.Count / 3;
        AutresColumns2 = Autres2.Count / 3;
        AutresColumns3 = Autres3.Count / 3;
    }
}
