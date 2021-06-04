using System;
using System.Collections.Generic;
using System.Text;

namespace _7_lab
{
   class RationalNumber : IComparable<RationalNumber>
    {
        public int CompareTo(RationalNumber buffer)
        {
            if (buffer > this)
            {
                return 1;
            }
            else
                if (buffer < this)
                {
                    return -1;
                }
                 else
                    if (buffer == this)
                    {
                        return 0;
                    }

            return 0;
        }

      
        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            int num_of_numb1 = num1.Numerator * num2.Denominator;
            int num_of_numb2 = num2.Numerator * num1.Denominator;
            return num_of_numb1 < num_of_numb2;
        }

        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            int num_of_numb1 = num1.Numerator * num2.Denominator;
            int num_of_numb2 = num2.Numerator * num1.Denominator;
            return num_of_numb1 > num_of_numb2;
        }
        public static bool operator !=(RationalNumber num1, RationalNumber num2)
        {
            int num_of_numb1 = num1.Numerator * num2.Denominator;
            int num_of_numb2 = num2.Numerator * num1.Denominator;
            return num_of_numb1 != num_of_numb2;
        }
        public static bool operator ==(RationalNumber num1, RationalNumber num2)
        {
            int num_of_numb1 = num1.Numerator * num2.Denominator;
            int num_of_numb2 = num2.Numerator * num1.Denominator;
            return num_of_numb1 == num_of_numb2;
        }

        public static void StrC(string[] str, List<RationalNumber> numbers)
        {
            char buf;
            StringBuilder buf2 = new StringBuilder();
            StringBuilder buf1 = new StringBuilder();
            foreach (string c in str)
            {
                if (c.Contains("."))
                {
                    for (int i = 0; i < c.Length; i++)
                    {
                        buf = c[i];
                        if (buf == '.')
                        {
                            numbers.Add(new RationalNumber
                            {
                                Denominator = Convert.ToInt32(Math.Pow(10, c.Length - i - 1)),
                                Numerator = Convert.ToInt32(Convert.ToDouble(c) * Convert.ToDouble(Math.Pow(10, c.Length - i - 1))),
                            });
                            break;
                        }
                        else
                        {
                            buf1.Append(c[i]);
                        }
                    }
                }

                if (c.Contains("/"))
                {
                    for (int i = 0; i < c.Length; i++)
                    {
                        buf = c[i];
                        if (buf == '/')
                        {
                            for (int j = i + 1; j < c.Length; j++)
                            {
                                buf1.Append(c[j]);
                            }

                            numbers.Add(new RationalNumber
                            {
                                Denominator = Convert.ToInt32(buf1.ToString()),
                                Numerator = Convert.ToInt32(buf2.ToString()),
                            });
                            break;
                        }
                        else
                        {
                            buf2.Append(c[i]);
                        }
                    }
                }
            }
        }

        public RationalNumber()
        {
            this.Numerator = 0;
            this.Denominator = 0;
        }

        public RationalNumber(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }

        //numerators
        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            int num_of_numb;
            int denum_of_numb;
            num_of_numb = (num1.Numerator * num2.Denominator) + (num2.Numerator * num1.Denominator);
            denum_of_numb = num1.Denominator * num2.Denominator;
            return new RationalNumber { Numerator = num_of_numb, Denominator = denum_of_numb };
        }

        //num + int
        public static RationalNumber operator +(RationalNumber num1, int val)
        {
            return new RationalNumber { Numerator = num1.Numerator + (val * num1.Denominator), Denominator = num1.Denominator };
        }

        // num - num
        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int num_of_numb;
            int denum_of_numb;
            num_of_numb = (num1.Numerator * num2.Denominator) - (num2.Numerator * num1.Denominator);
            denum_of_numb = num1.Denominator * num2.Denominator;
            return new RationalNumber { Numerator = num_of_numb, Denominator = denum_of_numb };
        }

        //num*num
        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            return new RationalNumber { Numerator = num1.Numerator * num2.Numerator, Denominator = num1.Denominator * num2.Denominator };
        }

        //num/num
        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {
            return new RationalNumber { Numerator = num1.Numerator * num2.Denominator, Denominator = num1.Denominator * num2.Numerator };
        }

        public int Numerator { get; set; }

        public int Denominator { get; set; }

        public static void Frac(RationalNumber num1)
        {
         
            int Cnt = 2;
            int min = 0;
            if (Math.Abs(num1.Numerator) > Math.Abs(num1.Denominator))
            {
                min = Math.Abs(num1.Denominator);
            }
            else
            {
                min = Math.Abs(num1.Numerator);
            }   
            
            while (Cnt <= min)
            {
                if ((num1.Denominator % Cnt == 0) & (num1.Numerator % Cnt == 0))
                {
                    num1.Denominator /= Cnt;
                    num1.Numerator /= Cnt;
                    Cnt = 1;
                }

                Cnt++;
            }
        }

        public override string ToString()
        {
            return (Convert.ToDouble(this.Numerator) / Convert.ToDouble(this.Denominator)).ToString();
        }

        public string ToString(string format)
        {
            if (format == "dec")
            {
                return (Convert.ToDouble(this.Numerator) / Convert.ToDouble(this.Denominator)).ToString();
            }
            else if (format == "frac")
            {
                return this.Numerator.ToString() + "\n-\n" + this.Denominator.ToString();
            }

            return string.Empty;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            RationalNumber p = (RationalNumber)obj;
            int cheсk = this.CompareTo(p);
            if (cheсk == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static explicit operator RationalNumber(string c)
        {
            char buf;
            StringBuilder buf1 = new StringBuilder();
            StringBuilder buf2 = new StringBuilder();
            if (c.Contains("/"))
            {
                for (int i = 0; i < c.Length; i++)
                {
                    buf = c[i];
                    if (buf == '/')
                    {
                        for (int j = i + 1; j < c.Length; j++)
                        {
                            buf1.Append(c[j]);
                        }

                        return new RationalNumber
                        {
                            Denominator = Convert.ToInt32(buf1.ToString()),
                            Numerator = Convert.ToInt32(buf2.ToString()),
                        };
                    }
                    else
                    {
                        buf2.Append(c[i]);
                    }
                }
            }

            if (c.Contains("."))
            {
                for (int i = 0; i < c.Length; i++)
                {
                    buf = c[i];
                    if (buf == '.')
                    {
                        return new RationalNumber
                        {
                            Denominator = Convert.ToInt32(Math.Pow(10, c.Length - i - 1)),
                            Numerator = Convert.ToInt32(Convert.ToDouble(c) * Convert.ToDouble(Math.Pow(10, c.Length - i - 1))),
                        };
                    }
                    else
                    {
                        buf1.Append(c[i]);
                    }
                }
            }

            return null;
        }

        public static implicit operator int(RationalNumber rationalNumber)
        {
            string str = rationalNumber.ToString("dec");
            return Convert.ToInt32(Convert.ToDouble(str));
        }

        public static explicit operator double(RationalNumber rationalNumber)
        {
            string str = rationalNumber.ToString("dec");
            return Convert.ToDouble(str);
        }

        public static void Type(RationalNumber num1, string format)
        {
            if (format == "dec")
            {
                Console.WriteLine(Convert.ToDouble(num1.Numerator) / Convert.ToDouble(num1.Denominator));
            }
            else if (format == "frac")
            {
                Console.WriteLine(num1.Numerator + "\n-\n" + num1.Denominator);
            }
        }

    }
}
