using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// добавил новый using для более низкоуровневого доступа к файлам
using System.Xml.Serialization; // добавил новый using для сериализации в формат XML
using System.Xml.Linq;

namespace Cursproject
{
    public partial class Form1 : Form
    {
        BindingList<goodsSystemObject> goodsSystemObjects = new BindingList<goodsSystemObject>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = goodsSystemObjects; // подключаем
        }
        private void добавлениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var goodsObjectForm = new goodsObjectForm(); // создаем экземпляр формы
            // 1. создам экземпляр класса **SolarObject**
            var goodsObject = new goodsSystemObject();
            // 2. Передам этот **объект** на заполнение ново-созданной форме
            goodsObjectForm.goodsObjectField = goodsObject;
            // если нажали кнопку OK (именно для этого мы кнопке поставили свойство DialogResul)
            if (goodsObjectForm.ShowDialog() == DialogResult.OK)
            {
                this.goodsSystemObjects.Add(goodsObject); // добавляем объект в список
            }
        }
        private void сохранениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)//Если в файле нет записей
            {
                MessageBox.Show("Вы не можете сохранить пустой файл");
                return;
            }
            // создаю окно диалога для выбора файла для сохранения
            // в отличии от OpenFileDialog позволяет выбирать не существующие файлы
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK) // проверяем что файл выбрали и нажали ok
                return;

            // создаю сериализатор в XML, то есть класс у которого есть функция,
            // которая умеет преобразовывать классы, помеченные [Serializable]
            // в текстовые файлы особого вида, так называемые XML-ки
            // указываем что хотим хранить массив объектов типа SolarSystemObject
            var serializer = new XmlSerializer(typeof(goodsSystemObject[]));
            // для доступа к файлу используется класс FileStream 
            // FileMode.OpenOrCreate -- указание как работать с файлом,
            // типа, если есть файл, то открой его, и перезапиши все что в нем есть,
            // а если файла нет, то создай сначала, а потом открой.
            // когда файл открывается с помощью FileStream он блокируется системой на доступ 
            // using -- гарантирует нам что по выполнению блока, следующего за using, поток будет закрыт и доступ к файлу освободится. 
            using (var fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
            {
                // так как указали что хотим хранить массив, преобразуем список в массив ToArray()
                serializer.Serialize(fs, this.goodsSystemObjects.ToArray());
            }
            MessageBox.Show("Файл сохранен");
        }
        private void загрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // тут используем OpenFileDialog, потому что нам нужен существующий файл
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            var serializer = new XmlSerializer(typeof(goodsSystemObject[]));
            // тут используем FileMode.Open
            using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                // тут уже похитрее, вызывая serializer.Deserialize(fs), мы считываем данные из файла,
                // мы используем явное указание типа путем добавления конструкции (SolarSystemObject[])
                // Почему именно такую конструкцию? 
                // Потому что выше создавая сериалайзер мы передавали параметром typeof(SolarSystemObject[])
                var arrayOfgoodsObjects = (goodsSystemObject[])serializer.Deserialize(fs);

                // очищаем существующий список с объектами
                this.goodsSystemObjects.Clear();

                // и последовательно по одному добавляем содержимое arrayOfSolarObjects, 
                // который содержит набор объектов считанных из файла
                foreach (var solarObject in arrayOfgoodsObjects)
                {
                    this.goodsSystemObjects.Add(solarObject);
                }
            }
        }
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // если в таблице нет активных строк, просто выходим
            if (this.dataGridView1.CurrentRow == null)
                return;

            // по номеру активной строки выбираем в списке goodsSystemObjects (где содержатся данные таблицы) активный объект
            var goodsSystemObject = this.goodsSystemObjects[this.dataGridView1.CurrentRow.Index];

            // создаем форму для редактирования
            var goodsObjectForm = new goodsObjectForm();

            // привязываем к ней активный объект
            goodsObjectForm.goodsObjectField = goodsSystemObject;

            // открываем новую форму в виде модального окна
            goodsObjectForm.ShowDialog();
            dataGridView1.InvalidateRow(this.dataGridView1.CurrentRow.Index); // даем команду перерисовать строчку
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить запись", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) // проверяем нажали ли Yes
                return;
            // удаляем запись
            this.goodsSystemObjects.RemoveAt(this.dataGridView1.CurrentRow.Index);
        }

        private void справкаПоСтранамимпортерамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)//Если в файле нет записей
            {
                MessageBox.Show("Добавьте записи в файл!");
                return;
            }
            //using удаляет форму из памяти по закрытию
            using (var form = new Request1())
            {
                if (form.ShowDialog() != DialogResult.OK) // проверяем что нажали OK
                    return;
                if (form.Poisk == "")//если ничего не ввели
                {
                    MessageBox.Show("Вы ничего не ввели");
                    Request1 newForm = new Request1();
                    newForm.Show(); 
                    return;
                }
                string spravka = " ";
                foreach (var temp in this.goodsSystemObjects)
                {
                    if (temp.Name == form.Poisk) // если название содержит введенный текст
                    {
                        spravka = temp.Name;
                        MessageBox.Show("Страны-производители:  " + temp.Manufacturercountry);
                        break;
                    }
                }
                if (spravka == " ") MessageBox.Show("Введенный товар не найден");
            }
        }

        private void списокТоваровСтраныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)//Если в файле нет записей
            {
                MessageBox.Show("Добавьте записи в файл!");
                return;
            }
            //using удаляет форму из памяти по закрытию
            using (var form = new Request2())
            {
                if (form.ShowDialog() != DialogResult.OK) // проверяем что нажали OK
                    return;
                if (form.Poisk2 == "")//если ничего не ввели
                {
                    MessageBox.Show("Вы ничего не ввели");
                    Request2 newForm = new Request2();
                    newForm.Show();
                    return;
                }
                string spravka = " ";
                //Создание списка, в который будут помещены наши товары
                var goods= new List<string>();
                foreach (var temp in this.goodsSystemObjects)
                {
                    if (temp.Manufacturercountry == form.Poisk2) // если название содержит введенный текст
                    {
                        spravka = temp.Manufacturercountry;
                        //Добавляем в список нзвания товаров
                        goods.Add(temp.Name);
                    }
                }
                //Выводим список с товарами в окно сообщений
                MessageBox.Show("Товары: " + String.Join("\n", goods));
                if (spravka == " ") MessageBox.Show("Введенная страна не найдена");
            }
        }
        private void справкаПоТоварамНаОпрБуквуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)//Если в файле нет записей
            {
                MessageBox.Show("Добавьте записи в файл!");
                return;
            }
            // так как мы не просто закрываем форму, а на самом деле просто прячем ее, когда нажимаем OK
            // чтобы она в памяти не висела, используем конструкцию using, 
            // которая гарантирует удаление формы из памяти по завершению функции
            using (var form = new Request3())
            {
                if (form.ShowDialog() != DialogResult.OK) // проверяем что нажали OK
                    return;
                if (form.Poisk3 == "")//если ничего не ввели
                {
                    MessageBox.Show("Вы ничего не ввели");
                    Request3 newForm = new Request3();
                    newForm.Show();
                    return;
                }
                string spravka = " ";
                var goods2 = new List<string>();
                foreach (var temp in this.goodsSystemObjects)
                {
                    if (temp.Name.Contains(form.Poisk3)) // если название содержит введенный текст
                    {
                        spravka = temp.ImportCountry;
                        goods2.Add(temp.Name); // добавляем название в список
                    }
                }
                // выводим список названий планет
                // тут я использую функцию String.Join, у которой два параметра разделитель
                // я указал "\n" -- это перенос на новую строку
                // а второй параметр — это список значений, я передаю
                // список планет удовлетворяющих поисковой строке
                // ну а дальше просто вывожу все на экран
                MessageBox.Show(String.Join("\n", goods2));
                if(spravka == " ") MessageBox.Show("Введенный товар не найден");
            }
        }
        private void справкаПоОбъемуЭкспортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)//Если в файле нет записей
            {
                MessageBox.Show("Добавьте записи в файл!");
                return;
            }
            //using удаляет форму из памяти по закрытию
            using (var form = new Request4())
            {
                if (form.ShowDialog() != DialogResult.OK) // проверяем что нажали OK
                    return;
                if (form.Poisk4 == "")//если ничего не ввели
                {
                    MessageBox.Show("Вы ничего не ввели");
                    Request4 newForm = new Request4();
                    newForm.Show();
                    return;
                }
                float sum= 0;
                string spravka = " ";
                foreach (var temp in this.goodsSystemObjects)
                {
                    if (temp.ImportCountry == form.Poisk4) // если название содержит введенный текст
                    {
                        spravka = temp.ImportCountry;
                        if (spravka == temp.ImportCountry)
                            sum += temp.Volume;
                        MessageBox.Show("Объем товаров:  " + sum);
                        break;
                    }
                }
                if (spravka == " ") MessageBox.Show("Введенная страна не найдена");
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить запись", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) // проверяем нажали ли Yes
                return;
            // удаляем запись
            this.goodsSystemObjects.RemoveAt(this.dataGridView1.CurrentRow.Index);
        }
    }
    [Serializable] //сериализируем, т.е. переводим в более удобный для хранения формат
    public class goodsSystemObject
    {
        //{ get; set; } показывает, что это поле не просто переменная внутри класса, а целое Свойство
        public string Name { get; set; } // Название страны
        public string ImportCountry { get; set; } // Страна-импортер
        public float Volume { get; set; } // Объем товаров
        public string Manufacturercountry { get; set; } // Страна-производитель
    }
}
