using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class LeftShelf3
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public LeftShelf3(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}