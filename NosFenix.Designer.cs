/*
 MIT License
 
 Copyright (c) [2017] [NosFenix]
 
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

namespace NosLauncher
{
    partial class NosFenix
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NosFenix));
            this.Close = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.linkSyl = new System.Windows.Forms.LinkLabel();
            this.Herramientas = new System.Windows.Forms.Button();
            this.Opciones = new System.Windows.Forms.Button();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Panel1 = new MonoFlat.MonoFlat_Panel();
            this.Label4 = new MonoFlat.MonoFlat_Label();
            this.Label3 = new MonoFlat.MonoFlat_Label();
            this.Label2 = new MonoFlat.MonoFlat_Label();
            this.Label1 = new MonoFlat.MonoFlat_Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monoFlat_Button3 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close.ForeColor = System.Drawing.Color.Cyan;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close.Location = new System.Drawing.Point(598, 384);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(113, 37);
            this.Close.TabIndex = 7;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // filePath
            // 
            this.filePath.BackColor = System.Drawing.Color.White;
            this.filePath.Location = new System.Drawing.Point(23, 357);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(214, 20);
            this.filePath.TabIndex = 5;
            // 
            // linkSyl
            // 
            this.linkSyl.AutoSize = true;
            this.linkSyl.BackColor = System.Drawing.Color.Transparent;
            this.linkSyl.LinkColor = System.Drawing.Color.Black;
            this.linkSyl.LinkVisited = true;
            this.linkSyl.Location = new System.Drawing.Point(12, 429);
            this.linkSyl.Name = "linkSyl";
            this.linkSyl.Size = new System.Drawing.Size(122, 13);
            this.linkSyl.TabIndex = 6;
            this.linkSyl.TabStop = true;
            this.linkSyl.Text = "Developped by Nosheat";
            this.linkSyl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkSyl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSyl_LinkClicked);
            // 
            // Herramientas
            // 
            this.Herramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Herramientas.ForeColor = System.Drawing.Color.Cyan;
            this.Herramientas.Location = new System.Drawing.Point(424, 384);
            this.Herramientas.Name = "Herramientas";
            this.Herramientas.Size = new System.Drawing.Size(113, 37);
            this.Herramientas.TabIndex = 8;
            this.Herramientas.Text = "Herramientas";
            this.Herramientas.UseVisualStyleBackColor = false;
            this.Herramientas.Click += new System.EventHandler(this.Herramientas_Click);
            // 
            // Opciones
            // 
            this.Opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Opciones.ForeColor = System.Drawing.Color.Cyan;
            this.Opciones.Location = new System.Drawing.Point(264, 384);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(113, 37);
            this.Opciones.TabIndex = 9;
            this.Opciones.Text = "Opciones";
            this.Opciones.UseVisualStyleBackColor = false;
            this.Opciones.Click += new System.EventHandler(this.Opciones_Click);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(620, 306);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(143, 45);
            this.monoFlat_Button1.TabIndex = 11;
            this.monoFlat_Button1.Text = "Estado Del Servidor";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.Red;
            this.monoFlat_Panel1.Controls.Add(this.Label4);
            this.monoFlat_Panel1.Controls.Add(this.Label3);
            this.monoFlat_Panel1.Controls.Add(this.Label2);
            this.monoFlat_Panel1.Controls.Add(this.Label1);
            this.monoFlat_Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.monoFlat_Panel1.Location = new System.Drawing.Point(23, 264);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(215, 73);
            this.monoFlat_Panel1.TabIndex = 10;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Label4.Location = new System.Drawing.Point(124, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(12, 15);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "-";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Label3.Location = new System.Drawing.Point(124, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(12, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "-";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(8, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "WorldServer Estado:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(8, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "LoginServer Estado:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.monoFlat_Button3);
            this.panel1.Controls.Add(this.monoFlat_Button2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 38);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // monoFlat_Button3
            // 
            this.monoFlat_Button3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button3.Image = null;
            this.monoFlat_Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button3.Location = new System.Drawing.Point(624, 3);
            this.monoFlat_Button3.Name = "monoFlat_Button3";
            this.monoFlat_Button3.Size = new System.Drawing.Size(65, 32);
            this.monoFlat_Button3.TabIndex = 14;
            this.monoFlat_Button3.Text = "Pausar";
            this.monoFlat_Button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button3.Click += new System.EventHandler(this.monoFlat_Button3_Click);
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.Location = new System.Drawing.Point(695, 3);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.Size = new System.Drawing.Size(61, 32);
            this.monoFlat_Button2.TabIndex = 13;
            this.monoFlat_Button2.Text = "Music";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // NosFenix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NosFenix.Properties.Resources._1__272_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.monoFlat_Panel1);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.Herramientas);
            this.Controls.Add(this.linkSyl);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.Close);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NosFenix";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "NOSARMY LAUCHER";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_Panel1.ResumeLayout(false);
            this.monoFlat_Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.LinkLabel linkSyl;
        private System.Windows.Forms.Button Herramientas;
        private System.Windows.Forms.Button Opciones;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel1;
        private MonoFlat.MonoFlat_Label Label2;
        private MonoFlat.MonoFlat_Label Label1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_Label Label4;
        private MonoFlat.MonoFlat_Label Label3;
        private System.Windows.Forms.Panel panel1;
        private MonoFlat.MonoFlat_Button monoFlat_Button2;
        private MonoFlat.MonoFlat_Button monoFlat_Button3;
    }
}

