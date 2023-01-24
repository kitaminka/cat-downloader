namespace cat_downloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.downloadCatsButton = new System.Windows.Forms.Button();
            this.numberOfCatsInput = new System.Windows.Forms.NumericUpDown();
            this.numberOfCatsLabel = new System.Windows.Forms.Label();
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.selectedFolderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCatsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadCatsButton
            // 
            this.downloadCatsButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.downloadCatsButton.Location = new System.Drawing.Point(40, 298);
            this.downloadCatsButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.downloadCatsButton.Name = "downloadCatsButton";
            this.downloadCatsButton.Size = new System.Drawing.Size(200, 50);
            this.downloadCatsButton.TabIndex = 0;
            this.downloadCatsButton.Text = "Download cats";
            this.downloadCatsButton.UseVisualStyleBackColor = false;
            this.downloadCatsButton.Click += new System.EventHandler(this.downloadCatsButton_Click);
            // 
            // numberOfCatsInput
            // 
            this.numberOfCatsInput.Location = new System.Drawing.Point(120, 218);
            this.numberOfCatsInput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.numberOfCatsInput.Name = "numberOfCatsInput";
            this.numberOfCatsInput.Size = new System.Drawing.Size(120, 20);
            this.numberOfCatsInput.TabIndex = 2;
            this.numberOfCatsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfCatsLabel
            // 
            this.numberOfCatsLabel.AutoSize = true;
            this.numberOfCatsLabel.Location = new System.Drawing.Point(38, 220);
            this.numberOfCatsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfCatsLabel.Name = "numberOfCatsLabel";
            this.numberOfCatsLabel.Size = new System.Drawing.Size(82, 13);
            this.numberOfCatsLabel.TabIndex = 3;
            this.numberOfCatsLabel.Text = "Number of cats:";
            // 
            // catPictureBox
            // 
            this.catPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("catPictureBox.Image")));
            this.catPictureBox.InitialImage = null;
            this.catPictureBox.Location = new System.Drawing.Point(40, 0);
            this.catPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(200, 200);
            this.catPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPictureBox.TabIndex = 4;
            this.catPictureBox.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = ".";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.selectFolderButton.Location = new System.Drawing.Point(40, 268);
            this.selectFolderButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(200, 25);
            this.selectFolderButton.TabIndex = 5;
            this.selectFolderButton.Text = "Select folder";
            this.selectFolderButton.UseVisualStyleBackColor = false;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // selectedFolderLabel
            // 
            this.selectedFolderLabel.AutoSize = true;
            this.selectedFolderLabel.Location = new System.Drawing.Point(38, 248);
            this.selectedFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFolderLabel.MaximumSize = new System.Drawing.Size(200, 30);
            this.selectedFolderLabel.Name = "selectedFolderLabel";
            this.selectedFolderLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedFolderLabel.TabIndex = 6;
            this.selectedFolderLabel.Text = "Selected folder: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(280, 361);
            this.Controls.Add(this.selectedFolderLabel);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.catPictureBox);
            this.Controls.Add(this.numberOfCatsLabel);
            this.Controls.Add(this.numberOfCatsInput);
            this.Controls.Add(this.downloadCatsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "MainForm";
            this.Text = "Cat Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCatsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadCatsButton;
        private System.Windows.Forms.NumericUpDown numberOfCatsInput;
        private System.Windows.Forms.Label numberOfCatsLabel;
        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label selectedFolderLabel;
    }
}

