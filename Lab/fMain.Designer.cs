namespace Lab
{
    partial class fMain
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
            this.tbTabletsInfo = new System.Windows.Forms.TextBox();
            this.btnAddTablet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTabletsInfo
            // 
            this.tbTabletsInfo.Location = new System.Drawing.Point(46, 54);
            this.tbTabletsInfo.Multiline = true;
            this.tbTabletsInfo.Name = "tbTabletsInfo";
            this.tbTabletsInfo.ReadOnly = true;
            this.tbTabletsInfo.Size = new System.Drawing.Size(438, 320);
            this.tbTabletsInfo.TabIndex = 0;
            // 
            // btnAddTablet
            // 
            this.btnAddTablet.Location = new System.Drawing.Point(530, 54);
            this.btnAddTablet.Name = "btnAddTablet";
            this.btnAddTablet.Size = new System.Drawing.Size(155, 38);
            this.btnAddTablet.TabIndex = 1;
            this.btnAddTablet.Text = "Додати планшет";
            this.btnAddTablet.UseVisualStyleBackColor = true;
            this.btnAddTablet.Click += new System.EventHandler(this.btnAddTablet_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(530, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTablet);
            this.Controls.Add(this.tbTabletsInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTabletsInfo;
        private System.Windows.Forms.Button btnAddTablet;
        private System.Windows.Forms.Button btnClose;
    }
}

