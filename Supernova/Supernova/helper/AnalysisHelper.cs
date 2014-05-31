using Supernova.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.helper
{
    class AnalysisHelper
    {
        AnalysisLoad aloader = new AnalysisLoad();


        public int[] getSeriesDepartment(int DepID)
        {
            int[] DepSeries = new int[6];
            DataTable dt1 = aloader.LoadDepartmentCapacity(DepID);
            DataTable dt2 = aloader.LoadCalcDepartmentCapacity(DepID);

            int y = 0;
            for (int i = 0; i <= 2; i++)
            {
                DepSeries[y] = Convert.ToInt32(dt1.Rows[0][i].ToString());
                y++;
                DepSeries[y] = Convert.ToInt32(dt1.Rows[0][i].ToString());
                y++;
            }

            return DepSeries;
        }

        public double[] getSeriesBudget()
        {
            double[] BudgetSeries = new double[6];
            DataTable dt1 = aloader.LoadBudget();
            DataTable dt2 = aloader.LoadCalcBudget();

            int y = 0;
            for (int i = 0; i <= 2; i++)
            {
                BudgetSeries[y] = Convert.ToDouble(dt1.Rows[0][i].ToString());
                y++;
                BudgetSeries[y] = Convert.ToDouble(dt2.Rows[0][i].ToString());
                y++;
            }

            return BudgetSeries;
        }

        public int[] getSeriesStrategyValue()
        {
            int[] Strat = new int[5];

            DataTable dt = aloader.LoadStrategy();

            for (int i = 0; i <= 4; i++)
            {
                Strat[i] = Convert.ToInt32(dt.Rows[i][1].ToString());
            }
            return Strat;
        }
        public String[] getSeriesStrategyName()
        {
            String[] Strat = new String[5];

            DataTable dt = aloader.LoadStrategy();

            for (int i = 0; i <= 4; i++)
            {
                Strat[i] = dt.Rows[i][0].ToString();
            }
            return Strat;
        }
        public int[] getSeriesCategoryValue()
        {
            int[] Cat = new int[7];

            DataTable dt = aloader.LoadCategory();

            for (int i = 0; i <= 6; i++)
            {
                Cat[i] = Convert.ToInt32(dt.Rows[i][1].ToString());
            }
            return Cat;
        }
        public String[] getSeriesCategoryyName()
        {
            String[] Cat = new String[7];

            DataTable dt = aloader.LoadCategory();

            for (int i = 0; i <= 6; i++)
            {                
                Cat[i] =dt.Rows[i][0].ToString();
            }
            return Cat;
        }
        public double[] getProjectAnalysis(int ProjID)
        {
            double[] Values = new double[3];

            DataTable dt = aloader.LoadProjectAnalysis(ProjID);

            for (int i = 0; i <= 2; i++)
            {
                Values[i] = Convert.ToDouble(dt.Rows[0][i].ToString());
            }

            return Values;
        }


    }
}
