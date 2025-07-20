// See https://aka.ms/new-console-template for more information
using Proxy;

IVideoDowloader videoDowloader = new VideoDowloader();
IVideoDowloader videoDownloaderProxy = new VideoDownloaderProxy(videoDowloader);
videoDownloaderProxy.DownloadVideo("url");
videoDownloaderProxy.DownloadVideo("url1");
videoDownloaderProxy.DownloadVideo("url");
Console.ReadLine();