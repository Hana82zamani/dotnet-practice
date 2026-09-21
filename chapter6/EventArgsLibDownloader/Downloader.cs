namespace DownloaderLibEventArgs;

public class Downloader
{

    public event EventHandler<DownloadEventArgs>? DownloadCompleted;

    public void CompleteDownload(DownloadEventArgs e)
    {
        DownloadCompleted?.Invoke(this,e);
    }

}
public class DownloadEventArgs : EventArgs
{
    public string FileName = "";
}
