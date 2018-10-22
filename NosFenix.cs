/*
 MIT License
 
 Copyright (c) [2025] [NosArmy]
 
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 SOFTWARE.
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using WMPLib;


namespace NosLauncher
{
    public partial class NosFenix : Form
    {
        EnterIP ip;


        public object MyProject { get; private set; }

        public int MOUSE_MOVE { get; private set; }

        public NosFenix()
        {


            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;

        bool mouseDown;

        WindowsMediaPlayer sonido;

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Abre NostaleX.dat en tu directorio de Nostale";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.filePath.Text = openFileDialog1.FileName;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro Que Quieres Salir De la Applicacion", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Application.Exit();
        }

        public void Launch_Click(object sender, EventArgs e)
        {
            this.ip = new EnterIP();

            this.ip.OK.Click += new EventHandler(IP_OK_Click);

            this.ip.ShowDialog();
        }

        public void IP_OK_Click(object sender, EventArgs e)
        {
            string input = this.filePath.Text;

            string output = this.filePath.Text;

            string[] output2 = output.Split('.');
            output2[0] += Path.GetFileName("NosArmy");
            output2[1] = "exe";

            output = output2[0] + "." + output2[1];

            string desiredIP = this.ip._IP.Text;

            try
            {
                File.Copy(input, output);
            }
            catch
            {
                File.Delete(output);
                File.Copy(input, output);
            }

            using (var stream = new FileStream(output, FileMode.Open, FileAccess.ReadWrite))
            {
                int i = 0;
                int i2 = 0;

                #region for (int n = 0; n <= stream.Length; n++)
                for (int n = 0; n <= stream.Length; n++)
                {
                    stream.Position = n;
                    if (stream.ReadByte() == 0x37)
                    {
                        stream.Position = n + 1;
                        if (stream.ReadByte() == 0x39)
                        {
                            stream.Position = n + 2;
                            if (stream.ReadByte() == 0x2E)
                            {
                                stream.Position = n + 3;
                                if (stream.ReadByte() == 0x31)
                                {
                                    stream.Position = n + 4;
                                    if (stream.ReadByte() == 0x31)
                                    {
                                        stream.Position = n + 5;
                                        if (stream.ReadByte() == 0x30)
                                        {
                                            stream.Position = n + 6;
                                            if (stream.ReadByte() == 0x2E)
                                            {
                                                stream.Position = n + 7;
                                                if (stream.ReadByte() == 0x38)
                                                {
                                                    stream.Position = n + 8;
                                                    if (stream.ReadByte() == 0x34)
                                                    {
                                                        stream.Position = n + 9;
                                                        if (stream.ReadByte() == 0x2E)
                                                        {
                                                            stream.Position = n + 10;
                                                            if (stream.ReadByte() == 0x37)
                                                            {
                                                                stream.Position = n + 11;
                                                                if (stream.ReadByte() == 0x35)
                                                                {
                                                                    i = n;
                                                                    for (int s = n; s <= n + 11; s++)
                                                                    {
                                                                        stream.Position = s;
                                                                        stream.WriteByte(0x00);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion for (int n = 0; n < stream.Length + 1; n++)

                #region for (int n2 = 0; n2 <= stream.Length; n2++)
                for (int n2 = 0; n2 <= stream.Length; n2++)
                {
                    stream.Position = n2;
                    if (stream.ReadByte() == 0x37)
                    {
                        stream.Position = n2 + 1;
                        if (stream.ReadByte() == 0x39)
                        {
                            stream.Position = n2 + 2;
                            if (stream.ReadByte() == 0x2E)
                            {
                                stream.Position = n2 + 3;
                                if (stream.ReadByte() == 0x31)
                                {
                                    stream.Position = n2 + 4;
                                    if (stream.ReadByte() == 0x31)
                                    {
                                        stream.Position = n2 + 5;
                                        if (stream.ReadByte() == 0x30)
                                        {
                                            stream.Position = n2 + 6;
                                            if (stream.ReadByte() == 0x2E)
                                            {
                                                stream.Position = n2 + 7;
                                                if (stream.ReadByte() == 0x38)
                                                {
                                                    stream.Position = n2 + 8;
                                                    if (stream.ReadByte() == 0x34)
                                                    {
                                                        stream.Position = n2 + 9;
                                                        if (stream.ReadByte() == 0x2E)
                                                        {
                                                            stream.Position = n2 + 10;
                                                            if (stream.ReadByte() == 0x34)
                                                            {
                                                                stream.Position = n2 + 11;
                                                                if (stream.ReadByte() == 0x36)
                                                                {
                                                                    i2 = n2;
                                                                    for (int s = n2; s <= n2 + 11; s++)
                                                                    {
                                                                        stream.Position = s;
                                                                        stream.WriteByte(0x00);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion for (int n2 = 0; n2 < stream.Length + 1; n2++)

                Console.WriteLine(desiredIP.Length);

                if (desiredIP.Length != 12)
                {
                    int position = i + 20;
                    stream.Position = position;
                    switch (desiredIP.Length)
                    {
                        case 10:
                            stream.WriteByte(0x0A);
                            break;
                        case 11:
                            stream.WriteByte(0x0B);
                            break;
                        case 13:
                            stream.WriteByte(0x0D);
                            break;
                        case 14:
                            stream.WriteByte(0x0E);
                            break;
                        case 15:
                            stream.WriteByte(0x0F);
                            break;
                        case 16:
                            stream.WriteByte(0x10);
                            break;
                    }
                    position = i - 4;
                    stream.Position = position;
                    switch (desiredIP.Length)
                    {
                        case 10:
                            stream.WriteByte(0x0A);
                            break;
                        case 11:
                            stream.WriteByte(0x0B);
                            break;
                        case 13:
                            stream.WriteByte(0x0D);
                            break;
                        case 14:
                            stream.WriteByte(0x0E);
                            break;
                        case 15:
                            stream.WriteByte(0x0F);
                            break;
                        case 16:
                            stream.WriteByte(0x10);
                            break;
                    }
                }

                foreach (char c in desiredIP)
                {
                    stream.Position = i;
                    if (c == '0')
                        stream.WriteByte(0x30);
                    else if (c == '1')
                        stream.WriteByte(0x31);
                    else if (c == '2')
                        stream.WriteByte(0x32);
                    else if (c == '3')
                        stream.WriteByte(0x33);
                    else if (c == '4')
                        stream.WriteByte(0x34);
                    else if (c == '5')
                        stream.WriteByte(0x35);
                    else if (c == '6')
                        stream.WriteByte(0x36);
                    else if (c == '7')
                        stream.WriteByte(0x37);
                    else if (c == '8')
                        stream.WriteByte(0x38);
                    else if (c == '9')
                        stream.WriteByte(0x39);
                    else if (c == '.')
                        stream.WriteByte(0x2E);
                    i += 1;
                }
                foreach (char c in desiredIP)
                {
                    stream.Position = i2;
                    if (c == '0')
                        stream.WriteByte(0x30);
                    else if (c == '1')
                        stream.WriteByte(0x31);
                    else if (c == '2')
                        stream.WriteByte(0x32);
                    else if (c == '3')
                        stream.WriteByte(0x33);
                    else if (c == '4')
                        stream.WriteByte(0x34);
                    else if (c == '5')
                        stream.WriteByte(0x35);
                    else if (c == '6')
                        stream.WriteByte(0x36);
                    else if (c == '7')
                        stream.WriteByte(0x37);
                    else if (c == '8')
                        stream.WriteByte(0x38);
                    else if (c == '9')
                        stream.WriteByte(0x39);
                    else if (c == '.')
                        stream.WriteByte(0x2E);
                    i2 += 1;
                }
            }
            this.ip.Close();

            File.SetAttributes(output, FileAttributes.Hidden);

            var process = Process.Start(output, "EntwellNostaleClient");

            this.Close();

            process.WaitForExit();

            File.Delete(output);
        }

        private void Herramientas_Click(object sender, EventArgs e)
        {

            Herramientas Herramientas = new Herramientas();
            Herramientas.ShowDialog();
        }

        private void Opciones_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.Combine(Environment.CurrentDirectory, "NtConfig.exe"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ("ERROR"));
            }
        }

        private void linkSyl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nosheatshop.ga/");
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            TcpClient tcpClient2 = new TcpClient();
            try
            {
                tcpClient.Connect("173.249.28.51", 6005);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }

            {

                this.Label3.Text = "OFFLINE";
                this.Label3.ForeColor = Color.Red;
                this.monoFlat_Button1.Enabled = false;

            }
            try
            {
                tcpClient2.Connect("173.249.28.51", 3825);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }

            {

                this.Label4.Text = "OFFLINE";
                this.Label4.ForeColor = Color.Red;
                this.monoFlat_Button1.Enabled = false;

            }
            bool connected = tcpClient.Connected;
            if (connected)
            {
                this.Label3.ForeColor = Color.Green;
                this.Label3.Text = "ONLINE";
                this.monoFlat_Button1.Enabled = true;
                tcpClient.Close();
            }
            connected = tcpClient2.Connected;
            if (connected)
            {
                this.Label4.ForeColor = Color.Green;
                this.Label4.Text = "ONLINE";
                this.monoFlat_Button1.Enabled = true;
                tcpClient2.Close();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.mouseX = MousePosition.X - 200;
                this.mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(this.mouseX, this.mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            if (this.sonido != null)
            {
                this.sonido.controls.pause();
            }
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.sonido == null)
                {
                    this.sonido = new WindowsMediaPlayer();
                    this.sonido.URL = Application.StartupPath + @"\Music\Sonido.mp3";
                    this.sonido.controls.play();

                }

                if (this.sonido != null)
                {
                    double tiempo = sonido.controls.currentPosition;
                    this.sonido.controls.currentPosition = tiempo;
                    this.sonido.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}

