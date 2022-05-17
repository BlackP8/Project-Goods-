using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursproject
{
    public partial class goodsObjectForm : Form
    {
        private goodsSystemObject goodsObjectField1; // это скрытое поле, в котором будет хранится непосредственно объект

        // а это определенно свойство, которое представляет собой своего рода посредника между формой и скрытым полем
        // так как этот посредник ничего хранить сам не может он использует для этого скрытое поле 
        public goodsSystemObject goodsObjectField
        {
            get // когда мы обращаемся к goodsObjectForm.goodsObjectField вызывается этот метод
            {
                return this.goodsObjectField1; // который просто возвращает скрытое поле
            }
            set // а этот метод вызывается, когда мы присваиваем значения, например, goodsObjectForm.goodsObjectField = goodsObject
            {
                // value -- это ключевое слово, которое хранит переданное свойству значение
                // мы присваиваем скрытому полю значение value
                this.goodsObjectField1 = value;
                // а дальше заполняем поля на форме
                tbName.Text = this.goodsObjectField1.Name;
                tbImportCountry.Text = this.goodsObjectField1.ImportCountry;
                tbVolume.Text = this.goodsObjectField1.Volume.ToString();
                tbManufacturercountry.Text = this.goodsObjectField1.Manufacturercountry;
            }
        }
        public goodsObjectForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                goodsObjectField.Name = tbName.Text;
                goodsObjectField.ImportCountry = tbImportCountry.Text;
                goodsObjectField.Volume = float.Parse(tbVolume.Text);
                goodsObjectField.Manufacturercountry = tbManufacturercountry.Text;
            }
            catch (FormatException) // чтоб программа не падала если ввели некорректный данные
            {
                // чтобы модальное окно не закрывалось при некорректных данных
                this.DialogResult = DialogResult.None;
                return;
            }
        }
    }
}
