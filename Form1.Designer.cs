namespace SatisfactoryPAKInstaller
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.minimize = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.PictureBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.topmost = new MaterialSkin.Controls.MaterialCheckbox();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
			this.status = new MaterialSkin.Controls.MaterialLabel();
			this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.modDir = new MaterialSkin.Controls.MaterialTextBox();
			this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
			this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
			this.gameDir = new MaterialSkin.Controls.MaterialTextBox();
			this.dsadsadsadfsa = new MaterialSkin.Controls.MaterialLabel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.materialCard1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.topmost);
			this.panel1.Controls.Add(this.minimize);
			this.panel1.Controls.Add(this.close);
			this.panel1.Controls.Add(this.materialLabel1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(562, 40);
			this.panel1.TabIndex = 9;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// minimize
			// 
			this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimize.Image = global::SatisfactoryPAKInstaller.Properties.Resources.minimize_inactive;
			this.minimize.Location = new System.Drawing.Point(500, 11);
			this.minimize.Name = "minimize";
			this.minimize.Size = new System.Drawing.Size(22, 22);
			this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.minimize.TabIndex = 11;
			this.minimize.TabStop = false;
			this.minimize.Click += new System.EventHandler(this.minimize_Click);
			this.minimize.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
			this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close.Image = global::SatisfactoryPAKInstaller.Properties.Resources.close_inactive;
			this.close.Location = new System.Drawing.Point(530, 11);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(22, 22);
			this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.close.TabIndex = 9;
			this.close.TabStop = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
			this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(39, 13);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(178, 19);
			this.materialLabel1.TabIndex = 8;
			this.materialLabel1.Text = "Satisfactory Pak Installer";
			this.materialLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(5, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// topmost
			// 
			this.topmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.topmost.AutoSize = true;
			this.topmost.Checked = true;
			this.topmost.CheckState = System.Windows.Forms.CheckState.Checked;
			this.topmost.Depth = 0;
			this.topmost.Location = new System.Drawing.Point(346, 2);
			this.topmost.Margin = new System.Windows.Forms.Padding(0);
			this.topmost.MouseLocation = new System.Drawing.Point(-1, -1);
			this.topmost.MouseState = MaterialSkin.MouseState.HOVER;
			this.topmost.Name = "topmost";
			this.topmost.Ripple = true;
			this.topmost.Size = new System.Drawing.Size(142, 37);
			this.topmost.TabIndex = 10;
			this.topmost.Text = "Always On Top";
			this.topmost.UseVisualStyleBackColor = true;
			this.topmost.CheckedChanged += new System.EventHandler(this.topmost_CheckedChanged);
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
			this.materialLabel2.Location = new System.Drawing.Point(7, 6);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(152, 17);
			this.materialLabel2.TabIndex = 10;
			this.materialLabel2.Text = "Getting FG Mod Content";
			// 
			// materialCard1
			// 
			this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard1.Controls.Add(this.materialButton3);
			this.materialCard1.Controls.Add(this.gameDir);
			this.materialCard1.Controls.Add(this.dsadsadsadfsa);
			this.materialCard1.Controls.Add(this.materialButton2);
			this.materialCard1.Controls.Add(this.modDir);
			this.materialCard1.Controls.Add(this.materialLabel4);
			this.materialCard1.Controls.Add(this.materialDivider1);
			this.materialCard1.Controls.Add(this.materialLabel2);
			this.materialCard1.Depth = 0;
			this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard1.Location = new System.Drawing.Point(10, 50);
			this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
			this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard1.Name = "materialCard1";
			this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard1.Size = new System.Drawing.Size(542, 182);
			this.materialCard1.TabIndex = 11;
			// 
			// materialDivider1
			// 
			this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(5, 24);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(532, 1);
			this.materialDivider1.TabIndex = 11;
			this.materialDivider1.Text = "materialDivider1";
			// 
			// materialProgressBar1
			// 
			this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialProgressBar1.Depth = 0;
			this.materialProgressBar1.Location = new System.Drawing.Point(12, 320);
			this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialProgressBar1.Name = "materialProgressBar1";
			this.materialProgressBar1.Size = new System.Drawing.Size(537, 5);
			this.materialProgressBar1.TabIndex = 12;
			// 
			// status
			// 
			this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.status.AutoSize = true;
			this.status.Depth = 0;
			this.status.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.status.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
			this.status.Location = new System.Drawing.Point(12, 303);
			this.status.MouseState = MaterialSkin.MouseState.HOVER;
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(108, 17);
			this.status.TabIndex = 13;
			this.status.Text = "Ready to install...";
			// 
			// materialButton1
			// 
			this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.materialButton1.AutoEllipsis = true;
			this.materialButton1.AutoSize = false;
			this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.Depth = 0;
			this.materialButton1.DrawShadows = true;
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new System.Drawing.Point(392, 286);
			this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.Size = new System.Drawing.Size(148, 20);
			this.materialButton1.TabIndex = 14;
			this.materialButton1.Text = "Install Content";
			this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = true;
			this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
			this.materialLabel4.Location = new System.Drawing.Point(17, 113);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(159, 17);
			this.materialLabel4.TabIndex = 12;
			this.materialLabel4.Text = "Location of PAK and SIG:";
			// 
			// materialLabel5
			// 
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
			this.materialLabel5.Location = new System.Drawing.Point(12, 246);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(471, 29);
			this.materialLabel5.TabIndex = 15;
			this.materialLabel5.Text = "Remember, you need to have the .pak AND the .sig file from the UE4 Alpakit plugin" +
    ".\r\nIf you don\'t have both files, the application cannot and will not install the" +
    " content.";
			// 
			// modDir
			// 
			this.modDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.modDir.Depth = 0;
			this.modDir.Font = new System.Drawing.Font("Roboto", 12F);
			this.modDir.Location = new System.Drawing.Point(17, 133);
			this.modDir.MaxLength = 1000;
			this.modDir.MouseState = MaterialSkin.MouseState.OUT;
			this.modDir.Multiline = false;
			this.modDir.Name = "modDir";
			this.modDir.ReadOnly = true;
			this.modDir.Size = new System.Drawing.Size(474, 36);
			this.modDir.TabIndex = 13;
			this.modDir.Text = "";
			this.modDir.UseTallSize = false;
			// 
			// materialButton2
			// 
			this.materialButton2.AutoSize = false;
			this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton2.Depth = 0;
			this.materialButton2.DrawShadows = true;
			this.materialButton2.HighEmphasis = true;
			this.materialButton2.Icon = null;
			this.materialButton2.Location = new System.Drawing.Point(502, 140);
			this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton2.Name = "materialButton2";
			this.materialButton2.Size = new System.Drawing.Size(28, 22);
			this.materialButton2.TabIndex = 14;
			this.materialButton2.Text = "...";
			this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton2.UseAccentColor = false;
			this.materialButton2.UseVisualStyleBackColor = true;
			this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
			// 
			// materialButton3
			// 
			this.materialButton3.AutoSize = false;
			this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton3.Depth = 0;
			this.materialButton3.DrawShadows = true;
			this.materialButton3.HighEmphasis = true;
			this.materialButton3.Icon = null;
			this.materialButton3.Location = new System.Drawing.Point(502, 67);
			this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton3.Name = "materialButton3";
			this.materialButton3.Size = new System.Drawing.Size(28, 22);
			this.materialButton3.TabIndex = 17;
			this.materialButton3.Text = "...";
			this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton3.UseAccentColor = false;
			this.materialButton3.UseVisualStyleBackColor = true;
			this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
			// 
			// gameDir
			// 
			this.gameDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gameDir.Depth = 0;
			this.gameDir.Font = new System.Drawing.Font("Roboto", 12F);
			this.gameDir.Location = new System.Drawing.Point(17, 60);
			this.gameDir.MaxLength = 1000;
			this.gameDir.MouseState = MaterialSkin.MouseState.OUT;
			this.gameDir.Multiline = false;
			this.gameDir.Name = "gameDir";
			this.gameDir.Size = new System.Drawing.Size(474, 36);
			this.gameDir.TabIndex = 16;
			this.gameDir.Text = "";
			this.gameDir.UseTallSize = false;
			this.gameDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gameDir_KeyPress);
			// 
			// dsadsadsadfsa
			// 
			this.dsadsadsadfsa.AutoSize = true;
			this.dsadsadsadfsa.Depth = 0;
			this.dsadsadsadfsa.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.dsadsadsadfsa.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
			this.dsadsadsadfsa.Location = new System.Drawing.Point(17, 40);
			this.dsadsadsadfsa.MouseState = MaterialSkin.MouseState.HOVER;
			this.dsadsadsadfsa.Name = "dsadsadsadfsa";
			this.dsadsadsadfsa.Size = new System.Drawing.Size(157, 17);
			this.dsadsadsadfsa.TabIndex = 15;
			this.dsadsadsadfsa.Text = "Location of Satisfactory:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 337);
			this.Controls.Add(this.materialButton1);
			this.Controls.Add(this.materialLabel5);
			this.Controls.Add(this.status);
			this.Controls.Add(this.materialProgressBar1);
			this.Controls.Add(this.materialCard1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Satisfactory Pak Installer";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.materialCard1.ResumeLayout(false);
			this.materialCard1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox minimize;
		private System.Windows.Forms.PictureBox close;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MaterialSkin.Controls.MaterialCheckbox topmost;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialCard materialCard1;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
		private MaterialSkin.Controls.MaterialLabel status;
		private MaterialSkin.Controls.MaterialButton materialButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialTextBox modDir;
		private MaterialSkin.Controls.MaterialButton materialButton2;
		private MaterialSkin.Controls.MaterialButton materialButton3;
		private MaterialSkin.Controls.MaterialTextBox gameDir;
		private MaterialSkin.Controls.MaterialLabel dsadsadsadfsa;
	}
}

