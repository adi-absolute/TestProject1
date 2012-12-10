using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    using chartType = System.Windows.Forms.DataVisualization.Charting.Chart;
    using seriesType = System.Windows.Forms.DataVisualization.Charting.Series;
    using pointType = System.Windows.Forms.DataVisualization.Charting.DataPoint;

    public class GUIRenderer
    {
        ILadder myLadder;
        chartType myChart;
        seriesType[] dataSeries = new seriesType[5];

        public GUIRenderer(ILadder l)
        {
            myLadder = l;
        }

        void InitialiseSeries()
        {
            foreach (var label in myChart.ChartAreas[0].AxisY.l)
            {
                label.Text = (double.Parse(label.Text) - 150).ToString();
            }

            for (int i = 0; i < 5; i++)
            {
                dataSeries[i] = new seriesType();
                dataSeries[i].ChartArea = "ChartArea" + (i + 1);
                dataSeries[i].ChartType
                    = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                dataSeries[i].Name = "SeriesRT" + (i + 1);
                dataSeries[i].XValueType 
                    = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
                dataSeries[i].MarkerStyle
                    = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
                myChart.Series.Add(dataSeries[i]);
            }
        }

        public void AddPointToChart(string label, Rank rank)
        {
            int r1 = ((int)rank.RankNumber % 9) + 1;
            int r2 = ((int)rank.RungPosition % 4) + 1;
            int s1 = ((int)rank.RankNumber / 9);
            pointType dP2 = new pointType(r1, r2);

            dP2.Color = System.Drawing.Color.Fuchsia;
            dP2.Label = label;
            dP2.MarkerSize = 10;

            dataSeries[s1].Points.Add(dP2);
        }


        public GUIRenderer(chartType chart)
        {
            myChart = chart;
            InitialiseSeries();
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
