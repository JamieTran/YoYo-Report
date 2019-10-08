using System;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using Timer = System.Windows.Forms.Timer;

namespace YoYo
{
    public partial class YoYo : Form
    {
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

        private readonly DbReader _yoyoConnection = new DbReader();
        private static System.Timers.Timer refreshTimer;

        public YoYo()
        {
            InitializeComponent();
            PopulateProductCb();
            RefreshPage();

            // trying to get refreshing to work async
            //refreshTimer = new System.Timers.Timer(5000);
            //refreshTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //refreshTimer.Enabled = true;
        }

        public void PopulateProductCb()
        {
            foreach (var productId in _productIds) ProductCb.Items.Add(productId);
            ProductCb.SelectedIndex = 0;
        }

        public void SetupChart()
        {
            var failures = _yoyoConnection.GetReasons();
            int totalFails = 0;
            foreach (var failure in failures)
            { 
                if (!string.IsNullOrEmpty(failure))
                {
                    int failureCount = _yoyoConnection.GetFailureCount(failure, ProductCb.SelectedIndex);
                    totalFails += failureCount;
                    paretoChart.Series[0].Points.Add(new SeriesPoint(failure, failureCount));

                    paretoChart.Series[1].Points.Add(new SeriesPoint(failure, totalFails));
                }
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {
            UpdateMetrics();
            paretoChart.Series[0].Points.Clear();
            paretoChart.Series[1].Points.Clear();
            SetupChart();
        }

        private void ProductCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void UpdateMetrics()
        {
            double moldsTotal = _yoyoConnection.GetNumberOfPartsByState(ProductCb.SelectedIndex, "Mold");
            double moldSuccess = _yoyoConnection.GetNumberOfSuccessParts(ProductCb.SelectedIndex, "Mold");
            double moldYield = moldSuccess / moldsTotal * 100;

            double paintTotal = _yoyoConnection.GetNumberOfPartsByState(ProductCb.SelectedIndex, "Paint");
            double paintSuccess = _yoyoConnection.GetNumberOfSuccessParts(ProductCb.SelectedIndex, "Paint");
            var paintYield = paintSuccess / moldsTotal * 100;

            double assemblyTotal = _yoyoConnection.GetNumberOfPartsByState(ProductCb.SelectedIndex, "Assembly");
            double assemblySuccess = _yoyoConnection.GetNumberOfSuccessParts(ProductCb.SelectedIndex, "Assembly");
            double assemblyYield = assemblySuccess / moldsTotal * 100;

            double packageSuccess = _yoyoConnection.GetNumberOfSuccessParts(ProductCb.SelectedIndex, "Package");
            double packageYield = packageSuccess / moldsTotal * 100;

            moldsTotalLabel.Text = moldsTotal.ToString();
            moldsSuccessLabel.Text = moldSuccess.ToString();
            moldsYieldLabel.Text = $@"{moldYield:0.00}%";

            paintTotalLabel.Text = paintTotal.ToString();
            paintSuccessLabel.Text = paintSuccess.ToString();
            paintYieldLabel.Text = $@"{paintYield:0.00}%";

            assemblyTotalLabel.Text = assemblyTotal.ToString();
            assemblySuccessLabel.Text = assemblySuccess.ToString();
            assemblyYieldLabel.Text = $@"{assemblyYield:0.00}%";

            packageYieldLabel.Text = $@"{packageYield:0.00}%";
        }
    }
}