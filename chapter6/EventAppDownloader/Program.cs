using DownloaderLibEvent;

Downloader downloader=new();

void ShowMessage (object? sender, EventArgs e)
{
    Console.WriteLine("Download completed!");
}
void SaveHistory(object? sender , EventArgs e)
{
    Console.WriteLine("Download saved to history!");
}
void SendNotification(object? sender , EventArgs e)
{
    Console.WriteLine("Notification sent!");
}
downloader.DownloadCompleted += ShowMessage;
downloader.DownloadCompleted+= SaveHistory;
downloader.DownloadCompleted+= SendNotification;

downloader.CompleteDownload();