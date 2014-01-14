using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using NCI.DCEG.BCRA.ConsoleSample;
using NCI.DCEG.BCRA.Engine;

namespace Gail
{
    public partial class Result : PhoneApplicationPage
    {
        public static double absRisk = 0, avgRisk = 0, absRiskPctg = 0, avgRiskPctg = 0;
        public Result()
        {
            InitializeComponent();
            this.Loaded +=new RoutedEventHandler(Result_Loaded);
        }

        private void Result_Loaded(object sender, RoutedEventArgs e)
        {
            int currentAge = BcptConvert.GetCurrentAge(Convert.ToInt32(MainPage.pacientAge));
            int menarcheAge = BcptConvert.GetMenarcheAge(Page3.pacientMenarch);
            int firstLiveBirthAge = BcptConvert.GetFirstLiveBirthAge(Page3.pacientChildbirth);
            int firstDegreeRel = BcptConvert.GetFirstDegRelatives(Page4.pacientRelatives);
            int hadBiopsy = BcptConvert.GetEverHadBiopsy(Page4.pacientBiopsiesOK);
            int numBiopsy = BcptConvert.GetNumberOfBiopsy(Page4.pacientBiopsies);
            int hyperPlasia = BcptConvert.GetHyperPlasia(Page4.pacientHyperplacia);
            int race = BcptConvert.GetRace(Page3.pacientRace);
            Helper.RiskCalc(0, currentAge, currentAge + Convert.ToInt32(Page3.pacientProjectionYears), menarcheAge, firstLiveBirthAge, hadBiopsy, numBiopsy,
               hyperPlasia, firstDegreeRel, race, out absRisk, out avgRisk);
            Helper.CalcPercentage(absRisk, avgRisk, out absRiskPctg, out avgRiskPctg);

            textBlock1.Text = Page3.pacientProjectionYears + " years risk for this woman: " + absRiskPctg.ToString();
            textBlock2.Text = Page3.pacientProjectionYears + " years risk for average woman: " + avgRiskPctg.ToString();
            
            Helper.RiskCalc(0, currentAge, 90 , menarcheAge, firstLiveBirthAge, hadBiopsy, numBiopsy,
               hyperPlasia, firstDegreeRel, race, out absRisk, out avgRisk);
            Helper.CalcPercentage(absRisk, avgRisk, out absRiskPctg, out avgRiskPctg);

            textBlock3.Text = " lifetime risk for this woman: " + absRiskPctg.ToString();
            textBlock4.Text = " lifetime risk for average woman: " + avgRiskPctg.ToString();

            
            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}