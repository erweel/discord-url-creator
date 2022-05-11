﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Discord
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			downloadLabel.Visible = false;

			formatLabel.Visible = false;
			selectFormat.Visible = false;

            englishCheck.Enabled = false;

			selectArch.Visible = false;
			archLabel.Visible = false;

            lightMode.Checked = false;
            darkMode.Enabled = false;
            darkMode.Checked = true;

        }

		private void Language()
		{
			var application = new Form1();

			if (turkishCheck.CheckState == CheckState.Checked)
			{
				channelLabel.Text = "Kanal:";
				downloadbutton.Text = "Oluştur";
				osLabel.Text = "İşletim Sistemi:";
				archLabel.Text = "Bit:";
				formatLabel.Text = "Format:";
				langLabel.Text = "Dil:";
				downloadLabel.Text = "İndir";
				versionTitleLabel.Text = "Sürüm:";
				application.Text = "Discord İndirme URL Oluşturucusu";

                turkishCheck.Text = "Türkçe";


				
                
                logBox.AppendText("Uygulama dili başarıyla türkçe olarak ayarlandı" + Environment.NewLine);
                
			}
			
			if (englishCheck.CheckState == CheckState.Checked)
			{
				channelLabel.Text = "Channel:";
				downloadbutton.Text = "Create";
				osLabel.Text = "Operating System:";
				archLabel.Text = "Arch:";
				formatLabel.Text = "Format:";
				langLabel.Text = "Language:";
				downloadLabel.Text = "Download";
				versionTitleLabel.Text = "Version:";
				application.Text = "Discord URL Link Creator";

                turkishCheck.Text = "Turkish";

                
                logBox.AppendText("App language set to English" + Environment.NewLine);
				
            }
        }

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectOS.Text == "Windows")
			{
				var o = new StringBuilder(selectOS.Text);
				o.Replace("Windows", "win");

                var c = new StringBuilder(selectChannel.Text);
				c.Replace("ptb (beta)", "ptb");

                var a = new StringBuilder(selectArch.Text);

				if (selectChannel.Text == "stable")
				{
					if (selectArch.Text == "")
					{
						logBox.AppendText("Please enter arch!" + Environment.NewLine);
					}
					else
                    {
						Process.Start(
							$"https://discord.com/api/downloads/distributions/app/installers/latest?channel={c}&platform={o}&arch={a}");
					

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

					}

				} else if (selectChannel.Text == "ptb (beta)")
				{
					if (selectArch.Text == "")
					{
						logBox.AppendText("Please enter arch!" + Environment.NewLine);
					}
					else
					{
						Process.Start(
							$"https://discord.com/api/downloads/distributions/app/installers/latest?channel={c}&platform={o}&arch={a}");


						logBox.AppendText("You are being redirected to the Discord page...");

						downloadLabel.Visible = false;
						downloadbutton.Visible = true;

					}

				} else if (selectChannel.Text == "canary")
				{
					if (selectArch.Text == "")
					{
						logBox.AppendText("Please enter arch!" + Environment.NewLine);
					}
					else
					{
						Process.Start(
							$"https://discord.com/api/downloads/distributions/app/installers/latest?channel={c}&platform={o}&arch={a}");


						logBox.AppendText("You are being redirected to the Discord page...");

						downloadLabel.Visible = false;
						downloadbutton.Visible = true;

					}

				} else if (selectChannel.Text == "development")
				{
					if (selectArch.Text == "")
					{
						logBox.AppendText("Please enter arch!" + Environment.NewLine);
					}
					else
					{
						Process.Start(
							$"https://discord.com/api/downloads/distributions/app/installers/latest?channel={c}&platform={o}&arch={a}");


						logBox.AppendText("You are being redirected to the Discord page...");

						downloadLabel.Visible = false;
						downloadbutton.Visible = true;

					}
				}
				else
				{
					logBox.AppendText("Please select a channel!" + Environment.NewLine);
				}

			} else if (selectOS.Text == "Linux") {
				var r = new StringBuilder(selectFormat.Text);
				r.Replace(".deb", "deb");
				r.Replace(".tar.gz", "tar.gz");

				var o = new StringBuilder(selectOS.Text);
				o.Replace("Linux", "linux");

				var c = new StringBuilder(selectChannel.Text);
				c.Replace("ptb (beta)", "ptb");


				if (selectChannel.Text == "stable")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}&format={r}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else if (selectChannel.Text == "ptb (beta)")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}&format={r}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else if (selectChannel.Text == "canary")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}&format={r}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else if (selectChannel.Text == "development")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}&format={r}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else
				{
					logBox.AppendText("Please select a channel!" + Environment.NewLine);
				}

			} else if (selectOS.Text == "MacOS") {

				var o = new StringBuilder(selectOS.Text);
				o.Replace("MacOS", "osx");

				var c = new StringBuilder(selectChannel.Text);
				c.Replace("ptb (beta)", "ptb");

				if (selectChannel.Text == "stable")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else if (selectChannel.Text == "ptb (beta)")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else if (selectChannel.Text == "canary")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;

				}
				else if (selectChannel.Text == "development")
				{
					Process.Start(
						$"https://discord.com/api/download/{c}?platform={o}");

					logBox.AppendText("You are being redirected to the Discord page...");

					downloadLabel.Visible = false;
					downloadbutton.Visible = true;
				}
				else
				{
					if (turkishCheck.Checked)
					{
						logBox.AppendText("Lütfen kanal seçiniz!" + Environment.NewLine);
					}
					else
					{
						logBox.AppendText("Please select a channel!" + Environment.NewLine);
					}
				}
			}
			else
			{
				if (turkishCheck.Checked)
                {

					logBox.AppendText("Lütfen işletim sistemi seçiniz!" + Environment.NewLine);
				}
				else
				{

					logBox.AppendText("Please select a OS!" + Environment.NewLine);
				}
			
		}
		}

		private void downloadbutton_Click(object sender, EventArgs e)
		{

			downloadLabel.Visible = true;
            downloadbutton.Visible = false;


        }

		private void selectOS_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (selectOS.Text == "Windows")
            {

				formatLabel.Visible = false;
				selectFormat.Visible = false;

				selectArch.Visible = true;
				archLabel.Visible = true;

				if (turkishCheck.Checked)
				{
                    logBox.AppendText($"\"{selectOS.Text}\" işletim sistemini seçtiniz." + Environment.NewLine);
				}
				else
                {
                    logBox.AppendText($"You have chosen the \"{selectOS.Text}\" operating system" + Environment.NewLine);
				}
			}

			if (selectOS.Text == "Linux")
            {

				formatLabel.Visible = true;
				selectFormat.Visible = true;

				selectArch.Visible = false;
				archLabel.Visible = false;

				if (turkishCheck.Checked)
				{
                    logBox.AppendText($"\"{selectOS.Text}\" işletim sistemini seçtiniz." + Environment.NewLine);
				}
				else
				{
                    logBox.AppendText($"You have chosen the \"{selectOS.Text}\" operating system" + Environment.NewLine);
				}
			}

			if (selectOS.Text == "MacOS")
			{
                formatLabel.Visible = false;
				selectFormat.Visible = false;

				selectArch.Visible = false;
				archLabel.Visible = false;

				if (turkishCheck.Checked)
				{
					logBox.AppendText($"\"{selectOS.Text}\" işletim sistemini seçtiniz." + Environment.NewLine);
				}
				else
				{
					logBox.AppendText($"You have chosen the \"{selectOS.Text}\" operating system" + Environment.NewLine);
				}
			}
		}

		private void selectChannel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (selectChannel.Text == "stable")
			{

				if (turkishCheck.Checked)
				{
					logBox.AppendText($"\"{selectChannel.Text}\" kanalını seçtiniz." + Environment.NewLine);
				}
				else
				{
					logBox.AppendText($"You have chosen the \"{selectChannel.Text}\" channel" + Environment.NewLine);
				}
			}

			if (selectChannel.Text == "ptb (beta)")
			{

				if (turkishCheck.Checked)
				{
					logBox.AppendText($"\"{selectChannel.Text}\" kanalını seçtiniz." + Environment.NewLine);
				}
				else
				{
					logBox.AppendText($"You have chosen the \"{selectChannel.Text}\" channel" + Environment.NewLine);
				}
			}

			if (selectChannel.Text == "canary")
			{
                if (turkishCheck.Checked)
				{
					logBox.AppendText($"\"{selectChannel.Text}\" kanalını seçtiniz." + Environment.NewLine);
				}
				else
				{
					logBox.AppendText($"You have chosen the \"{selectChannel.Text}\" channel" + Environment.NewLine);
				}
			}

			if (selectChannel.Text == "development")
			{
                if (turkishCheck.Checked)
				{
					logBox.AppendText($"\"{selectChannel.Text}\" kanalını seçtiniz." + Environment.NewLine);
				}
				else
				{
					logBox.AppendText($"You have chosen the \"{selectChannel.Text}\" channel" + Environment.NewLine);
				}
			}
		}

		private void turkishCheck_CheckedChanged(object sender, EventArgs e)
		{
			Language();

			if (turkishCheck.CheckState == CheckState.Checked && englishCheck.CheckState == CheckState.Checked)
			{
				turkishCheck.Checked = true;
                turkishCheck.Enabled = false;

				englishCheck.Checked = false;
				englishCheck.Enabled = true;

            }
		}

		private void englishCheck_CheckedChanged(object sender, EventArgs e)
		{
			Language();

			if (englishCheck.CheckState == CheckState.Checked && turkishCheck.CheckState == CheckState.Checked)
			{
				turkishCheck.Checked = false;
				turkishCheck.Enabled = true;

                englishCheck.Checked = true;
                englishCheck.Enabled = false;
            }
		}

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {

            var application = new Form1();
            BackColor = Color.White;

            if (darkMode.CheckState == CheckState.Checked && lightMode.CheckState == CheckState.Checked)
            {
                darkMode.Checked = true;
                darkMode.Enabled = false;

                lightMode.Checked = false;
                lightMode.Enabled = true;

                application.BackColor = BackColor;
            }

		}

        private void lightMode_CheckedChanged(object sender, EventArgs e)
        {

            var application = new Form1();
            BackColor = Color.Gray;

            if (lightMode.CheckState == CheckState.Checked && darkMode.CheckState == CheckState.Checked)
            {
                darkMode.Checked = false;
                darkMode.Enabled = true;

                lightMode.Checked = true;
                lightMode.Enabled = false;

                application.BackColor = BackColor;
            }
        }
    }
}