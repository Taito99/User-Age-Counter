using System;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;

namespace CountingYearsOnThisPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            Error1:
            try
            {
                int year;
                int month;
                int day;
                DateTime yearOfBirth;
                DateTime currentTime;
                TimeSpan userAge;
                int exaclyAge;
                string zodiacSign = "";

                Console.WriteLine("Type in what year have you been born: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type in what month have you been born: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type in what day have you been born: ");
                day = Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1:
                        if (day <= 19)
                        {
                            zodiacSign = "Capricorn";
                        } else if (day > 19)
                        {
                            zodiacSign = "Aquarius";
                        }
                        break;
                    case 2:
                        if (day <= 18)
                        {
                            zodiacSign = "Aquarius";
                        } else if (day > 18)
                        {
                            zodiacSign = "Pisces";
                        }
                        break;
                    case 3:
                        if (day <= 21)
                        {
                            zodiacSign = "Pisces";
                        } else if (day >= 21)
                        {
                            zodiacSign = "Aries";
                        }
                        break;
                    case 4:
                        if (day <= 20)
                        {
                            zodiacSign = "Aries";
                        } else if (day > 20)
                        {
                            zodiacSign = "Taurus";
                        }
                        break;
                    case 5:
                        if (day <= 21)
                        {
                            zodiacSign = "Taurus";
                        }
                        else if (day > 20)
                        {
                            zodiacSign = "Gemini";
                        }
                        break;
                    case 6:
                        if (day < 20)
                        {
                            zodiacSign = "Gemini";
                        } else if (day > 20)
                        {
                            zodiacSign = "Cancer";
                        }
                        break;
                    case 7:
                        if (day <= 22)
                        {
                            zodiacSign = "Cancer";
                        } else if (day > 22)
                        {
                            zodiacSign = "Leo";
                        }
                        break;
                    case 8:
                        if (day <= 23)
                        {
                            zodiacSign = "Leo";
                        } else if (day > 23)
                        {
                            zodiacSign = "Virgo";
                        }
                        break;
                    case 9:
                        if (day <= 22)
                        {
                            zodiacSign = "Virgo";
                        } else if (day > 22)
                        {
                            zodiacSign = "Libra";
                        }
                        break;
                    case 10:
                        if (day <= 23)
                        {
                            zodiacSign = "Libra";
                        } else if (day > 23)
                        {
                            zodiacSign = "Scorpio";
                        }
                        break;
                    case 11:
                        if (day <= 21)
                        {
                            zodiacSign = "Scorpio";
                        } else if (day > 21)
                        {
                            zodiacSign = "Sagittarius";
                        }
                        break;
                    case 12:
                        if (day <= 21)
                        {
                            zodiacSign = "Sagittarius";
                        }else if (day > 21)
                        {
                            zodiacSign = "Capricorn";
                            
                        }
                        break;
                }

                yearOfBirth = new DateTime(year, month, day);
                currentTime = DateTime.Now;
                userAge = currentTime - yearOfBirth;
                exaclyAge = userAge.Days / 365;

                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"You are {exaclyAge} years old and your zodiac sign is: {zodiacSign} and your year was leep");
                }
                else
                {
                    Console.WriteLine($"You are {exaclyAge} years old and your zodiac sign is: {zodiacSign}");
                }
                }
            catch (Exception)
            {
                Console.WriteLine("Type in numbers that are equal to calendar");
                goto Error1;
            }


        }
    }
}
