using System.Net;

namespace Facade;

internal class WebRequestDownloader
{
    public string DownloadContent(string url)
    {
        WebRequest webRequest = WebRequest.Create(url);
        WebResponse webResponse = webRequest.GetResponse(); 
        Stream stream = webResponse.GetResponseStream();
        StreamReader streamReader = new StreamReader(stream);
        return streamReader.ReadToEnd();
    }
}
