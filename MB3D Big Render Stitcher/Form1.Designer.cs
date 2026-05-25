namespace MB3D_Big_Render_Stitcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDirectory = new TextBox();
            btnGo = new Button();
            btnBrowse = new Button();
            groupBox1 = new GroupBox();
            lblStitchDimsWH = new Label();
            lblStitchDims = new Label();
            lblTileDimsWH = new Label();
            lblTileDims = new Label();
            lblTilesXY = new Label();
            lblTiles = new Label();
            txtTileName = new TextBox();
            lblTileName = new Label();
            lstLog = new ListBox();
            lblLog = new Label();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(12, 40);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(556, 23);
            txtDirectory.TabIndex = 0;
            txtDirectory.Text = "I:\\Mandelbulb 3D sttuff\\Parameters\\rainbow spire";
            // 
            // btnGo
            // 
            btnGo.Enabled = false;
            btnGo.Location = new Point(523, 80);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackgroundImage = Properties.Resources.icons8_file_explorer_48;
            btnBrowse.BackgroundImageLayout = ImageLayout.Stretch;
            btnBrowse.Location = new Point(574, 40);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(24, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStitchDimsWH);
            groupBox1.Controls.Add(lblStitchDims);
            groupBox1.Controls.Add(lblTileDimsWH);
            groupBox1.Controls.Add(lblTileDims);
            groupBox1.Controls.Add(lblTilesXY);
            groupBox1.Controls.Add(lblTiles);
            groupBox1.Controls.Add(txtTileName);
            groupBox1.Controls.Add(lblTileName);
            groupBox1.Location = new Point(11, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 149);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tile Info";
            // 
            // lblStitchDimsWH
            // 
            lblStitchDimsWH.AutoSize = true;
            lblStitchDimsWH.Location = new Point(108, 112);
            lblStitchDimsWH.Name = "lblStitchDimsWH";
            lblStitchDimsWH.Size = new Size(31, 15);
            lblStitchDimsWH.TabIndex = 7;
            lblStitchDimsWH.Text = "0 x 0";
            // 
            // lblStitchDims
            // 
            lblStitchDims.AutoSize = true;
            lblStitchDims.Location = new Point(2, 112);
            lblStitchDims.Name = "lblStitchDims";
            lblStitchDims.Size = new Size(100, 15);
            lblStitchDims.TabIndex = 6;
            lblStitchDims.Text = "Final Dimensions:";
            // 
            // lblTileDimsWH
            // 
            lblTileDimsWH.AutoSize = true;
            lblTileDimsWH.Location = new Point(108, 86);
            lblTileDimsWH.Name = "lblTileDimsWH";
            lblTileDimsWH.Size = new Size(31, 15);
            lblTileDimsWH.TabIndex = 5;
            lblTileDimsWH.Text = "0 x 0";
            // 
            // lblTileDims
            // 
            lblTileDims.AutoSize = true;
            lblTileDims.Location = new Point(9, 86);
            lblTileDims.Name = "lblTileDims";
            lblTileDims.Size = new Size(93, 15);
            lblTileDims.TabIndex = 4;
            lblTileDims.Text = "Tile Dimensions:";
            // 
            // lblTilesXY
            // 
            lblTilesXY.AutoSize = true;
            lblTilesXY.Location = new Point(108, 62);
            lblTilesXY.Name = "lblTilesXY";
            lblTilesXY.Size = new Size(102, 15);
            lblTilesXY.TabIndex = 3;
            lblTilesXY.Text = "0 rows, 0 columns";
            // 
            // lblTiles
            // 
            lblTiles.AutoSize = true;
            lblTiles.Location = new Point(69, 62);
            lblTiles.Name = "lblTiles";
            lblTiles.Size = new Size(33, 15);
            lblTiles.TabIndex = 2;
            lblTiles.Text = "Tiles:";
            // 
            // txtTileName
            // 
            txtTileName.Location = new Point(108, 30);
            txtTileName.Name = "txtTileName";
            txtTileName.Size = new Size(179, 23);
            txtTileName.TabIndex = 1;
            // 
            // lblTileName
            // 
            lblTileName.AutoSize = true;
            lblTileName.Location = new Point(60, 33);
            lblTileName.Name = "lblTileName";
            lblTileName.Size = new Size(42, 15);
            lblTileName.TabIndex = 0;
            lblTileName.Text = "Name:";
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(326, 109);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(272, 139);
            lstLog.TabIndex = 5;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(326, 91);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(27, 15);
            lblLog.TabIndex = 6;
            lblLog.Text = "Log";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(523, 276);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 311);
            Controls.Add(btnExit);
            Controls.Add(lblLog);
            Controls.Add(lstLog);
            Controls.Add(groupBox1);
            Controls.Add(btnBrowse);
            Controls.Add(btnGo);
            Controls.Add(txtDirectory);
            Name = "Form1";
            Text = "MB3D Big Render Stitcher";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDirectory;
        private Button btnGo;
        private Button btnBrowse;
        private GroupBox groupBox1;
        private Label lblTilesXY;
        private Label lblTiles;
        private TextBox txtTileName;
        private Label lblTileName;
        private Label lblStitchDimsWH;
        private Label lblStitchDims;
        private Label lblTileDimsWH;
        private Label lblTileDims;
        private ListBox lstLog;
        private Label lblLog;
        private Button btnExit;
    }
}
