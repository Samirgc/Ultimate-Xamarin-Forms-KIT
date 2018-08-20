﻿using System;
using System.Collections.Generic;
using UltimateXF.Widget.Charts.Models.RadarChart;
using Xamarin.Forms;

namespace DemoXF
{
    public partial class RadarChartPage : ContentPage
    {
        public RadarChartPage()
        {
            InitializeComponent();

            var entries = new List<RadarEntry>();
            var entries2 = new List<RadarEntry>();
            var labels = new List<string>();

            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                entries.Add(new RadarEntry(random.Next(100)));
                entries2.Add(new RadarEntry(random.Next(100)));
                labels.Add("Entry" + i);
            }

            var dataSet5 = new RadarDataSet(entries2, "Radar DataSet 1")
            {
                Colors = new List<Color>{
                    Color.Red
                },
                FillColor = Color.Red,
                DrawFilled = true,
                DrawValues = false,
            };

            var dataSet4 = new RadarDataSet(entries, "Radar DataSet 2")
            {
                Colors = new List<Color>{
                    Color.Green
                },
                FillColor = Color.Green,
                DrawFilled = true,
                DrawValues = false,
            };
            var data4 = new RadarChartData(new List<IRadarDataSet>() { dataSet4,dataSet5 }, labels);

            radarChart.ChartData = data4;
        }
    }
}