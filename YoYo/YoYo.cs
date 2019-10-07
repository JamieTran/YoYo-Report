using System;
using System.Linq;
using System.Windows.Forms;

namespace YoYo
{
    public partial class YoYo : Form
    {
        private DbReader yoyoConnection = new DbReader();
        public YoYo()
        {
            InitializeComponent();
        }
    }
}
