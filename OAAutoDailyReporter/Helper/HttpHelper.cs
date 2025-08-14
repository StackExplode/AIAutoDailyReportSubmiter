using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO.Compression;

namespace OAAutoDailyReporter.Helper;
internal class HttpHelper
{
    public async static Task<string> PostJSON(string url, string data, string? auth = null)
    {
        string host = new Uri(url).Host;
        using (var client = new System.Net.Http.HttpClient())
        {
            if(auth is not null)
                client.DefaultRequestHeaders.Add("Authorization", auth);
            client.DefaultRequestHeaders.Add("Host", host);
            //client.DefaultRequestHeaders.Add("Content-Type", new MediaTypeWithQualityHeaderValue( "application/json").ToString());
            //client.DefaultRequestHeaders.Add("Content-Length", Encoding.UTF8.GetBytes(data).Length.ToString());
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            var content = new System.Net.Http.StringContent(data, Encoding.UTF8, "application/json");
            var response =  await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var encoding = response.Content.Headers.ContentEncoding;
                if(encoding is null || encoding.Count < 1)
                    return await response.Content.ReadAsStringAsync();
                else
                {
                    var contentStream = response.Content.ReadAsStream();
                    foreach (var method in response.Content.Headers.ContentEncoding.Reverse())
                    {
                        contentStream = method switch
                        {
                            "gzip" => new GZipStream(contentStream, CompressionMode.Decompress),
                            "deflate" => new DeflateStream(contentStream, CompressionMode.Decompress),
                            "br" => new BrotliStream(contentStream, CompressionMode.Decompress),
                            _ => throw new NotSupportedException(),
                        };
                    }
                    string rt = new StreamReader(contentStream).ReadToEnd();
                    return rt;
                }
            }
            else
            {
                throw new Exception($"HTTP POST failed with status code: {response.StatusCode}");
            }
        }
    }
}
