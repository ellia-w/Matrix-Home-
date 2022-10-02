using System;
using System.Xml.Linq;

class Matrix
{
    public double[,] data;
    public int rows;
    public int cols;

    public void Read()
    {
        //Console.WriteLine("Type an range of your matrix here: " );
        var range = (Console.ReadLine().Split(" ")); //     2 3
        rows = int.Parse(range[0]);
        cols = int.Parse(range[1]);
        string[] inputRow = new string[cols];
        data = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            //Console.Write("Type the first row of your matrix here: ");
            inputRow = Console.ReadLine().Split(" ");
            for (int j = 0; j < cols; j++)
            {
                data[i, j] = double.Parse(inputRow[j]);
            }
        }
    }

    public void Write()
    {
        int count = 0;
        foreach (var item in data)
        {
            //Console.Write($"{item} ");
            count++;
            if (count % cols == 0)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.Write($"{item} ");
            }
            //1 2 3
        }
    }
    public Matrix Multiply()
    {
        double n = double.Parse(Console.ReadLine());

        var C = new Matrix();
        C.data = new double[rows, cols];
        C.rows = rows;
        C.cols = cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C.data[i, j] = data[i, j] * n;
            }
        }
        return C;
    }
    public Matrix Multiply(double n)
    {       

        var C = new Matrix();
        C.data = new double[rows , cols];
        C.rows = rows;
        C.cols = cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C.data[i, j] = data[i, j] * n;
            }
        }
        return C;
    }
    public Matrix Sum(Matrix secondMatrix)
    {
        var C = new Matrix();
        C.data = new double[rows, cols];
        C.rows = rows;
        C.cols = cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C.data[i, j] = data[i, j] + secondMatrix.data[i, j];              //secondMatrix[i, j];
            }
        }
        return C;
        //var C = new double[rows, cols];
    }
    public Matrix matrixMult(Matrix secondMatrix)
    {
        Matrix C = new Matrix(); //[rows,secondMatrix.cols];
        C.data = new double[rows, rows];
        C.rows = rows;
        C.cols = rows;

        for (int k = 0; k < rows; k++)
        {
            for (int l = 0; l < secondMatrix.cols; l++)
            {
                for (int i = 0; i < cols; i++)
                {                    

                    C.data[k , l] += data[k , i] * secondMatrix.data[i , l]; 
                    
                }
                
            }
        }
        return C;
    }
    public Matrix Transponate()
    {
        var C = new Matrix();
        C.data = new double[cols, rows];
        C.rows = cols;
        C.cols = rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C.data[j , i] = data[i, j];
            }
        }
        return C;
    }
}
public class MainClass
{
    public static void Main()
    {
        //      (5 * A + 2 * B) * A 
        Console.WriteLine("input A");
        var A = new Matrix();
        A.Read();

        //Console.WriteLine("input B");
        //var B = new Matrix();
        //B.Read();

        //A.Sum(B);
        //A.matrixMult(B).Write();

        //(A.Multiply(5).Sum(B.Multiply(2)).matrixMult(A)).Write();
        A.Transponate().Write();

    }
}
