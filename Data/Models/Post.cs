using System.ComponentModel.DataAnnotations.Schema;

public class Post
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public required string Content { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  [ForeignKey("User")]
  public int UserId { get; set; }
  public User? User { get; set; }
}