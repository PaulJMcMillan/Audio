using NAudio.Wave;

namespace Audio
{
    public class MP3File
    {
        private static string _sourceFileName;
        private static string _waveFileName;

        public static void Decompress(DecompressionFormat decompressionFormat, string sourceFileName, string waveFileName)
        {
            _sourceFileName = sourceFileName;
            _waveFileName = waveFileName;
            if (decompressionFormat == DecompressionFormat.Wave) DecompressToWaveFile();
        }

        private static void DecompressToWaveFile()
        {
            using (var reader = new Mp3FileReader(_sourceFileName))
            using (var writer = new WaveFileWriter(_waveFileName, reader.WaveFormat)) reader.CopyTo(writer);
        }
    }
}