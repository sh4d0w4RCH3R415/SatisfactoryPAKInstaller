using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using DropShadow;

using SatisfactoryPAKInstaller.Properties;

namespace SatisfactoryPAKInstaller
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DropShadowCS shadow = new DropShadowCS();
			shadow.CreateWNDParams(CreateParams);
			shadow.CreateDropShadow(this);

			topmost.Checked = Settings.Default.TopMost;
			TopMost = topmost.Checked;

			gameDir.Text = Settings.Default.GameDirectory;
		}

		#region Pre-Made Window Handling Code | DO NOT TOUCH/MODIFY
		[DllImport("user32")]
		private static extern bool ReleaseCapture();

		[DllImport("user32")]
		private static extern int SendMessage(IntPtr handle, int msg, int wp, int lp);

		private void ChangeImage(PictureBox picBox, Image newImage)
		{
			picBox.Image = newImage;
		}
		private void ResizeWindow(int htborder)
		{
			ReleaseCapture();
			SendMessage(Handle, 161, htborder, 0);
		}
		private void close_Click(object sender, EventArgs e)
		{
			Timer t = new Timer { Interval = 1 };
			t.Tick += delegate (object sender_, EventArgs e_)
			{
				Opacity -= .025d;
				if (Opacity <= 0)
				{
					t.Enabled = false;
					Close();
				}
			};
			t.Start();
		}
		private void minimize_Click(object sender, EventArgs e)
		{
			Timer t = new Timer { Interval = 1 };
			t.Tick += delegate (object sender_, EventArgs e_)
			{
				Opacity -= .025d;
				if (Opacity <= 0)
				{
					t.Enabled = false;
					WindowState = FormWindowState.Minimized;
				}
			};
			t.Start();
		}
		private void close_MouseEnter(object sender, EventArgs e)
		{
			ChangeImage(close, Resources.close_active);
		}
		private void minimize_MouseEnter(object sender, EventArgs e)
		{
			ChangeImage(minimize, Resources.minimize_active);
		}
		private void close_MouseLeave(object sender, EventArgs e)
		{
			ChangeImage(close, Resources.close_inactive);
		}
		private void minimize_MouseLeave(object sender, EventArgs e)
		{
			ChangeImage(minimize, Resources.minimize_inactive);
		}
		private void Form1_Activated(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized) Opacity = 0;
			Timer t = new Timer { Interval = 1 };
			t.Tick += delegate (object sender_, EventArgs e_)
			{
				Opacity += .025d;
				WindowState = FormWindowState.Normal;
				if (Opacity >= 1)
				{
					t.Enabled = false;
					Opacity = 1;
				}
			};
			t.Start();
		}
		private void Form1_Shown(object sender, EventArgs e)
		{
			Opacity = 0;
			Timer t = new Timer { Interval = 1 };
			t.Tick += delegate (object sender_, EventArgs e_)
			{
				Opacity += .025d;
				if (Opacity >= 1)
				{
					t.Enabled = false;
					Opacity = 1;
				}
			};
			t.Start();
		}

		private void ResizeLeft(object sender, MouseEventArgs e)
		{
			ResizeWindow(10);
		}
		private void ResizeRight(object sender, MouseEventArgs e)
		{
			ResizeWindow(11);
		}
		private void ResizeBottom(object sender, MouseEventArgs e)
		{
			ResizeWindow(15);
		}
		private void ResizeTop(object sender, MouseEventArgs e)
		{
			ResizeWindow(12);
		}
		private void ResizeTopLeft(object sender, MouseEventArgs e)
		{
			ResizeWindow(13);
		}
		private void ResizeTopRight(object sender, MouseEventArgs e)
		{
			ResizeWindow(14);
		}
		private void ResizeBottomLeft(object sender, MouseEventArgs e)
		{
			ResizeWindow(16);
		}
		private void ResizeBottomRight(object sender, MouseEventArgs e)
		{
			ResizeWindow(17);
		}
		private void DragForm(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 161, 2, 0);
		}
		#endregion

		private void topmost_CheckedChanged(object sender, EventArgs e)
		{
			TopMost = topmost.Checked;
			Settings.Default.TopMost = topmost.Checked;
			Settings.Default.Save();
		}

		private void materialButton2_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog
			{
				Description = "Please select the folder that contains the unpacked mod...",
				ShowNewFolderButton = false,
			})
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					modDir.Text = fbd.SelectedPath;
				}
			}
		}

		private void materialButton3_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog
			{
				Description = "Please select your Satisfactory game directory...",
				ShowNewFolderButton = false,
			})
			{
				if (fbd.ShowDialog() == DialogResult.OK && fbd.SelectedPath.Contains("Satisfactory"))
				{
					gameDir.Text = fbd.SelectedPath;
					Settings.Default.GameDirectory = fbd.SelectedPath;
					Settings.Default.Save();
				}
				else if (fbd.ShowDialog() == DialogResult.OK && !fbd.SelectedPath.Contains("Satisfactory"))
				{
					MessageBox.Show("Please select a valid Satisfactory game directory.\n" +
						"This directory does not contain Satisfactory.", "Invalid Path Selected");
				}
			}
		}

		private void materialButton1_Click(object sender, EventArgs e)
		{
			try
			{
				Timer t1 = new Timer { Interval = 1000 };
				Timer t2 = new Timer { Interval = 1000 };
				Timer t3 = new Timer { Interval = 1000 };
				Timer t4 = new Timer { Interval = 1000 };

				t1.Tick += delegate (object sender_, EventArgs e_)
				{
					status.Text = "Getting files...";
					materialProgressBar1.Value = 33;

					// copy and paste each .pak and .sig into the Paks folder
					// then delete the old files
					string[] paks = Directory.GetFiles(modDir.Text, "*.pak");
					string[] sigs = Directory.GetFiles(modDir.Text, "*.sig");

					t1.Enabled = false;
					t2.Tick += delegate (object sender__, EventArgs e__)
					{
						status.Text = "Copying files to Paks folder...";
						materialProgressBar1.Value = 66;

						// copy each pak into the Paks folder
						foreach (string pak in paks)
						{
							File.Copy(pak, $"{gameDir.Text}{"\\"}FactoryGame{"\\"}Content{"\\"}Paks{"\\"}{Path.GetFileName(pak)}");
						}

						// copy each sig into the Paks folder
						foreach (string sig in sigs)
						{
							File.Copy(sig, $"{gameDir.Text}{"\\"}FactoryGame{"\\"}Content{"\\"}Paks{"\\"}{Path.GetFileName(sig)}");
						}

						t2.Enabled = false;
						t3.Tick += delegate (object sender___, EventArgs e___)
						{
							status.Text = "Deleting old files...";
							materialProgressBar1.Value = 100;

							// delete the old paks
							foreach (string pak in paks)
							{
								File.Delete(pak);
							}

							// delete the old sigs
							foreach (string sig in sigs)
							{
								File.Delete(sig);
							}

							t3.Enabled = false;
							t4.Tick += delegate (object sender____, EventArgs e____)
							{
								status.Text = "Ready to install...";
								materialProgressBar1.Value = 0;
								t4.Enabled = false;
							};
							t4.Start();
						};
						t3.Start();
					};
					t2.Start();
				};
				t1.Start();
			} catch {}
		}

		private void gameDir_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
			{
				Settings.Default.GameDirectory = gameDir.Text;
				Settings.Default.Save();
			}
		}
	}
}
