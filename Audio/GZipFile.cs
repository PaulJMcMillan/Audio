using System;
using System.IO;
using System.IO.Compression;

namespace Audio
{
    public enum DecompressionFormat
    {
        Wave
    }

    public static class GZipFile
    {
        private static string _gzipFileName;
        private static string _waveFileName;

        public static void Decompress(DecompressionFormat decompressionFormat, string gzipFileName, string waveFileName)
        {
            _gzipFileName = gzipFileName;
            _waveFileName = waveFileName;
            if (decompressionFormat == DecompressionFormat.Wave) DecompressToWaveFile();
        }

        private static void DecompressToWaveFile()
        {
            var fileToDecompress = new FileInfo(_gzipFileName);
            using (FileStream sourceFileStream = fileToDecompress.OpenRead())
            using (FileStream decompressedFileStream = File.Create(_waveFileName))
            using (GZipStream decompressionStream = new GZipStream(sourceFileStream, CompressionMode.Decompress)) decompressionStream.CopyTo(decompressedFileStream);
        }
    }
}