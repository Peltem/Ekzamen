
namespace Ekz_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataBase = new System.Windows.Forms.DataGridView();
            this.Poisk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBase
            // 
            this.DataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBase.Location = new System.Drawing.Point(41, 158);
            this.DataBase.Name = "DataBase";
            this.DataBase.RowTemplate.Height = 25;
            this.DataBase.Size = new System.Drawing.Size(712, 247);
            this.DataBase.TabIndex = 0;
            // 
            // Poisk
            // 
            this.Poisk.Location = new System.Drawing.Point(112, 68);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(100, 23);
            this.Poisk.TabIndex = 1;
            this.Poisk.TextChanged += new System.EventHandler(this.Poisk_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.DataBase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBase;
        private System.Windows.Forms.TextBox Poisk;
    }
}

