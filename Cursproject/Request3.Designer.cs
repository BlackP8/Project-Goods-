namespace Cursproject
{
    partial class Request3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch3 = new System.Windows.Forms.TextBox();
            this.btnFind3 = new System.Windows.Forms.Button();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите первую букву товара: ";
            // 
            // tbSearch3
            // 
            this.tbSearch3.Location = new System.Drawing.Point(317, 92);
            this.tbSearch3.Name = "tbSearch3";
            this.tbSearch3.Size = new System.Drawing.Size(249, 26);
            this.tbSearch3.TabIndex = 5;
            // 
            // btnFind3
            // 
            this.btnFind3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFind3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind3.Location = new System.Drawing.Point(45, 180);
            this.btnFind3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind3.Name = "btnFind3";
            this.btnFind3.Size = new System.Drawing.Size(112, 35);
            this.btnFind3.TabIndex = 6;
            this.btnFind3.Text = "Найти";
            this.btnFind3.UseVisualStyleBackColor = true;
            // 
            // btnCancel4
            // 
            this.btnCancel4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel4.Location = new System.Drawing.Point(454, 180);
            this.btnCancel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(112, 35);
            this.btnCancel4.TabIndex = 7;
            this.btnCancel4.Text = "Отмена";
            this.btnCancel4.UseVisualStyleBackColor = true;
            // 
            // Request3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 307);
            this.Controls.Add(this.btnCancel4);
            this.Controls.Add(this.btnFind3);
            this.Controls.Add(this.tbSearch3);
            this.Controls.Add(this.label1);
            this.Name = "Request3";
            this.Text = " Поиск товаров на опр. букву";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch3;
        private System.Windows.Forms.Button btnFind3;
        private System.Windows.Forms.Button btnCancel4;
    }
}