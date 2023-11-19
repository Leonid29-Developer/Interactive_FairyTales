namespace Interactive_FairyTales
{
    partial class PagesOfFairyTales_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagesOfFairyTales_Editor));
            this.PagesNumbers = new System.Windows.Forms.Label();
            this.PageNext = new System.Windows.Forms.Label();
            this.PagePrev = new System.Windows.Forms.Label();
            this.PanelForText = new System.Windows.Forms.Panel();
            this.PageNumber = new System.Windows.Forms.TextBox();
            this.PageFairyTale_Picture = new System.Windows.Forms.PictureBox();
            this.PageRemove = new System.Windows.Forms.Label();
            this.PageAdd = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Pic_NEW = new System.Windows.Forms.PictureBox();
            this.PageFairyTale_Text = new System.Windows.Forms.TextBox();
            this.PanelForText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageFairyTale_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_NEW)).BeginInit();
            this.SuspendLayout();
            // 
            // PagesNumbers
            // 
            this.PagesNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PagesNumbers.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesNumbers.Location = new System.Drawing.Point(255, 32);
            this.PagesNumbers.Name = "PagesNumbers";
            this.PagesNumbers.Size = new System.Drawing.Size(93, 57);
            this.PagesNumbers.TabIndex = 10;
            this.PagesNumbers.Text = "/ 00";
            this.PagesNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageNext
            // 
            this.PageNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageNext.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNext.Location = new System.Drawing.Point(354, 33);
            this.PageNext.Name = "PageNext";
            this.PageNext.Size = new System.Drawing.Size(56, 56);
            this.PageNext.TabIndex = 9;
            this.PageNext.Text = ">";
            this.PageNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageNext.Click += new System.EventHandler(this.PageNext_Click);
            // 
            // PagePrev
            // 
            this.PagePrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PagePrev.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagePrev.Location = new System.Drawing.Point(96, 33);
            this.PagePrev.Name = "PagePrev";
            this.PagePrev.Size = new System.Drawing.Size(56, 56);
            this.PagePrev.TabIndex = 8;
            this.PagePrev.Text = "<";
            this.PagePrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PagePrev.Click += new System.EventHandler(this.PagePrev_Click);
            // 
            // PanelForText
            // 
            this.PanelForText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelForText.AutoScroll = true;
            this.PanelForText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelForText.Controls.Add(this.PageFairyTale_Text);
            this.PanelForText.Location = new System.Drawing.Point(441, 132);
            this.PanelForText.Margin = new System.Windows.Forms.Padding(0, 25, 25, 100);
            this.PanelForText.Name = "PanelForText";
            this.PanelForText.Size = new System.Drawing.Size(382, 382);
            this.PanelForText.TabIndex = 7;
            // 
            // PageNumber
            // 
            this.PageNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageNumber.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNumber.Location = new System.Drawing.Point(158, 32);
            this.PageNumber.Name = "PageNumber";
            this.PageNumber.Size = new System.Drawing.Size(91, 57);
            this.PageNumber.TabIndex = 11;
            this.PageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PageFairyTale_Picture
            // 
            this.PageFairyTale_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PageFairyTale_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageFairyTale_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PageFairyTale_Picture.Location = new System.Drawing.Point(34, 132);
            this.PageFairyTale_Picture.Margin = new System.Windows.Forms.Padding(25);
            this.PageFairyTale_Picture.Name = "PageFairyTale_Picture";
            this.PageFairyTale_Picture.Size = new System.Drawing.Size(382, 382);
            this.PageFairyTale_Picture.TabIndex = 6;
            this.PageFairyTale_Picture.TabStop = false;
            this.PageFairyTale_Picture.Click += new System.EventHandler(this.FairyTale_Picture_Click);
            // 
            // PageRemove
            // 
            this.PageRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageRemove.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageRemove.Location = new System.Drawing.Point(34, 29);
            this.PageRemove.Name = "PageRemove";
            this.PageRemove.Size = new System.Drawing.Size(56, 56);
            this.PageRemove.TabIndex = 12;
            this.PageRemove.Text = "–";
            this.PageRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageRemove.Click += new System.EventHandler(this.PageRemove_Click);
            // 
            // PageAdd
            // 
            this.PageAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageAdd.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageAdd.Location = new System.Drawing.Point(416, 33);
            this.PageAdd.Name = "PageAdd";
            this.PageAdd.Size = new System.Drawing.Size(56, 56);
            this.PageAdd.TabIndex = 13;
            this.PageAdd.Text = "+";
            this.PageAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageAdd.Click += new System.EventHandler(this.PageAdd_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Button.Location = new System.Drawing.Point(577, 32);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(246, 59);
            this.Save_Button.TabIndex = 14;
            this.Save_Button.Text = "Сохранить изменения";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "Picture";
            this.OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            // 
            // Pic_NEW
            // 
            this.Pic_NEW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_NEW.BackgroundImage")));
            this.Pic_NEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_NEW.Location = new System.Drawing.Point(478, 29);
            this.Pic_NEW.Name = "Pic_NEW";
            this.Pic_NEW.Size = new System.Drawing.Size(86, 62);
            this.Pic_NEW.TabIndex = 15;
            this.Pic_NEW.TabStop = false;
            this.Pic_NEW.Visible = false;
            // 
            // PageFairyTale_Text
            // 
            this.PageFairyTale_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageFairyTale_Text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageFairyTale_Text.Location = new System.Drawing.Point(0, 0);
            this.PageFairyTale_Text.Multiline = true;
            this.PageFairyTale_Text.Name = "PageFairyTale_Text";
            this.PageFairyTale_Text.Size = new System.Drawing.Size(378, 378);
            this.PageFairyTale_Text.TabIndex = 0;
            // 
            // PagesOfFairyTales_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 548);
            this.Controls.Add(this.Pic_NEW);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.PageAdd);
            this.Controls.Add(this.PageRemove);
            this.Controls.Add(this.PageNumber);
            this.Controls.Add(this.PagesNumbers);
            this.Controls.Add(this.PageNext);
            this.Controls.Add(this.PagePrev);
            this.Controls.Add(this.PanelForText);
            this.Controls.Add(this.PageFairyTale_Picture);
            this.Name = "PagesOfFairyTales_Editor";
            this.Text = "Редактор Страниц Сказки ";
            this.Load += new System.EventHandler(this.PagesOfFairyTales_Editor_Load);
            this.PanelForText.ResumeLayout(false);
            this.PanelForText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageFairyTale_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_NEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PagesNumbers;
        private System.Windows.Forms.Label PageNext;
        private System.Windows.Forms.Label PagePrev;
        private System.Windows.Forms.Panel PanelForText;
        private System.Windows.Forms.PictureBox PageFairyTale_Picture;
        private System.Windows.Forms.TextBox PageNumber;
        private System.Windows.Forms.Label PageRemove;
        private System.Windows.Forms.Label PageAdd;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.PictureBox Pic_NEW;
        private System.Windows.Forms.TextBox PageFairyTale_Text;
    }
}