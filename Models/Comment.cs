using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace Noticias.Models
{
    public class Comment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }  
    public int PostId { get; set; } 
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Body { get; set; }
}

}
