using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class Center
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Threshold { get; set; }

    public Center(){
        Name = "";
        Quantity = "";
        Threshold = "";
    }
}