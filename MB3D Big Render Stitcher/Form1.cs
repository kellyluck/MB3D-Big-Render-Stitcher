using System.Reflection;
using System.Text.RegularExpressions;

namespace MB3D_Big_Render_Stitcher
{
    public partial class Form1 : Form
    {
        List<ImageTIle> _imageTiles = new List<ImageTIle>();
        string _stitchName = "";
        int _stitchWidth = 0, _stitchHeight = 0, _tileWidth = 0, _tileHeight = 0, _maxX = 0, _maxY = 0;
        bool _stitchInfoReady = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanFiles();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Stitch();
        }

        private void Stitch()
        {
            using Bitmap stitchedImage = new Bitmap(_stitchWidth, _stitchHeight);
            using Graphics g = Graphics.FromImage(stitchedImage);
            foreach (var tile in _imageTiles)
            {
                Log($"Now stitching {tile.X}, {tile.Y}...");
                using Bitmap tileImage = new Bitmap(tile.FilePath);
                int destX = (tile.X - 1) * _tileWidth;
                int destY = (tile.Y - 1) * _tileHeight;
                g.DrawImage(tileImage, destX, destY, _tileWidth, _tileHeight);
            }
            string outputFileName = $"{txtTileName.Text}.png";
            string outputPath = Path.Combine(txtDirectory.Text, outputFileName);
            stitchedImage.Save(outputPath);
            Log($"Stitching complete!");
        }

        private void ScanFiles()
        {
            _imageTiles = GetImageTiles(txtDirectory.Text);

            if (_imageTiles.Count == 0)
            {
                MessageBox.Show("No PNG files found in the specified directory.");
                Log("No PNG files found in the specified directory.");
                return;
            }

            Log($"{_imageTiles.Count} PNG files found. Processing...");
            GetStitchInfo();
            btnGo.Enabled = _stitchInfoReady;
        }

        private void Log(string message)
        {
            lstLog.Items.Add(message);
            lstLog.SelectedIndex = lstLog.Items.Count - 1; // Scroll to the latest log entry
        }

        private void GetStitchInfo()
        {
            string firstTile = _imageTiles[0].FilePath;
            _stitchName = Path.GetFileNameWithoutExtension(firstTile).Split('X')[0];

            using (var stream = new FileStream(firstTile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] buffer = new byte[24];
                if (stream.Read(buffer, 0, 24) == 24)
                {
                    // Verify it is a valid PNG file by checking the signature
                    if (buffer[0] == 0x89 && buffer[1] == 0x50 && buffer[2] == 0x4E && buffer[3] == 0x47)
                    {
                        // PNG dimensions are stored as big-endian 32-bit integers
                        _tileWidth = (buffer[16] << 24) | (buffer[17] << 16) | (buffer[18] << 8) | buffer[19];
                        _tileHeight = (buffer[20] << 24) | (buffer[21] << 16) | (buffer[22] << 8) | buffer[23];

                    }
                }
            }

            foreach (var tile in _imageTiles)
            {
                if (tile.X > _maxX) _maxX = tile.X;
                if (tile.Y > _maxY) _maxY = tile.Y;
            }

            _stitchWidth = _tileWidth * _maxX;
            _stitchHeight = _tileHeight * _maxY;

            txtTileName.Text = _stitchName;
            lblTilesXY.Text = $"{_maxY} rows, {_maxX} columns";
            lblTileDimsWH.Text = $"{_tileWidth} x {_tileHeight}";
            lblStitchDimsWH.Text = $"{_stitchWidth} x {_stitchHeight}";
            _stitchInfoReady = true;
            Log("Processing complete. Ready to Go!");
        }

        List<ImageTIle> GetImageTiles(string directory)
        {
            List<ImageTIle> tiles = new List<ImageTIle>();
            string[] files = Directory.GetFiles(directory, "*.png");
            foreach (string file in files)
            {
                if (!file.Contains("ZBuf")) // don't do ZBuf files (yet)
                {
                    ImageTIle imageTIle = new ImageTIle();

                    imageTIle.FilePath = Path.GetFullPath(file);
                    string justFileName = Path.GetFileNameWithoutExtension(file);
                    Match coordinates = Regex.Match(imageTIle.FilePath, @"X(?<first>\d+)Y(?<second>\d+)\.");
                    string x = coordinates.Groups["first"].Value;
                    string y = coordinates.Groups["second"].Value;
                    if (!string.IsNullOrEmpty(x) && !string.IsNullOrEmpty(y))
                    {
                        int xInt, yInt;
                        if (int.TryParse(x, out xInt) && int.TryParse(y, out yInt))
                        {
                            imageTIle.X = xInt;
                            imageTIle.Y = yInt;
                            tiles.Add(imageTIle);
                        }
                    }
                }
            }
            return tiles;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!string.IsNullOrEmpty(txtDirectory.Text) && Directory.Exists(txtDirectory.Text))
            {
                documentsPath = txtDirectory.Text;
            }

            using var dialog = new FolderBrowserDialog();
            dialog.Description = "Select the directory with the tiles";
            dialog.UseDescriptionForTitle = true; // Shows the description as the window title
            dialog.InitialDirectory = documentsPath; // Optional starting path

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = dialog.SelectedPath;
                txtDirectory.Text = selectedFolder;
                ScanFiles();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
