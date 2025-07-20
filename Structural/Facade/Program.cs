// See https://aka.ms/new-console-template for more information
using Facade;


WebRequestDownloader webRequestDownloader = new WebRequestDownloader();
Console.WriteLine(webRequestDownloader.DownloadContent("https://www.wildelifecomic.com/"));