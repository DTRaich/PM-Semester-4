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
                BudgetSeries[y] = Convert.ToDouble(dt1.Rows[0][i].ToString());
                y++;
            }

            return BudgetSeries;
        }


    }
}
