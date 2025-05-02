namespace dotNetStore;

public class CartItem
{
    public int Id { get; set; }
    public int ProduitId { get; set; }
    public string Nom { get; set; }
    public string? Photo { get; set; }
    public decimal Prix { get; set; }
    public decimal PrixShipping { get; set; }
    public int Qte { get; set; } = 0;
    public decimal Total { get; set; }
}

public class CartService
{
    public List<CartItem> Items { get; private set; } = new List<CartItem>();

    public event Action OnCartUpdated;

    public void AddToCart(CartItem item)
    {
        var existingItem = Items.FirstOrDefault(i => i.ProduitId == item.ProduitId);
        if (existingItem != null)
        {
            existingItem.Qte += item.Qte;
            existingItem.PrixShipping += item.PrixShipping;
            existingItem.Total += item.Total;
        }
        else
            Items.Add(item);

        OnCartUpdated?.Invoke();
    }

    public void RemoveFromCart(int ProduitId)
    {
        Items.RemoveAll(i => i.ProduitId == ProduitId);
        OnCartUpdated?.Invoke();
    }
}