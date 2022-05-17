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
    public partial class Request3 : Form
    {
        public string Poisk3 // добавили свойство
        {
            get // при обращении к этому свойству получим содержимое текста в textBox1
            {
                return tbSearch3.Text;
            }
        }
        public Request3()
        {
            InitializeComponent();
        }
    }
}
