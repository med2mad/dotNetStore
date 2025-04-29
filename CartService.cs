namespace dotNetStore;

public class CartItem
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal? Prix { get; set; }
    public string? Photo { get; set; }
    public int Qte { get; set; } = 0;
}

public class CartService
{
    public List<CartItem> Items { get; private set; } = new List<CartItem>();

    public event Action OnCartUpdated;

    public void AddToCart(CartItem item)
    {
        var existingItem = Items.FirstOrDefault(i => i.Id == item.Id);
        if (existingItem != null)
            existingItem.Qte += item.Qte;
        else
            Items.Add(item);

        OnCartUpdated?.Invoke();
    }

    public void RemoveFromCart(int productId)
    {
        Items.RemoveAll(p => p.Id == productId);
        OnCartUpdated?.Invoke();
    }
}