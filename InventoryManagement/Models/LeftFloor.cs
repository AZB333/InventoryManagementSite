using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class LeftFloor
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public LeftFloor(){
        Name = "default";
        Quantity = "default";
        Threshold = "default";
    }
}