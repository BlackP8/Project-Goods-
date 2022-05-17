namespace Cursproject
{
    partial class Request1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.goodsObjectFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsSystemObjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsSystemObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsSystemObjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodsObjectFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите импортируемый товар:";
            // 
            // btnFind
            // 
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(70, 154);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 35);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel2.Location = new System.Drawing.Point(493, 154);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(112, 35);
            this.btnCancel2.TabIndex = 3;
            this.btnCancel2.Text = "Отмена";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // goodsObjectFormBindingSource
            // 
            this.goodsObjectFormBindingSource.DataSource = typeof(Cursproject.goodsObjectForm);
            // 
            // goodsSystemObjectBindingSource1
            // 
            this.goodsSystemObjectBindingSource1.DataSource = typeof(Cursproject.goodsSystemObject);
            // 
            // goodsSystemObjectBindingSource
            // 
            this.goodsSystemObjectBindingSource.DataSource = typeof(Cursproject.goodsSystemObject);
            // 
            // goodsSystemObjectBindingSource2
            // 
            this.goodsSystemObjectBindingSource2.DataSource = typeof(Cursproject.goodsSystemObject);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(356, 74);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(249, 26);
            this.tbSearch.TabIndex = 4;
            // 
            // Request1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 288);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Request1";
            this.Text = "Справка по странам-импортёрам";
            ((System.ComponentModel.ISupportInitialize)(this.goodsObjectFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.BindingSource goodsSystemObjectBindingSource;
        private System.Windows.Forms.BindingSource goodsSystemObjectBindingSource1;
        private System.Windows.Forms.BindingSource goodsObjectFormBindingSource;
        private System.Windows.Forms.BindingSource goodsSystemObjectBindingSource2;
        private System.Windows.Forms.TextBox tbSearch;
    }
}