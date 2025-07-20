namespace Proxy;

internal class VideoDowloader : IVideoDowloader
{

    public void DownloadVideo(string url)
    {
        Console.WriteLine($"Download video from <{url}>");
    }


}
