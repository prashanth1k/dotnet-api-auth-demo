public class User
{
  public int Id { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
  public string? Name { get; set; }
  public string? Role { get; set; }
  public string? Token { get; set; }
  public string? RefreshToken { get; set; }
  public DateTime TokenExpires { get; set; }
  public DateTime RefreshTokenExpires { get; set; }
  public List<Post>? Posts { get; set; }
}