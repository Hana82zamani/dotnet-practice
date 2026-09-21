namespace DownloaderLibEvent;

public class Downloader
{
    public event EventHandler?DownloadCompleted;

    public void CompleteDownload()
    {
        DownloadCompleted?.Invoke(this, EventArgs.Empty);
    }

}
