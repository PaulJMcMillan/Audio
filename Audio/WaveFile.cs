using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using NAudio.Lame;
using NAudio.Wave;

namespace Audio
{
    public enum CompressionFormat
    {
        GZip,
        MP3
    }

    public static class WaveFile
    {
        private static string _waveFileName, _targetFileName;
        private static FileInfo _fileInfo;

        public static void Compress(CompressionFormat compressionFormat, string waveFileName, string targetFileName)
        {
            _waveFileName = waveFileName;
            _targetFileName = targetFileName;
            _fileInfo = new FileInfo(waveFileName);
            if (compressionFormat == CompressionFormat.GZip) CompressToGZip();
            if (compressionFormat == CompressionFormat.MP3) CompressToMP3();
        }

        private static void CompressToMP3()
        {
            var bitRate = 128;
            using (var reader = new AudioFileReader(_waveFileName))
            using (var writer = new LameMP3FileWriter(_targetFileName, reader.WaveFormat, bitRate)) reader.CopyTo(writer);
        }

        private static void CompressToGZip()
        {
            using (FileStream sourceFileStream = _fileInfo.OpenRead())
            using (FileStream compressedFileStream = File.Create(_fileInfo.FullName + ".gz"))
            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress)) sourceFileStream.CopyTo(compressionStream);
        }
    }
}
