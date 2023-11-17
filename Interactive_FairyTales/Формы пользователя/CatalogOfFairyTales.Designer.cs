namespace Interactive_FairyTales
{
    partial class CatalogOfFairyTales
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.ManagementForm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table.Location = new System.Drawing.Point(59, 59);
            this.Table.Margin = new System.Windows.Forms.Padding(50, 50, 50, 100);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(636, 323);
            this.Table.TabIndex = 0;
            // 
            // ManagementForm_Button
            // 
            this.ManagementForm_Button.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagementForm_Button.Location = new System.Drawing.Point(209, 414);
            this.ManagementForm_Button.Margin = new System.Windows.Forms.Padding(200, 20, 180, 20);
            this.ManagementForm_Button.Name = "ManagementForm_Button";
            this.ManagementForm_Button.Size = new System.Drawing.Size(356, 48);
            this.ManagementForm_Button.TabIndex = 1;
            this.ManagementForm_Button.Text = "Форма управления";
            this.ManagementForm_Button.UseVisualStyleBackColor = true;
            this.ManagementForm_Button.Click += new System.EventHandler(this.ManagementForm_Button_Click);
            // 
            // CatalogOfFairyTales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 491);
            this.Controls.Add(this.ManagementForm_Button);
            this.Controls.Add(this.Table);
            this.Name = "CatalogOfFairyTales";
            this.Text = "Каталог сказок";
            this.Load += new System.EventHandler(this.CatalogOfFairyTales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Button ManagementForm_Button;
    }
}

