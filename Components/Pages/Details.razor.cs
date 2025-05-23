﻿using dotNetStore.Data;
using dotNetStore.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace dotNetStore.Components.Pages;

public partial class Details
{
    [Inject] private ApplicationDbContext _DbContext { get; set; }

    [Parameter] public int Id { get; set; }

    public Produit Produit { get; set; }
    public List<Produit> RelatedProducts { get; set; }

    protected override void OnInitialized()
    {
        Produit = _DbContext.Produits.Include(p => p.Categorie).FirstOrDefault(p => p.Id == Id);
        RelatedProducts = _DbContext.Produits.Include(p => p.Categorie).Where(p => p.Categorie.Categorie == Produit.Categorie.Categorie).ToList();
    }
}
