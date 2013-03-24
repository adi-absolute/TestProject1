using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    using chartType = System.Windows.Forms.DataVisualization.Charting.Chart;
    using seriesType = System.Windows.Forms.DataVisualization.Charting.Series;
    using pointType = System.Windows.Forms.DataVisualization.Charting.DataPoint;
    using labelType = System.Windows.Forms.DataVisualization.Charting.CustomLabel;

    public class GUIRenderer
    {
        ILadder myLadder;
        chartType myChart;
        seriesType[] dataSeries = new seriesType[5];
        labelType[,] xLabel = new labelType[5,9];
        
        public GUIRenderer(ILadder l)
        {
            myLadder = l;
        }

        void InitialiseSeries()
        {

            int n = 8;
                
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

                for (int j = 0; j < 9; j++)
                {
                    xLabel[i, j] = new labelType();
                    xLabel[i, j].FromPosition = 0.5 + j;
                    xLabel[i, j].ToPosition = 1.5 + j;
                    xLabel[i, j].Text = ILadder.rankMap[n--];
                    myChart.ChartAreas[i].AxisX.CustomLabels.Add(xLabel[i, j]);
                }
                n += 18;
            }

        }

        public void AddPointToChart(string label, Rank rank)
        {
            int subRank = 9 - ((int)rank.RankNumber % 9);
            int subRung = ((int)rank.RungPosition % 4);
            int seriesNumber = ((int)rank.RankNumber / 9);
            pointType dP2 = new pointType(subRank, subRung);

            dP2.Color = System.Drawing.Color.Fuchsia;
            dP2.Label = label;
            dP2.MarkerSize = 10;

            dataSeries[seriesNumber].Points.Add(dP2);
        }

        public void AddPlayerToChart(Player p)
        {
            Rank rank = p.myRank;

            int subRank = 9 - ((int)rank.RankNumber % 9);
            int subRung = ((int)rank.RungPosition % 4);
            int seriesNumber = ((int)rank.RankNumber / 9);
            pointType dP2 = new pointType(subRank, subRung);

            dP2.Color = System.Drawing.Color.Fuchsia;
            dP2.Label = p.myName;
            dP2.MarkerSize = 10;
            dP2.Name = p.myID.ToString();

            dataSeries[seriesNumber].Points.Add(dP2);
        }

        public void RemovePlayerFromChart(Player p)
        {
            Rank rank = p.myRank;

            //int subRank = 9 - ((int)rank.RankNumber % 9);
            //int subRung = ((int)rank.RungPosition % 4);
            int seriesNumber = ((int)rank.RankNumber / 9);

            pointType dP = dataSeries[seriesNumber].Points.FindByValue(p.myID);

            dataSeries[seriesNumber].Points.Remove(dP);
        }


        public GUIRenderer(chartType chart)
        {
            myChart = chart;
            InitialiseSeries();
        }
        
    }
}
