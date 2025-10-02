using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class RightFloor
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public RightFloor(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}