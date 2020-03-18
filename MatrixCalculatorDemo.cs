using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixCalculatorDemo
{
  static void Main()
  {
    int SolveAMatrix()
    {
      int[] matrixWithXYZ = new int[3];
      int[,] matrixWithNumbers = new int[2, 3];
      int[,] coordsABC = new int[3, 3];
      string[] nameCoords = { "x", "y", "z" };
      string[] abc = { "A", "B", "C" };
      Console.WriteLine("Введите значения A B C:");

      int i = 0, j = 0, m = 0, n = 0;
      for (i = 0; i < 3; i++)
      {
        Console.WriteLine("{0}(x, y, z):", abc[i]);
        for (j = 0; j < 3; j++)
        {
          Console.Write("{0}: ", nameCoords[j]);
          coordsABC[i, j] = Convert.ToInt32(Console.ReadLine());
        }
      }

      Console.WriteLine("Координаты A B C");

      for (i = 0; i < 3; i++)
      {
        Console.Write("Координаты {0}: ", abc[i]);
        Console.WriteLine(coordsABC[i, 0] + " " + coordsABC[i, 1] + " " + coordsABC[i, 2]);
      }


      // Записываем в первую строчку с x y z 
      for (i = 0; i < 3; i++)
      {
        matrixWithXYZ[i] = -coordsABC[0, i];
      }

      i = 1;

      for (m = 0; m < 2; m++)
      {
        j = 0;
        for (n = 0; n < 3; n++)
        {
          matrixWithNumbers[m, n] = coordsABC[i, j] - coordsABC[0, j];
          j++;
        }
        i++;

      }


      int coefficientX = (matrixWithNumbers[0, 1] * matrixWithNumbers[1, 2]) - (matrixWithNumbers[1, 1] * matrixWithNumbers[0, 2]);
      int coefficientY;
      if ((matrixWithNumbers[0, 0] * matrixWithNumbers[1, 2]) - (matrixWithNumbers[0, 2] * matrixWithNumbers[1, 0]) == 0)
        coefficientY = 0;

      int a = matrixWithNumbers[0, 0] * matrixWithNumbers[1, 2] - (matrixWithNumbers[0, 2] * matrixWithNumbers[1, 0]);
      coefficientY = -1 * a;
      int coefficientZ = (matrixWithNumbers[0, 0] * matrixWithNumbers[1, 1]) - (matrixWithNumbers[1, 0] * matrixWithNumbers[0, 1]);

      int[] coefficientXYZ = { coefficientX, coefficientY, coefficientZ };

      while ((coefficientXYZ[0] % 2 == 0) && (coefficientXYZ[1] % 2 == 0) && (coefficientXYZ[2] % 2 == 0))
      {
        for (i = 0; i < 3; i++)
        {
          coefficientXYZ[i] /= 2;
        }
      }

      Console.Write("n(" + coefficientXYZ[0] + " " + coefficientXYZ[1] + " " + coefficientXYZ[2] + ")");

      return 0;
    }
    SolveAMatrix();
    Console.ReadKey();
  }
}
