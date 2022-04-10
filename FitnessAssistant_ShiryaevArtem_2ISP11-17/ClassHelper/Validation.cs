using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_ShiryaevArtem_2ISP11_17.ClassHelper
{
    public class Validation
    {
        
        
            public static bool ValidationPassword(string Password)
            {


                if (Password.Length < 8 || Password.Length > 20)
                {
                    return false;
                }
                if (!Password.Any(char.IsDigit))
                {
                    return false;
                }

                if (!Password.Any(char.IsPunctuation))
                {
                    return false;
                }
                if (!Password.Any(char.IsLower))
                {
                    return false;
                }
                if (!Password.Any(char.IsUpper))
                {
                    return false;
                }
                if (string.IsNullOrWhiteSpace(Password))
                {
                    return false;
                }

                return true;

            }
            public static bool ValidationName(string Name)
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return false;
                }

                if (!Name.Any(char.IsUpper))
                {
                    return false;

                }
                if (!Name.Any(char.IsLower))
                {
                    return false;
                }
                if (Name.Any(char.IsDigit))
                {
                    return false;
                }
                if (Name.Any(char.IsPunctuation))
                {
                    return false;
                }
                if (Name.Length < 4 || Name.Length > 30)
                {
                    return false;
                }
                if (Name.Contains(" "))
                {
                    return false;
                }

                return true;
            }
            public static bool ValidationDateBirthday(DateTime Value)
            {
                DateTime datas = DateTime.Now;
                DateTime dataPast = new DateTime(1930, 01, 01);

                Value = Value.Date;
                if (Value >= datas)
                {
                    return false;
                }

                if (Value < dataPast)
                {
                    return false;
                }
                return true;
            }
            public static bool ValidationLName(string LName)
            {
                if (string.IsNullOrWhiteSpace(LName))
                {
                    return false;
                }
                if (!LName.Any(char.IsUpper))
                {
                    return false;

                }
                if (!LName.Any(char.IsLower))
                {
                    return false;
                }
                if (LName.Any(char.IsDigit))
                {
                    return false;
                }
                if (LName.Length < 4 || LName.Length > 20)
                {
                    return false;
                }
                if (LName.Contains("-"))
                {
                    return true;
                }


                return true;
            }

        }
    }
