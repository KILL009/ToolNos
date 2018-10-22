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
using System.Windows.Forms;
using System.Diagnostics;

namespace NosLauncher
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void Herramientas_Load(object sender, EventArgs e)
        {

        }

        /* private void Estado_Del_Servidor_Click(object sender, EventArgs e)
         {
             Process.Start("https://stats.uptimerobot.com/579oktRn2");
         }*/

        private void monoFlat_Button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro Que Quieres Salir De la Applicacion", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Application.Exit();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCN3mMDuQe7z_LhxZI-h1Qqw");
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/Cw36Tvu");
        }

        private void monoFlat_Button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://nosheat.ga/");
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/groups/NosHeat/");
        }

        private void monoFlat_ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_Button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://stats.uptimerobot.com/MZQnPigrk");
        }

        private void monoFlat_Button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://nosheat.ga/hesk/");
        }

        private void monoFlat_Button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nosheat.com/");
        }

        private void Puntos_Click(object sender, EventArgs e)
        {
            Process.Start("http://nossimulator.altervista.org/");
        

            Process.Start("http://www.800a.org/es/");
            

        }

        private void monoFlat_Button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://nosheatshop.ga/");

        }
    }

}


