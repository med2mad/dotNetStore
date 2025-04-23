using dotNetStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotNetStore.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Produit> Produits { get; set; } = default!;
    public DbSet<CategorieProduit> CategoriesProduits { get; set; } = default!;
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
        modelBuilder.Entity<Produit>().HasData(
            new Produit { Id = 1, Nom = "Ordinateur 1", Categorie = "Ordinateurs", Prix = 980, PrixAncien = 1000, BadgeNew = true, BadgeReduction = 30, ReductionMax = true, Top = true, Photo1 = "ordinateur1-1.png", Photo2 = "ordinateur1-2.png", Photo3 = "ordinateur1-1.png", Photo4 = "ordinateur1-4.png", Description= d },
            new Produit { Id = 2, Nom = "Ordinateur 2", Categorie = "Ordinateurs", Prix = 980, PrixAncien = 1000, BadgeReduction = 30, Top = true, Photo1 = "ordinateur2-1.png", Description = d },
            new Produit { Id = 3, Nom = "Ordinateur 3", Categorie = "Ordinateurs", Prix = 980, PrixAncien = 1000, BadgeReduction = 30, ReductionMax = true, Photo1 = "ordinateur3-1.png", Photo2 = "ordinateur3-2.png", Description = d },
            new Produit { Id = 4, Nom = "Ordinateur 4", Categorie = "Ordinateurs", Prix = 980, PrixAncien = 1000, BadgeNew = true, BadgeReduction = 30, Top = true, Photo1 = "ordinateur4-1.png", Photo2 = "ordinateur4-2.png", Photo3 = "ordinateur4-3.png", Photo4 = "ordinateur4-4.png", Description = d },
            new Produit { Id = 5, Nom = "Tablette 1", Categorie = "Tablettes", Prix = 980, PrixAncien = 1000, ReductionMax = true, Photo1 = "tablette1-1.png", Photo2 = "tablette1-2.png", Description = d },
            new Produit { Id = 6, Nom = "Smartphone 1", Categorie = "Smartphones", Prix = 980, PrixAncien = 1000, BadgeNew = true, Top=true, Photo1 = "smartphone1-1.png", Description = d },
            new Produit { Id = 7, Nom = "Camera 1", Categorie = "Cameras", Prix = 980, PrixAncien = 1000, Top = true, Photo1 = "camera1-1.png", Description = d },
            new Produit { Id = 8, Nom = "Ecouteuses 1", Categorie = "Accessories", Prix = 980, PrixAncien = 1000, BadgeNew = true, ReductionMax = true, Photo1 = "ecouteuses1-1.png", Photo2 = "ecouteuses1-2.png", Photo3 = "ecouteuses1-3.png", Description = d },
            new Produit { Id = 9, Nom = "Ecouteuses 2", Categorie = "Accessories", Prix = 980, PrixAncien = 1000, ReductionMax = true, Photo1 = "ecouteuses2-1.png", Photo2 = "ecouteuses2-2.png", Description = d }
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
