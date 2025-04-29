using dotNetStore.Data;
using dotNetStore.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace dotNetStore.Components.Pages;

public partial class Filtres
{
    [Inject] private ApplicationDbContext _DbContext { get; set; }
    [Inject] private IJSRuntime _JSRuntime { get; set; }

    [Parameter] public string SearchText { get; set; } = "";
    [Parameter] public int MarqueId { get; set; }
    [Parameter] public int CategorieId { get; set; }

    private List<Produit> Produits { get; set; }
    private List<Produit> ProduitsFiltres { get; set; }
    public List<Produit> TopVentes { get; set; }
    public List<CategorieProduit> Categories { get; set; }
    public List<Marque> Marques { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Produits = await _DbContext.Produits.Include(p => p.Categorie).ToListAsync();
            TopVentes = await _DbContext.Produits.Where(p => p.TopVente).Take(3).ToListAsync();
            Categories = await _DbContext.CategoriesProduits.ToListAsync();
            Marques = await _DbContext.Marques.Include(c => c.Produits).ToListAsync();

            if (CategorieId > 0)
                SelectedCategories.Add(CategorieId);
            if (MarqueId > 0)
                SelectedMarques.Add(MarqueId);

            SelectedPrixMax = (int)Math.Ceiling(Produits.Max(p => p.Prix) ?? 9999);

            FiltreProduits();

            dotNetReference = DotNetObjectReference.Create(this);
            await _JSRuntime.InvokeVoidAsync("initializeInterop", dotNetReference);
            await _JSRuntime.InvokeVoidAsync("initializeScripts", SelectedPrixMax, dotNetReference);
        }
    }


    private void FiltreProduits()
    {
        IEnumerable<Produit> query = Produits;
        //Filter
        query = query.Where(p => p.Prix >= SelectedPrixMin);
        query = query.Where(p => p.Prix <= SelectedPrixMax);
        if (SelectedCategories.Count > 0)
            query = query.Where(p => SelectedCategories.Contains(p.CategorieId ?? 0));
        if (SelectedMarques.Count > 0)
            query = query.Where(p => SelectedMarques.Contains(p.MarqueId ?? 0));
        if (!string.IsNullOrWhiteSpace(SearchText))
            query = query.Where(p => p.Nom.ToLower().Contains(SearchText.ToLower()));
        //Sort
        if (Sort == "Nom")
            if (Order == "ASC")
                query = query.OrderBy(p => p.Nom);
            else
                query = query.OrderByDescending(p => p.Nom);
        else if (Sort == "Prix")
            if (Order == "ASC")
                query = query.OrderBy(p => p.Prix);
            else
                query = query.OrderByDescending(p => p.Prix);
        else if (Sort == "Categorie")
            if (Order == "ASC")
                query = query.OrderBy(p => p.Categorie?.Categorie ?? p.Nom);
            else
                query = query.OrderByDescending(p => p.Categorie?.Categorie ?? p.Nom);
        else if (Sort == "Marque")
            if (Order == "ASC")
                query = query.OrderBy(p => p.Marque?.Nom ?? p.Nom);
            else
                query = query.OrderByDescending(p => p.Marque?.Nom ?? p.Nom);
        else
        {
            if (Order == "ASC")
                query = query.OrderBy(p => p.Id);
            else
                query = query.OrderByDescending(p => p.Id);
        }

        Pages = (int)Math.Ceiling((decimal)query.Count() / PerPage);

        ProduitsFiltres = query.Skip((CurrentPage - 1) * PerPage).Take(PerPage).ToList();
        if (ProduitsFiltres.Count == 0)
        {//on last pages then increment "Perpage" can return no entries
            CurrentPage = 1;
            ProduitsFiltres = query.Skip((CurrentPage - 1) * PerPage).Take(PerPage).ToList();
        }

        StateHasChanged();
    }
}
