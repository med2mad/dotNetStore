using dotNetStore.Data;
using dotNetStore.Models;
using Microsoft.AspNetCore.Components;

namespace dotNetStore.Components.Pages;

public partial class Index
{
    [Inject] private ApplicationDbContext _DbContext { get; set; }
    public List<Produit> Produits { get; set; }
    public List<Produit> Categories { get; set; }

    protected override void OnInitialized()
    {
        Produits = _DbContext.Produits.ToList();
    }

}
