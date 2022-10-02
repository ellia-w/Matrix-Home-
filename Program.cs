using System;
using System.Xml.Linq;

class Matrix
{
    public double[,] data;
    public int rows;
    public int cols;

    public void Read()// creating an objoct of Matrix
    {        
        var range = (Console.ReadLine().Split(" ")); 
        rows = int.Parse(range[0]);
        cols = int.Parse(range[1]);
        string[] inputRow = new string[cols];
        data = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {            
            inputRow = Console.ReadLine().Split(" ");
            for (int j = 0; j < cols; j++)
            {
                data[i, j] = double.Parse(inputRow[j]);
            }
        }
    }

    public void Write()//   Displaying matrix in console
    {
        int count = 0;

        foreach (var item in data)
        {            
            count++;
            if (count % cols == 0)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.Write($"{item} ");
            }            
        }
    }
    public Matrix Multiply()// multiplying A matrix by a double from this method
    {
        double n = double.Parse(Console.ReadLine());
        var tempMatrix = new Matrix();
        tempMatrix.data = new double[rows, cols];
        tempMatrix.rows = rows;
        tempMatrix.cols = cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempMatrix.data[i, j] = data[i, j] * n;
            }
        }
        return tempMatrix;
    }
    public Matrix Multiply(double n)// multiplying A matrix by a double translated through this method
    {       
        var tempMatrix = new Matrix();
        tempMatrix.data = new double[rows , cols];
        tempMatrix.rows = rows;
        tempMatrix.cols = cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempMatrix.data[i, j] = data[i, j] * n;
            }
        }
        return tempMatrix;
    }
    public Matrix Sum(Matrix secondMatrix)// sum called matrix with matrix translated through this method
    {
        var tempMatrix = new Matrix();
        tempMatrix.data = new double[rows, cols];
        tempMatrix.rows = rows;
        tempMatrix.cols = cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempMatrix.data[i, j] = data[i, j] + secondMatrix.data[i, j];              
            }
        }
        return tempMatrix;        
    }
    public Matrix matrixMult(Matrix secondMatrix)// mulriply used matrix by translated matrix through this method
    {
        Matrix tempMatrix = new Matrix(); 
        tempMatrix.data = new double[rows, rows];
        tempMatrix.rows = rows;
        tempMatrix.cols = rows;

        for (int k = 0; k < rows; k++)
        {
            for (int l = 0; l < secondMatrix.cols; l++)
            {
                for (int i = 0; i < cols; i++)
                {                    

                    tempMatrix.data[k , l] += data[k , i] * secondMatrix.data[i , l]; 
                    
                }
                
            }
        }
        return tempMatrix;
    }
    public Matrix Transponate()// tranponating used matrix
    {
        var tempMatrix = new Matrix();
        tempMatrix.data = new double[cols, rows];
        tempMatrix.rows = cols;
        tempMatrix.cols = rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempMatrix.data[j , i] = data[i, j];
            }
        }
        return tempMatrix;
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
