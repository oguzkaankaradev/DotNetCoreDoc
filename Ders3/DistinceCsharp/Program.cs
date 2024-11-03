// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static async Task<int> GetPageLengthAsync(string endpont)
{
    var client = new HttpClient();
    var uri = new Uri(endpont);
    byte[] content = await client.GetByteArrayAsync(uri);
    return content.Length;
}


