﻿using System;
using System.Collections.Generic;
using UltimateXF.Widget.Charts.Models.CandleStickChart;
using Xamarin.Forms;

namespace DemoXF
{
    public partial class CandleStickChartPage : ContentPage
    {
        public CandleStickChartPage()
        {
            InitializeComponent();

            var entries = new List<CandleStickEntry>();
            entries.Add(new CandleStickEntry(0, 4.62f, 2.02f, 2.70f, 4.13f));
            entries.Add(new CandleStickEntry(1, 5.50f, 2.70f, 3.35f, 4.96f));
            entries.Add(new CandleStickEntry(2, 5.25f, 3.02f, 3.50f, 4.50f));
            entries.Add(new CandleStickEntry(3, 6f, 3.25f, 4.40f, 5.0f));
            entries.Add(new CandleStickEntry(4, 5.57f, 2f, 2.80f, 4.5f));

            var labels = new List<string>();
            labels.Add("col1");
            labels.Add("col2");
            labels.Add("col3");
            labels.Add("col4");
            labels.Add("col5");


            var dataSet4 = new CandleStickDataSet(entries, "Candle DataSet")
            {
                DrawValue = true,
            };
            var data4 = new CandleStickChartData(new List<ICandleStickDataSet>() { dataSet4 }, labels);

            var dataSet5 = new CandleStickDataSet(entries, "Candle DataSet")
            {
                DrawValue = true,
            };
            var data5 = new CandleStickChartData(new List<ICandleStickDataSet>() { dataSet5 }, labels);

            chart.ChartData = data4;
            chart2.ChartData = data5;
        }
    }
}