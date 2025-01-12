namespace PictureViewer
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
            this.PicMostrarImagen = new System.Windows.Forms.PictureBox();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectedPicture = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PicMostrarImagen
            // 
            this.PicMostrarImagen.Image = ((System.Drawing.Image)(resources.GetObject("PicMostrarImagen.Image")));
            this.PicMostrarImagen.Location = new System.Drawing.Point(12, 12);
            this.PicMostrarImagen.Name = "PicMostrarImagen";
            this.PicMostrarImagen.Size = new System.Drawing.Size(328, 330);
            this.PicMostrarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMostrarImagen.TabIndex = 3;
            this.PicMostrarImagen.TabStop = false;
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.Filter = "Archivos de mapa de bits|*.BMP|JPEG|*.JPG";
            this.ofdSelectPicture.Title = "Select Picture";
            // 
            // btnSelectedPicture
            // 
            this.btnSelectedPicture.BackColor = System.Drawing.Color.IndianRed;
            this.btnSelectedPicture.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectedPicture.Location = new System.Drawing.Point(346, 12);
            this.btnSelectedPicture.Name = "btnSelectedPicture";
            this.btnSelectedPicture.Size = new System.Drawing.Size(92, 67);
            this.btnSelectedPicture.TabIndex = 4;
            this.btnSelectedPicture.Text = "Selected Picture";
            this.btnSelectedPicture.UseVisualStyleBackColor = false;
            this.btnSelectedPicture.Click += new System.EventHandler(this.btnSelectedPicture_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuit.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuit.Location = new System.Drawing.Point(346, 85);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(92, 67);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 358);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSelectedPicture);
            this.Controls.Add(this.PicMostrarImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PicMostrarImagen;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
        private System.Windows.Forms.Button btnSelectedPicture;
        private System.Windows.Forms.Button btnQuit;
    }
}

