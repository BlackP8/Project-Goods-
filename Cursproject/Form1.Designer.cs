namespace Cursproject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Mainmenu1 = new System.Windows.Forms.MenuStrip();
            this.созданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кооректировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоСтранамимпортерамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТоваровСтраныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоТоварамНаОпрБуквуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоОбъемуЭкспортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturercountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsSystemObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mainmenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainmenu1
            // 
            this.Mainmenu1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mainmenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Mainmenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеToolStripMenuItem,
            this.кооректировкаToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.Mainmenu1.Location = new System.Drawing.Point(0, 0);
            this.Mainmenu1.Name = "Mainmenu1";
            this.Mainmenu1.Size = new System.Drawing.Size(1134, 32);
            this.Mainmenu1.TabIndex = 0;
            this.Mainmenu1.Text = "menuStrip1";
            // 
            // созданиеToolStripMenuItem
            // 
            this.созданиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранениеToolStripMenuItem,
            this.загрузкаToolStripMenuItem,
            this.добавлениеToolStripMenuItem1});
            this.созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
            this.созданиеToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.созданиеToolStripMenuItem.Text = "Создание";
            // 
            // сохранениеToolStripMenuItem
            // 
            this.сохранениеToolStripMenuItem.Name = "сохранениеToolStripMenuItem";
            this.сохранениеToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.сохранениеToolStripMenuItem.Text = "Сохранение";
            this.сохранениеToolStripMenuItem.Click += new System.EventHandler(this.сохранениеToolStripMenuItem_Click);
            // 
            // загрузкаToolStripMenuItem
            // 
            this.загрузкаToolStripMenuItem.Name = "загрузкаToolStripMenuItem";
            this.загрузкаToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.загрузкаToolStripMenuItem.Text = "Загрузка";
            this.загрузкаToolStripMenuItem.Click += new System.EventHandler(this.загрузкаToolStripMenuItem_Click);
            // 
            // добавлениеToolStripMenuItem1
            // 
            this.добавлениеToolStripMenuItem1.Name = "добавлениеToolStripMenuItem1";
            this.добавлениеToolStripMenuItem1.Size = new System.Drawing.Size(194, 30);
            this.добавлениеToolStripMenuItem1.Text = "Добавление";
            this.добавлениеToolStripMenuItem1.Click += new System.EventHandler(this.добавлениеToolStripMenuItem1_Click);
            // 
            // кооректировкаToolStripMenuItem
            // 
            this.кооректировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалениеToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.кооректировкаToolStripMenuItem.Name = "кооректировкаToolStripMenuItem";
            this.кооректировкаToolStripMenuItem.Size = new System.Drawing.Size(151, 28);
            this.кооректировкаToolStripMenuItem.Text = "Корректировка";
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            this.удалениеToolStripMenuItem.Click += new System.EventHandler(this.удалениеToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаПоСтранамимпортерамToolStripMenuItem,
            this.списокТоваровСтраныToolStripMenuItem,
            this.справкаПоТоварамНаОпрБуквуToolStripMenuItem,
            this.справкаПоОбъемуЭкспортаToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // справкаПоСтранамимпортерамToolStripMenuItem
            // 
            this.справкаПоСтранамимпортерамToolStripMenuItem.Name = "справкаПоСтранамимпортерамToolStripMenuItem";
            this.справкаПоСтранамимпортерамToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.справкаПоСтранамимпортерамToolStripMenuItem.Text = "Справка по странам-импортерам";
            this.справкаПоСтранамимпортерамToolStripMenuItem.Click += new System.EventHandler(this.справкаПоСтранамимпортерамToolStripMenuItem_Click);
            // 
            // списокТоваровСтраныToolStripMenuItem
            // 
            this.списокТоваровСтраныToolStripMenuItem.Name = "списокТоваровСтраныToolStripMenuItem";
            this.списокТоваровСтраныToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.списокТоваровСтраныToolStripMenuItem.Text = "Список товаров поставляемых страной";
            this.списокТоваровСтраныToolStripMenuItem.Click += new System.EventHandler(this.списокТоваровСтраныToolStripMenuItem_Click);
            // 
            // справкаПоТоварамНаОпрБуквуToolStripMenuItem
            // 
            this.справкаПоТоварамНаОпрБуквуToolStripMenuItem.Name = "справкаПоТоварамНаОпрБуквуToolStripMenuItem";
            this.справкаПоТоварамНаОпрБуквуToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.справкаПоТоварамНаОпрБуквуToolStripMenuItem.Text = "Справка по товарам на опр. букву";
            this.справкаПоТоварамНаОпрБуквуToolStripMenuItem.Click += new System.EventHandler(this.справкаПоТоварамНаОпрБуквуToolStripMenuItem_Click);
            // 
            // справкаПоОбъемуЭкспортаToolStripMenuItem
            // 
            this.справкаПоОбъемуЭкспортаToolStripMenuItem.Name = "справкаПоОбъемуЭкспортаToolStripMenuItem";
            this.справкаПоОбъемуЭкспортаToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.справкаПоОбъемуЭкспортаToolStripMenuItem.Text = "Справка по объему товаров";
            this.справкаПоОбъемуЭкспортаToolStripMenuItem.Click += new System.EventHandler(this.справкаПоОбъемуЭкспортаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(48, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1040, 407);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.importCountryDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.manufacturercountryDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.goodsSystemObjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(94, 492);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(980, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 56);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importCountryDataGridViewTextBoxColumn
            // 
            this.importCountryDataGridViewTextBoxColumn.DataPropertyName = "ImportCountry";
            this.importCountryDataGridViewTextBoxColumn.HeaderText = "Страна-импортёр";
            this.importCountryDataGridViewTextBoxColumn.Name = "importCountryDataGridViewTextBoxColumn";
            this.importCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Объем партии шт.";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturercountryDataGridViewTextBoxColumn
            // 
            this.manufacturercountryDataGridViewTextBoxColumn.DataPropertyName = "Manufacturercountry";
            this.manufacturercountryDataGridViewTextBoxColumn.HeaderText = "Страна-производитель";
            this.manufacturercountryDataGridViewTextBoxColumn.Name = "manufacturercountryDataGridViewTextBoxColumn";
            this.manufacturercountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturercountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodsSystemObjectBindingSource
            // 
            this.goodsSystemObjectBindingSource.DataSource = typeof(Cursproject.goodsSystemObject);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 823);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mainmenu1);
            this.MainMenuStrip = this.Mainmenu1;
            this.Name = "Form1";
            this.Text = "Курсовой проект \"Работа с файлами\"";
            this.Mainmenu1.ResumeLayout(false);
            this.Mainmenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodsSystemObjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mainmenu1;
        private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кооректировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem сохранениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаПоСтранамимпортерамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровСтраныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоТоварамНаОпрБуквуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоОбъемуЭкспортаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource goodsSystemObjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturercountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

