using DownloaderLibEventArgs;

Downloader downloader = new();

DownloadEventArgs eventArg = new()
{
    FileName = "Movie.mp4"
};
void Downloader_DownloadCompleted(object? sender,DownloadEventArgs e)
{
    if (sender is not Downloader d)return;

    Console.WriteLine($"{e.FileName}");

}

downloader.DownloadCompleted+= Downloader_DownloadCompleted;

downloader.CompleteDownload(eventArg);
