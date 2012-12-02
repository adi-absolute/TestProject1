using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    using xxx = System.Windows.Forms.DataVisualization.Charting.Chart;

    public class GUIRenderer
    {
        System.Windows.Forms.DataVisualization.Charting.CustomLabel cL1 
            = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
        ILadder myLadder;
        xxx myChart;

        public GUIRenderer(ILadder l)
        {
            myLadder = l;
        }

        public GUIRenderer(xxx chart)
        {
            myChart = chart;
        }

        public void R2()
        {
            System.Windows.Forms.DataVisualization.Charting.DataPoint dP2 
                = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series seriesNew 
                = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesNew.ChartArea = "ChartArea2";
            seriesNew.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            seriesNew.Legend = "LegendNew";
            seriesNew.Name = "SeriesNew"; 
            seriesNew.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            dP2.Color = System.Drawing.Color.Fuchsia;
            dP2.Label = "Adi";
            dP2.MarkerSize = 10;
            seriesNew.MarkerStyle 
                = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            
            
            //dP2.LegendText = "";
            myChart.Series.Add(seriesNew);
            seriesNew.Points.Add(dP2);
        }

        public void Render()
        {
            //myLadder.chart1.Series.Add(
            //using x = System.Windows.Forms.DataVisualization.Charting.ChartArea;

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 
                = new System.Windows.Forms.DataVisualization.Charting.ChartArea();

            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.IntervalOffset = -0.5D;
            chartArea5.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX.ScaleView.Position = 0D;
            chartArea5.AxisX.ScaleView.Size = 9D;
            chartArea5.AxisY.Interval = 1D;
            chartArea5.AxisY.IntervalOffset = -0.5D;
            chartArea5.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.IsReversed = true;
            chartArea5.AxisY.MajorGrid.Interval = 1D;
            chartArea5.AxisY.MajorGrid.IntervalOffset = 0.5D;
            chartArea5.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.AxisY.MajorTickMark.Interval = 1D;
            chartArea5.AxisY.ScaleView.Position = -0.5D;
            chartArea5.AxisY.ScaleView.Size = 2D;
            chartArea5.AxisY.ScrollBar.Enabled = false;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.InnerPlotPosition.Auto = false;
            chartArea5.InnerPlotPosition.Height = 74.80259F;
            chartArea5.InnerPlotPosition.Width = 95F;
            chartArea5.InnerPlotPosition.X = 5F;
            chartArea5.InnerPlotPosition.Y = 25.19741F;
            chartArea5.Name = "ChartArea4";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 12F;
            chartArea5.Position.Width = 90F;
            chartArea5.Position.X = 3F;
            chartArea5.Position.Y = 62F;
            //ILadder.chart

            myLadder.chart1.ChartAreas.Add(chartArea5);
            
        }
    }
}
