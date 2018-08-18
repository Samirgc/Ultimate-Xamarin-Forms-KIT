﻿using System.ComponentModel;
using System.Linq;
using Android.Content;
using Android.Widget;
using MikePhil.Charting.Charts;
using MikePhil.Charting.Data;
using MikePhil.Charting.Formatter;
using UltimateXF.Droid.Renderers;
using UltimateXF.Widget.Charts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SupportPieChart), typeof(SupportPieChartRenderer))]
namespace UltimateXF.Droid.Renderers
{
    public class SupportPieChartRenderer : ViewRenderer<SupportPieChart, PieChart>
    {
        private SupportPieChart supportChart;
        private PieChart chartOriginal;

        public SupportPieChartRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SupportPieChart> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                if (Element is SupportPieChart)
                {
                    supportChart = Element as SupportPieChart;
                    chartOriginal = new PieChart(this.Context);
                    chartOriginal.LayoutParameters = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);
                    InitializeChart();
                    SetNativeControl(chartOriginal);
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName.Equals(SupportLineChart.ChartDataProperty.PropertyName))
            {
                InitializeChart();
            }
            SupportChart.OnChartPropertyChanged(e.PropertyName,supportChart, chartOriginal);
        }

        private void InitializeChart()
        {
            if (supportChart != null && supportChart.ChartData != null && chartOriginal != null)
            {
                //SupportChart.OnInitializeChart(supportChart, chartOriginal);

                //var dataSupport = supportChart.ChartData.IF_GetDataSet();

                //var entryOriginal = dataSupport.IF_GetEntry().Select(item => new PieEntry(item.GetPercent(),item.GetText()));
                //PieDataSet dataSet = new PieDataSet(entryOriginal.ToArray(), dataSupport.IF_GetTitle());
                //dataSet.SetColors(dataSupport.IF_GetDataColorScheme().Select(item=>item.ToAndroid().ToArgb()).ToArray());

                //PieData data = new PieData(dataSet);
                //data.SetValueFormatter(new PercentFormatter());
                //data.SetValueTextSize(supportChart.ChartData.ValueDisplaySize);
                //data.SetValueTextColor(supportChart.ChartData.ValueDisplayColor.ToAndroid());
                //chartOriginal.SetEntryLabelColor(supportChart.ChartData.TextDisplayColor.ToAndroid());
                //chartOriginal.SetEntryLabelTextSize(supportChart.ChartData.TextDisplaySize);
                //chartOriginal.Data = data;
            }
        }
    }
}