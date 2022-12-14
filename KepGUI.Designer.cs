namespace KepForm
{
    partial class KepGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KepGUI));
            this.KepBox = new System.Windows.Forms.PictureBox();
            this.MegnyitButton = new System.Windows.Forms.Button();
            this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.KepBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KepBox
            // 
            this.KepBox.BackgroundImage = global::KepForm.Properties.Resources.img_624d8245533d8;
            this.KepBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.KepBox.Image = ((System.Drawing.Image)(resources.GetObject("KepBox.Image")));
            this.KepBox.ImageLocation = "";
            this.KepBox.Location = new System.Drawing.Point(1046, 0);
            this.KepBox.Name = "KepBox";
            this.KepBox.Size = new System.Drawing.Size(154, 658);
            this.KepBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KepBox.TabIndex = 0;
            this.KepBox.TabStop = false;
            // 
            // MegnyitButton
            // 
            this.MegnyitButton.Image = global::KepForm.Properties.Resources.img_624d8245533d8;
            this.MegnyitButton.Location = new System.Drawing.Point(120, 41);
            this.MegnyitButton.Name = "MegnyitButton";
            this.MegnyitButton.Size = new System.Drawing.Size(131, 60);
            this.MegnyitButton.TabIndex = 1;
            this.MegnyitButton.Text = "Megnyitás";
            this.MegnyitButton.UseVisualStyleBackColor = true;
            this.MegnyitButton.Click += new System.EventHandler(this.MegnyitButton_Click);
            // 
            // FileOpenDialog
            // 
            this.FileOpenDialog.FileName = "openFileDialog1";
            // 
            // KepGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.MegnyitButton);
            this.Controls.Add(this.KepBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KepGUI";
            this.Text = "KépGUI";
            ((System.ComponentModel.ISupportInitialize)(this.KepBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox KepBox;
        private System.Windows.Forms.Button MegnyitButton;
        private System.Windows.Forms.OpenFileDialog FileOpenDialog;
    }
}

