/* File: YoYo.cs
 * Project: Business Intelligence Assignment 02
 * Author: Jamie Tran
 * Description: This file in the initializer for the forms page and contains all the business logic for displaying, and updating the metrics/graph on the page
 */

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace YoYo
{

    /// <summary>
    /// YoYo class that inherits a form acting as the main page
    /// </summary>
    public partial class YoYo : Form
    {

        /// <summary>
        /// The constant product Ids hard coded
        /// </summary>
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

        /// <summary>
        /// the DB reader
        /// </summary>
        private readonly DbReader _yoyoConnection = new DbReader();

        /// <summary>
        /// constructor
        /// </summary>
        public YoYo()
        {
            InitializeComponent();
            PopulateProductCb();
            SetupChart();
            UpdateMetrics();
        }

        /// <summary>
        /// this method populates the 
        /// </summary>
        public void PopulateProductCb()
        {
            foreach (var productId in _productIds) ProductCb.Items.Add(productId);
            ProductCb.SelectedIndex = 0;
        }

        /* Function: SetupChart()
         * return : void
         * input : vooid
         * description: populates the chart with the data from the database
         */
        public void SetupChart()
        {
            var failures = _yoyoConnection.GetReasons();
            

            int selectedIndex = ProductCb.SelectedIndex;
            paretoChart.Titles[0].Text = selectedIndex == 0 ? $@"Reasons For Rejection (All)" : $@"Reasons For Rejection ({_productIds[selectedIndex-1]})";

            foreach (var failure in failures)
            { 
                if (!string.IsNullOrEmpty(failure))
                {
                    int failureCount = _yoyoConnection.GetFailureCount(failure, ProductCb.SelectedIndex);
                    paretoChart.Series[0].Points.Add(new SeriesPoint(failure, failureCount));

                }
            }

            int totalFails = 0;
            foreach (var failure in failures)
            {
                if (!string.IsNullOrEmpty(failure))
                {
                    int failureCount = _yoyoConnection.GetFailureCount(failure, ProductCb.SelectedIndex);
                    totalFails += failureCount;

                    paretoChart.Series[1].Points.Add(new SeriesPoint(failure, totalFails));
                }
            }
        }

        /* Function: ProductCB_SelectedIndexChanged()
         * return : void
         * input : object sender, EventArgs e
         * description: refreshes the screen when combo box changed
         */
        private void ProductCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMetrics();
            paretoChart.Series[0].Points.Clear();
            paretoChart.Series[1].Points.Clear();
            SetupChart();
        }

        /* Function: UpdateMetrics()
         * return : void
         * input : void
         * description: updates all the labels on the page
         */
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

        /* Function: Refresh_Click()
        * return : void
        * input : object sender, EventArgs e
        * description: refreshes the screen when refresh is pressed
        */
        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateMetrics();
            paretoChart.Series[0].Points.Clear();
            paretoChart.Series[1].Points.Clear();
            SetupChart();
        }
    }


}