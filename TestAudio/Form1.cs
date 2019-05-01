using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Audio;

namespace TestAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Title = "Select a Wave File", CheckFileExists = true, CheckPathExists = true, DefaultExt = "wav", Filter = "wav files (*.wav)|*.wav", RestoreDirectory = true };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var waveFileName = dialog.FileName;
            var gzipFileName = waveFileName + ".gz";
            WaveFile.Compress(CompressionFormat.GZip, waveFileName, gzipFileName);
            FileInfo sourceFileInfo = new FileInfo(waveFileName);
            FileInfo targetFileInfo = new FileInfo(gzipFileName);
            var msg = $"Compressed {sourceFileInfo.Name} from {sourceFileInfo.Length.ToString()} to {targetFileInfo.Length.ToString()} bytes.";
            MessageBox.Show(msg, Text);
        }

        private void decompressButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Title = "Select a GZip File", CheckFileExists = true, CheckPathExists = true, DefaultExt = "gz", Filter = "GZip files (*.gz)|*.gz", RestoreDirectory = true };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var gzipFileName = dialog.FileName;
            var waveFileName = gzipFileName + ".wav";
            GZipFile.Decompress(DecompressionFormat.Wave, gzipFileName, waveFileName);
            FileInfo sourceFileInfo = new FileInfo(gzipFileName);
            FileInfo targetFileInfo = new FileInfo(waveFileName);
            var msg = $"Decompressed {sourceFileInfo.Name} from {sourceFileInfo.Length.ToString()} to {targetFileInfo.Length.ToString()} bytes.";
            MessageBox.Show(msg, Text);
        }

        private void compressWaveToMP3Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Title = "Select a Wave File", CheckFileExists = true, CheckPathExists = true, DefaultExt = "wav", Filter = "wav files (*.wav)|*.wav", RestoreDirectory = true };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var waveFileName = dialog.FileName;
            var targetFile = waveFileName + ".mp3";
            WaveFile.Compress(CompressionFormat.MP3, waveFileName, targetFile);
            FileInfo sourceFileInfo = new FileInfo(waveFileName);
            FileInfo targetFileInfo = new FileInfo(targetFile);
            var msg = $"Compressed {sourceFileInfo.Name} from {sourceFileInfo.Length.ToString()} to {targetFileInfo.Length.ToString()} bytes.";
            MessageBox.Show(msg, Text);
        }

        private void decompressMP3toWaveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Title = "Select a MP3 File", CheckFileExists = true, CheckPathExists = true, DefaultExt = "mp3", Filter = "MP3 files (*.mp3)|*.mp3", RestoreDirectory = true };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var sourceFileName = dialog.FileName;
            var waveFileName = sourceFileName + ".wav";
            MP3File.Decompress(DecompressionFormat.Wave, sourceFileName, waveFileName);
            FileInfo sourceFileInfo = new FileInfo(sourceFileName);
            FileInfo targetFileInfo = new FileInfo(waveFileName);
            var msg = $"Decompressed {sourceFileInfo.Name} from {sourceFileInfo.Length.ToString()} to {targetFileInfo.Length.ToString()} bytes.";
            MessageBox.Show(msg, Text);
        }
    }
}
