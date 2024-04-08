using System;
using System.Linq.Expressions;
using System.Runtime.Serialization.Json;

public class BubbleSortExample
{

    public static void Main(string[] args)
    {
        Console.WriteLine("test");

        //Number1
       // ReadFile("\"C:\\Users\\karlchristian.canlas\\Desktop\\sample.txt\"");
        Console.WriteLine("Input File Location");
        string fileLocation = Console.ReadLine();
        ReadFile(fileLocation);

        //Number2
        Console.WriteLine("Input Number");
        int inputNum = Int32.Parse(Console.ReadLine());
        CheckInputNumericInteger(inputNum);


        //number 3
        Console.WriteLine("Input Array Separated by comma");
        string input = Console.ReadLine();
        double averageVal = CalculateArrayIntAverageValue(input);

        //number 4
        Console.WriteLine("Input Integer to be converted");
        string stringInInput = Console.ReadLine();
        int convertedInt = ConvertStringToInt(stringInInput);


        //number 5


        //number6
        Console.WriteLine("Input Integer to be converted");
        string numerator = Console.ReadLine();
        string denominator = Console.ReadLine();
        double quotient = Divide2Numbers(numerator, denominator);


        //number 7
        Console.WriteLine("Input Date to be converted");
        string dateString = Console.ReadLine();
        DateTime convertedDate = ConvertStringToDate(dateString);

        //number 8
        Console.WriteLine("Input Number to calculate squareRoot");
        string strSquareRootInput = Console.ReadLine();
        double squareRoot = CheckSquareRoot(strSquareRootInput);

        //number9
        Console.WriteLine("Input string to be uppercased");
        string lowerCaseInput = Console.ReadLine();
        string upperCases = ConvertToUpperCase(lowerCaseInput);

        //number10
        Console.WriteLine("Input number for Factorial");
        string inputFactorial = Console.ReadLine();
        int factorial = CalculateFactorial(inputFactorial);
    }

    public static void ReadFile(string filePath)
    {
        try
        {
            //check if filepath is null or empty
            if (filePath == null || filePath == string.Empty)
            {
                return;
            }

            if (!System.IO.File.Exists(filePath))
            {
                return;
            }

            using (System.IO.StreamReader reader = System.IO.File.OpenText(filePath))
            {
                string fileContenst = reader.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }


    public static void CheckInputNumericInteger(int input)
    {
        try
        {
            if (input < 0 || input > 1000)
            {
                throw new Exception();
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public static double CalculateArrayIntAverageValue(string strInput)
    {
        try
        {
            if (strInput == null || strInput.Length == 0) { throw new Exception(); }

            string[] arrStrInput = strInput.Split(',');
            List<int> lstInt = new List<int>();
            foreach (string str in arrStrInput)
            {
                lstInt.Add(Int32.Parse(str));
            }

            double average = lstInt.Average(s => s);
            return average;

        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public static double ConvertToInt32(string strInput)
    {
        try
        {
            if (strInput == null || strInput.Length == 0) { throw new Exception(); }

            string[] arrStrInput = strInput.Split(',');
            List<int> lstInt = new List<int>();
            foreach (string str in arrStrInput)
            {
                lstInt.Add(Int32.Parse(str));
            }

            double average = lstInt.Average(s => s);
            return average;

        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public static int ConvertStringToInt(string input)
    {
        try
        {
            if (input == null || input.Length == 0) { throw new Exception(); }

            return Int32.Parse(input);

        }
        catch (Exception ex)
        {
            //covers the exception thrown from int32.parse
            throw;
        }
    }


    public static double Divide2Numbers(string numerator, string denumenator)
    {
        try
        {
            int intNumerator = Int32.Parse(numerator);
            int intDenumenator = Int32.Parse(denumenator);

            //if (denumenator == 0) { return; }

            return intNumerator / intDenumenator;

        }
        catch (Exception ex)
        {
            //covers the exception thrown from int32.parse
            throw;
        }
    }

    public static DateTime ConvertStringToDate(string dateString)
    {
        try
        {
            DateTime dt;
            DateTime.TryParse(dateString, out dt);

            return dt;

        }
        catch (Exception ex)
        {
            //covers the exception thrown from int32.parse
            throw;
        }
    }

    public static double CheckSquareRoot(string strInput)
    {
        try
        {
            //if(input < 1)
            //{
            //    return;
            //}

            int intput = Int32.Parse(strInput);

            return Math.Sqrt(intput);
        }
        catch (Exception ex)
        {
            throw;
        }
    }


    public static string ConvertToUpperCase(string strInput)
    {
        try
        {

            if (!(strInput == null) && !(strInput.Length == 0))
            {
                return strInput.ToUpper();
            }
            else
            {
                throw new NullReferenceException();
            }

        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public static int CalculateFactorial(string strInput)
    {
        try
        {

            int factNum = Int32.Parse(strInput);

            int factorialOutput = Factorial(factNum);

            return factorialOutput;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private static int Factorial(int factor)
    {
        if (factor == 0)
        {
            return 1;
        }

        return factor * Factorial(factor - 1);
    }


}