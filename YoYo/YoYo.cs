using System;
using System.Linq;
using System.Windows.Forms;

namespace YoYo
{
    public partial class YoYo : Form
    {
        private DbReader _yoyoConnection = new DbReader();

        // maybe get this from db?
        private readonly string[] _productIds =
        {
            "OriginalSleeper",
            "BlackBeauty",
            "Firecracker",
            "LemonYellow",
            "MidnightBlue",
            "ScreamingOrange",
            "GoldGlitter",
            "WhiteLightning"
        };

        public YoYo()
        {
            InitializeComponent();
            PopulateProductCb();
        }

        public void PopulateProductCb()
        {
            foreach (string productId in _productIds)
            {
                ProductCb.Items.Add(productId);
            }

            ProductCb.SelectedIndex = 0;
        }

        private void ProductCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
