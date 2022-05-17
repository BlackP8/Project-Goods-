namespace Cursproject
{
    partial class Request4
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
            this.btnFind4 = new System.Windows.Forms.Button();
            this.btnCancel5 = new System.Windows.Forms.Button();
            this.tbSearch4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите страну испортера: ";
            // 
            // btnFind4
            // 
            this.btnFind4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFind4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind4.Location = new System.Drawing.Point(66, 175);
            this.btnFind4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind4.Name = "btnFind4";
            this.btnFind4.Size = new System.Drawing.Size(112, 35);
            this.btnFind4.TabIndex = 7;
            this.btnFind4.Text = "Найти";
            this.btnFind4.UseVisualStyleBackColor = true;
            // 
            // btnCancel5
            // 
            this.btnCancel5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel5.Location = new System.Drawing.Point(442, 175);
            this.btnCancel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel5.Name = "btnCancel5";
            this.btnCancel5.Size = new System.Drawing.Size(112, 35);
            this.btnCancel5.TabIndex = 8;
            this.btnCancel5.Text = "Отмена";
            this.btnCancel5.UseVisualStyleBackColor = true;
            // 
            // tbSearch4
            // 
            this.tbSearch4.Location = new System.Drawing.Point(315, 88);
            this.tbSearch4.Name = "tbSearch4";
            this.tbSearch4.Size = new System.Drawing.Size(249, 26);
            this.tbSearch4.TabIndex = 6;
            // 
            // Request4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 365);
            this.Controls.Add(this.btnCancel5);
            this.Controls.Add(this.btnFind4);
            this.Controls.Add(this.tbSearch4);
            this.Controls.Add(this.label1);
            this.Name = "Request4";
            this.Text = "Справка по объему товаров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind4;
        private System.Windows.Forms.Button btnCancel5;
        private System.Windows.Forms.TextBox tbSearch4;
    }
}