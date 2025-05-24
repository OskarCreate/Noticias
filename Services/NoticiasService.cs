using Noticias.Models;

public class NoticiasService
{
    private readonly HttpClient _http;

    public NoticiasService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Post>> ObtenerPosts()
    {
        return await _http.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts") ?? new();
    }

    public async Task<Post?> ObtenerPost(int id)
    {
        return await _http.GetFromJsonAsync<Post>($"https://jsonplaceholder.typicode.com/posts/{id}");
    }

    public async Task<User?> ObtenerUsuario(int id)
    {
        return await _http.GetFromJsonAsync<User>($"https://jsonplaceholder.typicode.com/users/{id}");
    }

    public async Task<List<Comment>> ObtenerComentarios(int postId)
    {
        return await _http.GetFromJsonAsync<List<Comment>>($"https://jsonplaceholder.typicode.com/comments?postId={postId}") ?? new();
    }
}

