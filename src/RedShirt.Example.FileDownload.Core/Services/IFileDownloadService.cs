using RedShirt.Example.FileDownload.Core.Models;

namespace RedShirt.Example.FileDownload.Core.Services;

public interface IFileDownloadService
{
    Task<FileDownloadReport> DownloadAsync(string fromPath, string writePath,
        CancellationToken cancellationToken = default);
}