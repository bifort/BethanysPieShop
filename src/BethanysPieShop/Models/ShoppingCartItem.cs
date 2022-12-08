namespace BethanysPieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        
        public Pie Pie { get; set; } = default!; // null-forgiving operator - declares that Pie isn't null
        
        public int Amount { get; set; }

        public string? ShoppingCartId { get; set; }
    }
}
