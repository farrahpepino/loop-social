namespace server.Services{
    public interface IJwtService
    {
        string GenerateToken(string userId, string username, string email);
    }
}