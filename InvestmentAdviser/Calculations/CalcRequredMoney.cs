using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InvestmentAdviser
{
    class CalcRequiredMoney
    {
        public static double AmountOfMonthlyInvestment(double asset_goal, double asset_now, double period, double ret)
        {
            double num_invest_per_year = 12;
            //double N = period * num_invest_per_year;
            double dt = 1 / num_invest_per_year;

            double exp_minus_rdt = Math.Exp(-ret * dt);
            double exp_minus_Nrdt = Math.Exp(- ret * period);

            double dY_t = asset_goal * Math.Exp(-ret * period) - asset_now;
            double coefficient = (1 - exp_minus_rdt) /(1 - exp_minus_Nrdt);

            double MonthlyInvestment = dY_t * coefficient;

            return MonthlyInvestment;
        }
    }
}
