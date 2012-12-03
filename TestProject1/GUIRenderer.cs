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

        public void R2(string blah)
        {
            System.Windows.Forms.DataVisualization.Charting.DataPoint dP2 
                = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series seriesNew 
                = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesNew.ChartArea = "ChartArea2";
            seriesNew.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            seriesNew.Legend = "LegendNew";
            seriesNew.Name = blah; 
            seriesNew.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            dP2.Color = System.Drawing.Color.Fuchsia;
            dP2.Label = "Adi";
            dP2.MarkerSize = 10;
            seriesNew.MarkerStyle 
                = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            
            myChart.Series.Add(seriesNew);
            //seriesNew.Points.Add(dP2);
            
        }

        public void ShowPlayer(Player p)
        {
            System.Windows.Forms.DataVisualization.Charting.DataPoint dP2
                = new System.Windows.Forms.DataVisualization.Charting.DataPoint((double)p.GetRankNumber(), (double)p.GetRungPosition());
            System.Windows.Forms.DataVisualization.Charting.Series seriesNew
                = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesNew.ChartArea = "ChartArea2";
            seriesNew.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            seriesNew.Legend = "LegendNew";
            seriesNew.Name = "test";
            seriesNew.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            dP2.Color = System.Drawing.Color.Fuchsia;
            dP2.Label = p.myName;
            dP2.MarkerSize = 10;
            seriesNew.MarkerStyle
                = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;

            myChart.Series.Add(seriesNew);
            seriesNew.Points.Add(dP2);
        }

        public void Render()
        {
            
        }
    }
}
