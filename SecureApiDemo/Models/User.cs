namespace SecureApiDemo.Models
{
public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = "User";
    public string Email { get; set; } = string.Empty; // ✅ Bu satır OLMAK ZORUNDA
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }
}
}