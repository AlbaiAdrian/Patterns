namespace Proxy;

internal class VideoDownloaderProxy : IVideoDowloader
{
    private readonly IVideoDowloader _videoDownloader;
    private static readonly List<string> _urls = new List<string>();
    internal VideoDownloaderProxy(IVideoDowloader videoDownloader)
    {
        _videoDownloader = videoDownloader;
    }

    public void DownloadVideo(string url)
    {
        if (_urls.Any(u => u == url))
        {
            Console.WriteLine($"Video from <{url}> downloaded from cache!");
            return;
        }

        _videoDownloader.DownloadVideo(url);
        _urls.Add(url); 
    }
}
