using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class LeftShelf1
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public LeftShelf1(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}