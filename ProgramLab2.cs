using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) < Math.Pow(10,-3))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        double Y = 0;
        if (x >= 0)
        {
            Y = 1 - x;
        }
        else
        {
            Y = 1 + x;
        }
        if (Y >= 0 && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            answer = b;
            if (a > b)
            {
                answer = a;
            }
        }
        if (a <= 0)
        {
            answer = b;
            if (a < b)
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double minimum = a;
        if (a > b)
        {
            minimum = b;
        }
        answer = minimum;
        if (minimum < c)
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2 * Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        double flag = d / Math.Sqrt(2);
        if (a <= flag)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2 * Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        if (d <= a)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1)
            answer = x * x - 1;
        else answer = 0;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (-1 < x && x <= 0)
            answer = 1 + x;
        if (x > 0)
            answer = 1;        
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (-1 < x && x <= 1)
            answer = x * (-1);
        if (x > 1)
            answer = - 1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double height;
        double total_height = 0;
        for (int i = 0; i < n; i++)
        {
            height = double.Parse(Console.ReadLine());
            total_height += height;
        }
        answer = Math.Round(total_height / n, 2);
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (Math.Abs(x - a) < r && Math.Abs(y - b) < r) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;
        double total = 0;
        for (int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30) total += 200;
        }
        answer = total / 1000;
        Console.WriteLine(answer);


        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < Math.Pow(r2,2))
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) > Math.Pow(r1,2))
                    answer += 1;
        }
        Console.WriteLine(answer);       
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if (result <= norm) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((0 <= y && y <= Math.Sin(x)) && (0 <= x && x <= Math.PI)) answer ++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i ++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 += 1;
                Console.WriteLine("I");
            }
            if (x < 0 && y > 0) Console.WriteLine("II");
            if (x < 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine("III");
            }
            if (x > 0 && y < 0) Console.WriteLine("IV");
        }
        Console.WriteLine($"I: {answer1}, III: {answer3}");  
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double l = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (l < answerLength) 
            {
                answerLength = l;
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"Номер точки: {answer}, длина: {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if (result < answer) answer = result;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int mark;
        bool flag = true;

        for (int i = 0; i < n; i++)
        {
            mark = int.Parse(Console.ReadLine());
            if (mark <= 3) flag = false;
            if (i % 4 == 0)
            {
                if (flag) answer += 1;
                flag = true;
            }
        }
        Console.WriteLine($"Ответ: {answer}");
        
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int mark;
        bool flag = true;
        for (int i = 0; i < n; i++)
        {
            mark = int.Parse(Console.ReadLine());
            avg += mark;
            if (mark == 2) flag = false;
            if (i % 4 == 0)
            {
                if (!flag) answer += 1;
                flag = true;
            }
        }
        avg = avg / (4 * n);
        Console.WriteLine($"Средняя оценка: {avg}, Количество сдавших: {answer}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;

        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = 0.5 * r * r * Math.Sin(Math.PI / 3); break;            
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A <= 0) || (B <= 0)) return 0;
        
        switch (type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2:
                double P = (A + 2 * B) * 0.5;
                answer = Math.Pow(P * (P - A) * (P - B) * (P - B), 0.5);
                break;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        bool input_flag = true;
        double total = 0;
        double weight = 0;

        do
        {
            input_flag = double.TryParse(Console.ReadLine(), out weight);
            if (input_flag)
            {
                total += weight;
                n += 1;
                answer = Math.Round(total / n, 2);
            }

        } while (input_flag);
        Console.WriteLine(answer);
        
        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        bool input_flag;
        double x = 0, y = 0;
        do
        {
            input_flag = double.TryParse(Console.ReadLine(), out x);
            if (!input_flag) break;
            input_flag = double.TryParse(Console.ReadLine(), out y);


            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < Math.Pow(r2,2))
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) > Math.Pow(r1,2))
                    answer += 1;
        } while(true);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        bool input_flag;
        double x, y;
        do
        {
            input_flag = double.TryParse(Console.ReadLine(), out x);
            if (!input_flag) break;
            input_flag = double.TryParse(Console.ReadLine(), out y);

            if (x > 0 && y > 0)
            {
                answer1 += 1;
                Console.WriteLine("I");
            }
            if (x < 0 && y > 0) Console.WriteLine("II");
            if (x < 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine("III");
            }
            if (x > 0 && y < 0) Console.WriteLine("IV");
            
        } while(true);
        Console.WriteLine($"I: {answer1}, III: {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}