namespace Cursproject
{
    partial class Request2
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
            this.tbSearch2 = new System.Windows.Forms.TextBox();
            this.btnFind2 = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите страну: ";
            // 
            // tbSearch2
            // 
            this.tbSearch2.Location = new System.Drawing.Point(265, 81);
            this.tbSearch2.Name = "tbSearch2";
            this.tbSearch2.Size = new System.Drawing.Size(249, 26);
            this.tbSearch2.TabIndex = 5;
            // 
            // btnFind2
            // 
            this.btnFind2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFind2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind2.Location = new System.Drawing.Point(109, 181);
            this.btnFind2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind2.Name = "btnFind2";
            this.btnFind2.Size = new System.Drawing.Size(112, 35);
            this.btnFind2.TabIndex = 6;
            this.btnFind2.Text = "Найти";
            this.btnFind2.UseVisualStyleBackColor = true;
            // 
            // btnCancel3
            // 
            this.btnCancel3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel3.Location = new System.Drawing.Point(402, 181);
            this.btnCancel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(112, 35);
            this.btnCancel3.TabIndex = 7;
            this.btnCancel3.Text = "Отмена";
            this.btnCancel3.UseVisualStyleBackColor = true;
            // 
            // Request2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 294);
            this.Controls.Add(this.btnCancel3);
            this.Controls.Add(this.btnFind2);
            this.Controls.Add(this.tbSearch2);
            this.Controls.Add(this.label1);
            this.Name = "Request2";
            this.Text = "Список товаров, поставляемых страной";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch2;
        private System.Windows.Forms.Button btnFind2;
        private System.Windows.Forms.Button btnCancel3;
    }
}