using dotNetStore.Data;
using dotNetStore.Models;
using Microsoft.AspNetCore.Components;

namespace dotNetStore.Components.Layout;

public partial class Header
{
    [Inject] private ApplicationDbContext _DbContext { get; set; }

    public List<CategorieProduit> Categories { get; set; }
    public List<Marque> Marques { get; set; }

    protected override void OnInitialized()
    {
        Categories = _DbContext.CategoriesProduits.ToList();
        Marques = _DbContext.Marques.ToList();
    }

}