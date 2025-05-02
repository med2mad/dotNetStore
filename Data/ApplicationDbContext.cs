using dotNetStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotNetStore.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Produit> Produits { get; set; } = default!;
    public DbSet<CategorieProduit> CategoriesProduits { get; set; } = default!;
    public DbSet<Marque> Marques { get; set; } = default!;
    public DbSet<Facture> Factures { get; set; } = default!;
    public DbSet<Commande> Commandes { get; set; } = default!;

    string d = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Ignore soft deleted entries in filters
        modelBuilder.Entity<Produit>().HasQueryFilter(p => !p.IsDeleted);
        modelBuilder.Entity<Facture>().HasQueryFilter(p => !p.IsDeleted);

        //Seed first data
        modelBuilder.Entity<CategorieProduit>().HasData(
            new CategorieProduit { Id = 1, Categorie = "Ordinateurs", SousCategorie = "" },
            new CategorieProduit { Id = 2, Categorie = "Tablettes", SousCategorie = "" },
            new CategorieProduit { Id = 3, Categorie = "Smartphones", SousCategorie = "" },
            new CategorieProduit { Id = 4, Categorie = "Cameras", SousCategorie = "" },
            new CategorieProduit { Id = 5, Categorie = "Accessories", SousCategorie = "" }
        );
        modelBuilder.Entity<Marque>().HasData(
            new Marque { Id = 1, Nom = "SAMSUNG" },
            new Marque { Id = 2, Nom = "LG" },
            new Marque { Id = 3, Nom = "SONY" }
        );
        modelBuilder.Entity<Produit>().HasData(
            new Produit { Id = 1, Nom = "Ordinateur 1", CategorieId = 1, Prix = 900, PrixAncien = 1000, PrixShipping = 90, BadgeNew = true, BadgeReduction = 30, ReductionFolle = true, TopVente = true, Autre1 = true, Autre3 = true, Photo1 = "seed/ordinateur1-1.png", Photo2 = "seed/ordinateur1-2.png", Photo3 = "seed/ordinateur1-3.png", Photo4 = "seed/ordinateur1-4.png", Description = d, MarqueId = 2 },
            new Produit { Id = 2, Nom = "Ordinateur 2", CategorieId = 1, Prix = 800, PrixAncien = 900, PrixShipping = 80, BadgeReduction = 30, TopVente = true, Autre1 = true, Autre2 = true, Photo1 = "seed/ordinateur2-1.png", Description = d, MarqueId = 4 },
            new Produit { Id = 3, Nom = "Ordinateur 3", CategorieId = 1, Prix = 700, PrixAncien = 800, PrixShipping = 70, BadgeReduction = 30, ReductionFolle = true, Autre1 = true, Autre3 = true, Photo1 = "seed/ordinateur3-1.png", Photo2 = "seed/ordinateur3-2.png", Description = d, MarqueId = 3 },
            new Produit { Id = 4, Nom = "Ordinateur 4", CategorieId = 1, Prix = 600, PrixAncien = 700, PrixShipping = 60, BadgeNew = true, BadgeReduction = 30, TopVente = true, Autre2 = true, Autre3 = true, Photo1 = "seed/ordinateur4-1.png", Photo2 = "seed/ordinateur4-2.png", Photo3 = "seed/ordinateur4-3.png", Photo4 = "seed/ordinateur4-4.png", Description = d, MarqueId = 1 },
            new Produit { Id = 5, Nom = "Tablette 1", CategorieId = 2, Prix = 500, PrixAncien = 600, PrixShipping = 50, ReductionFolle = true, Autre2 = true, Autre3 = true, Photo1 = "seed/tablette1-1.png", Photo2 = "seed/tablette1-2.png", Description = d, MarqueId = 3 },
            new Produit { Id = 6, Nom = "Smartphone 1", CategorieId = 3, Prix = 400, PrixAncien = 500, PrixShipping = 40, BadgeNew = true, TopVente = true, Autre1 = true, Autre2 = true, Photo1 = "seed/smartphone1-1.png", Photo2 = "seed/smartphone1-2.png", Photo3 = "seed/smartphone1-3.png", Photo4 = "seed/smartphone1-4.png", Description = d, MarqueId = 1 },
            new Produit { Id = 7, Nom = "Camera 1", CategorieId = 4, Prix = 300, PrixAncien = 400, PrixShipping = 30, TopVente = true, Autre1 = true, Autre2 = true, Photo1 = "seed/camera1-1.png", Description = d, MarqueId = 1 },
            new Produit { Id = 8, Nom = "Ecouteuses 1", CategorieId = 5, Prix = 200, PrixAncien = 300, PrixShipping = 20, BadgeNew = true, ReductionFolle = true, Autre1 = true, Autre3 = true, Photo1 = "seed/ecouteuses1-1.png", Photo2 = "seed/ecouteuses1-2.png", Photo3 = "seed/ecouteuses1-3.png", Description = d, MarqueId = 2 },
            new Produit { Id = 9, Nom = "Ecouteuses 2", CategorieId = 5, Prix = 100, PrixAncien = 200, PrixShipping = 10, ReductionFolle = true, Autre2 = true, Autre3 = true, Photo1 = "seed/ecouteuses2-1.png", Photo2 = "seed/ecouteuses2-2.png", Description = d, MarqueId = 3 }
        );
    }

    /////////////soft delete/////////////
    public override int SaveChanges()
    {
        SoftDeleteEntities();
        return base.SaveChanges();
    }
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        SoftDeleteEntities();
        return await base.SaveChangesAsync(cancellationToken);
    }
    private void SoftDeleteEntities()
    {
        foreach (var entry in ChangeTracker.Entries()
                     .Where(e => e.State == EntityState.Deleted &&
                                 e.Entity is ISoftDeletable))
        {
            entry.State = EntityState.Modified;
            ((ISoftDeletable)entry.Entity).IsDeleted = true;
        }
    }

}
