namespace Interactive_FairyTales
{
    partial class FairyTale
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
            this.FairyTale_Picture = new System.Windows.Forms.PictureBox();
            this.FairyTale_Text = new System.Windows.Forms.Label();
            this.PanelForText = new System.Windows.Forms.Panel();
            this.PagePrev = new System.Windows.Forms.Label();
            this.PageNext = new System.Windows.Forms.Label();
            this.PagesNumbers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FairyTale_Picture)).BeginInit();
            this.PanelForText.SuspendLayout();
            this.SuspendLayout();
            // 
            // FairyTale_Picture
            // 
            this.FairyTale_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FairyTale_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FairyTale_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FairyTale_Picture.Location = new System.Drawing.Point(34, 34);
            this.FairyTale_Picture.Margin = new System.Windows.Forms.Padding(25);
            this.FairyTale_Picture.Name = "FairyTale_Picture";
            this.FairyTale_Picture.Size = new System.Drawing.Size(382, 382);
            this.FairyTale_Picture.TabIndex = 0;
            this.FairyTale_Picture.TabStop = false;
            // 
            // FairyTale_Text
            // 
            this.FairyTale_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FairyTale_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FairyTale_Text.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FairyTale_Text.Location = new System.Drawing.Point(0, 0);
            this.FairyTale_Text.Margin = new System.Windows.Forms.Padding(0, 25, 25, 100);
            this.FairyTale_Text.Name = "FairyTale_Text";
            this.FairyTale_Text.Size = new System.Drawing.Size(321, 303);
            this.FairyTale_Text.TabIndex = 1;
            // 
            // PanelForText
            // 
            this.PanelForText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelForText.AutoScroll = true;
            this.PanelForText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelForText.Controls.Add(this.FairyTale_Text);
            this.PanelForText.Location = new System.Drawing.Point(441, 34);
            this.PanelForText.Margin = new System.Windows.Forms.Padding(0, 25, 25, 100);
            this.PanelForText.Name = "PanelForText";
            this.PanelForText.Size = new System.Drawing.Size(325, 307);
            this.PanelForText.TabIndex = 2;
            // 
            // PagePrev
            // 
            this.PagePrev.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagePrev.Location = new System.Drawing.Point(440, 360);
            this.PagePrev.Name = "PagePrev";
            this.PagePrev.Size = new System.Drawing.Size(56, 56);
            this.PagePrev.TabIndex = 3;
            this.PagePrev.Text = "<";
            this.PagePrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PagePrev.Click += new System.EventHandler(this.PagePrev_Click);
            // 
            // PageNext
            // 
            this.PageNext.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNext.Location = new System.Drawing.Point(708, 360);
            this.PageNext.Name = "PageNext";
            this.PageNext.Size = new System.Drawing.Size(56, 56);
            this.PageNext.TabIndex = 4;
            this.PageNext.Text = ">";
            this.PageNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageNext.Click += new System.EventHandler(this.PageNext_Click);
            // 
            // PagesNumbers
            // 
            this.PagesNumbers.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesNumbers.Location = new System.Drawing.Point(502, 360);
            this.PagesNumbers.Name = "PagesNumbers";
            this.PagesNumbers.Size = new System.Drawing.Size(200, 56);
            this.PagesNumbers.TabIndex = 5;
            this.PagesNumbers.Text = "00 / 00";
            this.PagesNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FairyTale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PagesNumbers);
            this.Controls.Add(this.PageNext);
            this.Controls.Add(this.PagePrev);
            this.Controls.Add(this.PanelForText);
            this.Controls.Add(this.FairyTale_Picture);
            this.Name = "FairyTale";
            this.Text = "Сказка";
            this.Load += new System.EventHandler(this.FairyTale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FairyTale_Picture)).EndInit();
            this.PanelForText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FairyTale_Picture;
        private System.Windows.Forms.Label FairyTale_Text;
        private System.Windows.Forms.Panel PanelForText;
        private System.Windows.Forms.Label PagePrev;
        private System.Windows.Forms.Label PageNext;
        private System.Windows.Forms.Label PagesNumbers;
    }
}