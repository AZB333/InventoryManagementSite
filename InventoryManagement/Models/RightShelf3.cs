using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class RightShelf3
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public RightShelf3(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}