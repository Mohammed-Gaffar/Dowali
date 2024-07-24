using FilesServiceReference;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Dowali.UI.Helpers
{
    public class ManageFiles
    {
        private bool disposed;

        // Instantiate a SafeHandle instance.
        private readonly SafeHandle resource = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                resource.Dispose();
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.
            disposed = true;
        }

        private FileClient Client;

        public async Task<string> Upload(IFormFile file)
        {
            try
            {
                var bytesUpload = new byte[file.Length];
                file.OpenReadStream().Read(bytesUpload, 0, Convert.ToInt32(file.Length));

                var PostedData = new UploadFileModel()
                {
                    ApplicationName = "Dowali",
                    ContentLength = Convert.ToInt32(file.Length),
                    ContentType = file.ContentType,
                    FileName = string.Format("{0}{1}", Guid.NewGuid().ToString(), Path.GetExtension(file.FileName).ToLower()),
                    InputStream = bytesUpload
                };

                Client = new FileClient();
                var result = await Client.UploadAsync(PostedData);

                return result == "File Uploaded Successfully" ? PostedData.FileName : result;
            }
            catch (Exception ex)
            {
                return ex.Message.Contains("denied") ? "You do not have permissions to upload the file" : "Can not upload file";
            }
        }

        public async Task<byte[]> GetFileInBytes(string FileName)
        {
            Client = new FileClient();
            return await Client.DownloadBytesAsync(new FileModel()
            {
                ApplicationName = "Dowali",
                FileName = FileName
            });
        }

        public async Task<string> View(string FileName)
        {
            Client = new FileClient();
            return await Client.ViewAsync(new FileModel()
            {
                ApplicationName = "Dowali",
                FileName = FileName
            });
        }
    }
}

