using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class RightShelf6
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public RightShelf6(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}