using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class LeftShelf5
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public LeftShelf5(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}