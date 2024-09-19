using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


// server

namespace Lesson5HTTP;

class WebHost
{
    private int _port;

    private HttpListener _listener;

    public WebHost(int port)
    {
        _port = port;
    }

    public void Run()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add($"http://localhost:{_port}/");
        _listener.Start();

        Console.WriteLine($"Http server started on {_port}");

        while (true)
        {
            var context = _listener.GetContext();

            Task.Run(() => { HandleRequest(context); });
        }
    }

    private void HandleRequest(HttpListenerContext context)
    {
        var str = context.Request.RawUrl; // /home

        var path = string.Empty;

        if (str.Split('.').Last() == "jpg")
        {
            path = @$"C:\Users\namiqrasullu\Desktop\FBMS_1_23_4_az_SP_NP\Network Programming\Lesson5HTTP\Lesson5HTTP\Images\{str?.Split('/').Last()}";
        }
        else
        {
            path = @$"C:\Users\namiqrasullu\Desktop\FBMS_1_23_4_az_SP_NP\Network Programming\Lesson5HTTP\Lesson5HTTP\Views\{str?.Split('/').Last()}.html";
        }

        var response = context.Response;

        var stream = response.OutputStream;
        try
        {

            if (Path.GetExtension(path) == ".jpg")
                response.ContentType = "image/jpg";
            var src = File.ReadAllBytes(path);
            stream.Write(src);
        }
        catch
        {
            var src = File.ReadAllBytes(@"C:\Users\namiqrasullu\Desktop\FBMS_1_23_4_az_SP_NP\Network Programming\Lesson5HTTP\Lesson5HTTP\Views\NotFoundPage.html");
            stream.Write(src);
        }
        finally
        {
            stream.Close();
        }

    }
}


class Program
{
    private async static Task Main(string[] args)
    {
        //new WebHost(27001).Run();

        var client = new HttpClient();

        //var str = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        //Console.WriteLine(str);

        var json = JsonSerializer.Serialize(new Post { Id = 10001, body = "kjdshfjksdlfhk", Title = "ashjdkja", UserId = 1 });

        var content = new StringContent(json);

        var result = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);

        if (result.IsSuccessStatusCode)
        {
            await Console.Out.WriteLineAsync("element ugurla gonderildi");
            var r = await result.Content.ReadAsStringAsync();
            await Console.Out.WriteLineAsync(r);
        }

        


    }
}


class Post
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]

    public string Title { get; set; }

    [JsonPropertyName("body")]
    public string body { get; set; }

    [JsonPropertyName("userId")]
    public int UserId { get; set; }
}
