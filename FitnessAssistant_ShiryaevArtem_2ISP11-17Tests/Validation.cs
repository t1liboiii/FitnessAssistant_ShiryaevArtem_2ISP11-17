using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FitnessAssistant_ShiryaevArtem_2ISP11_17Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidationPassword_Length7_False()
        {
            // Arrange 
            string Password = "A@1werw";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_CorrectPassword_True()
        {
            // Arrange 
            string Password = "A@1waaerw";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_Lenght21_False()
        {
            // Arrange 
            string Password = "A@1qwertyuiop[asdfghk";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_Punctuation_False()
        {
            // Arrange 
            string Password = "A1ssswerw";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_Digit_False()
        {
            // Arrange 
            string Password = "A@wwwwerw";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_CharUpper_False()
        {
            // Arrange 
            string Password = "aaa@1werw";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_CharLower_False()
        {
            // Arrange 
            string Password = "AAA@1WERW";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_IsNullOrWhiteSpace_False()
        {
            // Arrange 
            string Password = "             ";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_IsNull_False()
        {
            // Arrange 
            string Password = "";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Space_False()
        {
            //Arrange
            string Password = "Aa@ Aa2";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationPassword(Password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_IsDigit_False()
        {
            //Arrange
            string Name = "aAqw1";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_CharLower_False()
        {
            //Arrange
            string Name = "AAAAA";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_CharUper_False()
        {
            //Arrange
            string Name = "aaaaa";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_CharPunctuation_False()
        {
            //Arrange
            string Name = "Ab@w";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_CorrectName_True()
        {
            //Arrange
            string Name = "Ivan";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_Length3_False()
        {
            //Arrange
            string Name = "Iva";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_Length31_False()
        {
            //Arrange
            string Name = "Ivannnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_IsNullOrWhiteSpace_False()
        {
            // Arrange 
            string Name = "             ";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationName_IsNull_False()
        {
            // Arrange 
            string Name = "";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationName_NameSpace_False()
        {
            //Arrange
            string Name = "Iv an";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationName_Dash_False()
        {
            //Arrange
            string Name = "Ivan-";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationName(Name);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationDate_ValueCorrect_True()
        {
            //Arrange
            DateTime date = new DateTime(2016, 02, 20);
            bool ex = true;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationDateBirthday(date);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationDate_ValueFuture_False()
        {
            //Arrange
            DateTime date = new DateTime(2022, 09, 17);
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationDateBirthday(date);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationDate_ValuePast_False()
        {
            //Arrange
            DateTime date = new DateTime(1900, 04, 20);
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationDateBirthday(date);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLName_IsDigit_False()
        {
            //Arrange
            string LName = "aAqw1";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_CharLower_False()
        {
            //Arrange
            string LName = "AAAAA";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_CharUper_False()
        {
            //Arrange
            string LName = "aaaaa";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_CharPunctuation_true()
        {
            //Arrange
            string LName = "Ivan-";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_CorrectLName_True()
        {
            //Arrange
            string LName = "Ivan";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_Length3_False()
        {
            //Arrange
            string LName = "Iva";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_Length21_False()
        {
            //Arrange
            string LName = "Ivannnnnnnnnnnnnnnnnn";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_IsNullOrWhiteSpace_False()
        {
            // Arrange 
            string LName = "             ";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert 
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationLName_IsNull_False()
        {
            // Arrange 
            string LName = "";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLName_NameSpace_True()
        {
            //Arrange
            string LName = "Ivan ";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.Validation.ValidationLName(LName);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueLess16_return()
        {
            //Arrange
            double weight = 20;
            double height = 1.2;
            var ex = "Острый дефицит массы тела";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMI_Value17_return()
        {
            //Arrange
            double weight = 50;
            double height = 1.7;
            var ex = "Недостаточная масса тела";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height); ;
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMI_ValueNormal_return()
        {
            //Arrange
            double weight = 65;
            double height = 1.7;
            var ex = "Нормальная масса тела";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueOverweight_return()
        {
            //Arrange
            double weight = 70;
            double height = 1.6;
            var ex = "Лишний вес";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueObesity1_return()
        {
            //Arrange
            double weight = 85;
            double height = 1.6;
            var ex = "Ожирение 1-й степени";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueObesity2_return()
        {
            //Arrange
            double weight = 100;
            double height = 1.6;
            var ex = "Ожирение 2-й степени";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueObesity3_return()
        {
            //Arrange
            double weight = 120;
            double height = 1.6;
            var ex = "Ожирение 3-й степени";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueZeroWeight_return()
        {
            //Arrange
            double weight = 0;
            double height = 1.6;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueZeroHeight_return()
        {
            //Arrange
            double weight = 50;
            double height = 0;
            var ex = "Некорректные данные";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMI_ValueZero_return()
        {
            //Arrange
            double weight = 0;
            double height = 0;
            var ex = "Некорректные данные";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMI_ValueMinus_return()
        {
            //Arrange
            double weight = -5;
            double height = -5;
            var ex = "Некорректные данные";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }


        [TestMethod]
        public void CalcBMI_ValueMinusHeight_return()
        {
            //Arrange
            double weight = 0;
            double height = -5;
            var ex = "Некорректные данные";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMI_ValueMinusWeight_return()
        {
            //Arrange
            double weight = -5;
            double height = 0;
            var ex = "Некорректные данные";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMR_ValueMan_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = 70;
            double height = 170;
            int age = 21;
            var ex = "1732,2";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMR_ValueWoman_return()
        {
            //Arrange
            string name = "Женский";
            double weight = 60;
            double height = 165;
            int age = 21;
            var ex = "1429,3";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMR_ValueWomanWeight_return()
        {
            //Arrange
            string name = "Женский";
            double weight = 0;
            double height = 165;
            int age = 21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueWomanHeight_return()
        {
            //Arrange
            string name = "Женский";
            double weight = 60;
            double height = 0;
            int age = 21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueWomanAge_return()
        {
            //Arrange
            string name = "Женский";
            double weight = 60;
            double height = 160;
            int age = 0;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueWomanAgeMinus_return()
        {
            //Arrange
            string name = "Женский";
            double weight = 60;
            double height = 160;
            int age = -60;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueWomanWeightMinus_return()
        {
            //Arrange
            string name = "Женский";
            double weight = -90;
            double height = 160;
            int age = 80;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMR_ValueWomanHeightMinus_return()
        {
            //Arrange
            string name = "Женский";
            double weight = 60;
            double height = -160;
            int age = 80;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void CalcBMR_ValueManWeght_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = 0;
            double height = 170;
            int age = 21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueManHeight_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = 60;
            double height = 0;
            int age = 21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }


        [TestMethod]
        public void CalcBMR_ValueManAge_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = 70;
            double height = 170;
            int age = 0;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueManWeightMinus_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = -40;
            double height = 170;
            int age = 21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueManHeightMinus_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = 60;
            double height = -170;
            int age = 21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void CalcBMR_ValueManAgeMinus_return()
        {
            //Arrange
            string name = "Мужской";
            double weight = 90;
            double height = 170;
            int age = -21;
            var ex = "Ошибка";
            //Act
            string act = FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper.bmi.BMR(name, weight, height, age);
            //Assert
            Assert.AreEqual(ex, act);
        }


    }
}
