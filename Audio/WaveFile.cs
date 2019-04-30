using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace Audio
{
    public enum CompressionFormat
    {
        GZip
    }

    public static class WaveFile
    {
        private static string _waveFileName, _gzipFileName;
        private static FileInfo _fileInfo;

        public static void Compress(CompressionFormat compressionFormat, string waveFileName, string gzipFileName)
        {
            _waveFileName = waveFileName;
            _gzipFileName = gzipFileName;
            _fileInfo = new FileInfo(waveFileName);
            if (compressionFormat == CompressionFormat.GZip) CompressToGZip();
        }

        private static void CompressToGZip()
        {
            using (FileStream sourceFileStream = _fileInfo.OpenRead())
            using (FileStream compressedFileStream = File.Create(_fileInfo.FullName + ".gz"))
            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress)) sourceFileStream.CopyTo(compressionStream);
        }
    }
}
