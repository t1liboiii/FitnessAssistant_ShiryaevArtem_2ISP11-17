using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper
{
   public class bmi
    {
        public static string BMI(double weight, double height)
        {
            string res = "";
            double bmi = weight / (height * height);
            if (height <= 0)
            {
                res = "Некорректные данные";
            }
            else if (bmi < 16 && bmi > 0)
            {

                res = "Острый дефицит массы тела";
            }
            else if (bmi >= 16 && bmi <= 18.5)
            {

                res = "Недостаточная масса тела";
            }
            else if (bmi > 18.5 && bmi <= 25)
            {
                res = "Нормальная масса тела";
            }
            else if (bmi > 25 && bmi <= 30)
            {
                res = "Лишний вес";
            }

            else if (bmi > 30 && bmi <= 35)
            {
                res = "Ожирение 1-й степени";
            }
            else if (bmi > 35 && bmi <= 40)
            {
                res = "Ожирение 2-й степени";
            }
            else if (bmi > 40)
            {
                res = "Ожирение 3-й степени";
            }
            else if (bmi == 0)
            {
                res = "Ошибка";
            }

            return res;
        }
        public static string BMR(string Gender, double weight, double height, int age)
        {
            string res = "";

            if (weight <= 0 || height <= 0 || age <= 0)
            {
                res = "Ошибка";
            }

            else if (Gender == "Мужской")
            {
                res = (66 + (13.7 * weight) + (5 * height) - (6.8 * age)).ToString();
            }
            else
            {
                res = (655 + (9.6 * weight) + (1.8 * height) - (4.7 * age)).ToString();
            }

            return res;
        }
    }
}

