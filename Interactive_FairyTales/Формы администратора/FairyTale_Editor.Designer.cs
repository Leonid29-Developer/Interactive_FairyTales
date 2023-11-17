namespace Interactive_FairyTales
{
    partial class FairyTale_Editor
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
            this.List_FairyTales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FairyTale_Picture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FairyTale_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FairyTale_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // List_FairyTales
            // 
            this.List_FairyTales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.List_FairyTales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.List_FairyTales.FormattingEnabled = true;
            this.List_FairyTales.Items.AddRange(new object[] {
            "Добавить новую сказку"});
            this.List_FairyTales.Location = new System.Drawing.Point(51, 84);
            this.List_FairyTales.Margin = new System.Windows.Forms.Padding(5);
            this.List_FairyTales.Name = "List_FairyTales";
            this.List_FairyTales.Size = new System.Drawing.Size(571, 29);
            this.List_FairyTales.TabIndex = 0;
            this.List_FairyTales.SelectedIndexChanged += new System.EventHandler(this.List_FairyTales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите редактируемую сказку";
            // 
            // FairyTale_Picture
            // 
            this.FairyTale_Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FairyTale_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FairyTale_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FairyTale_Picture.Location = new System.Drawing.Point(51, 307);
            this.FairyTale_Picture.Name = "FairyTale_Picture";
            this.FairyTale_Picture.Size = new System.Drawing.Size(350, 350);
            this.FairyTale_Picture.TabIndex = 2;
            this.FairyTale_Picture.TabStop = false;
            this.FairyTale_Picture.Click += new System.EventHandler(this.FairyTale_Picture_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название сказки";
            // 
            // FairyTale_Name
            // 
            this.FairyTale_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FairyTale_Name.Location = new System.Drawing.Point(51, 184);
            this.FairyTale_Name.Name = "FairyTale_Name";
            this.FairyTale_Name.Size = new System.Drawing.Size(567, 29);
            this.FairyTale_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Обложка сказки";
            // 
            // Edit_Button
            // 
            this.Edit_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_Button.Location = new System.Drawing.Point(426, 323);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(225, 77);
            this.Edit_Button.TabIndex = 7;
            this.Edit_Button.Text = "Редактировать страницы";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Remove_Button.Location = new System.Drawing.Point(426, 580);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(225, 77);
            this.Remove_Button.TabIndex = 8;
            this.Remove_Button.Text = "Удалить сказку";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Button.Location = new System.Drawing.Point(426, 468);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(225, 77);
            this.Save_Button.TabIndex = 9;
            this.Save_Button.Text = "Сохранить изменения";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "Picture";
            this.OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            // 
            // FairyTale_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 727);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FairyTale_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FairyTale_Picture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_FairyTales);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FairyTale_Editor";
            this.Text = "Редактор сказок";
            this.Load += new System.EventHandler(this.FairyTale_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FairyTale_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox List_FairyTales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FairyTale_Picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FairyTale_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}