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
    public partial class Request1 : Form
    {
        public string Poisk // добавили свойство
        {
            get
            {
                return tbSearch.Text;
            }
        }
        public Request1()
        {
            InitializeComponent();
        }
    }
}
