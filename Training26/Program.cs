using System;

class Program {
   static void Main () {
      Console.Write ("Enter the order of the matrix: ");
      int n = int.Parse (Console.ReadLine ());

      int[,] matrix = new int[n, n];

      Console.WriteLine ("Enter the matrix elements:");

      for (int i = 0; i < n; i++) {
         for (int j = 0; j < n; j++) {
            matrix[i, j] = int.Parse (Console.ReadLine ());
         }
      }

      int magicSum = 0;

      for (int j = 0; j < n; j++)
         magicSum += matrix[0, j];

      bool isMagic = true;


      for (int i = 0; i < n; i++) {
         int rowSum = 0;
         for (int j = 0; j < n; j++)
            rowSum += matrix[i, j];

         if (rowSum != magicSum) {
            isMagic = false;
            break;
         }
      }


      if (isMagic) {
         for (int j = 0; j < n; j++) {
            int colSum = 0;
            for (int i = 0; i < n; i++)
               colSum += matrix[i, j];

            if (colSum != magicSum) {
               isMagic = false;
               break;
            }
         }
      }


      if (isMagic) {
         int diag1 = 0;
         for (int i = 0; i < n; i++)
            diag1 += matrix[i, i];

         if (diag1 != magicSum)
            isMagic = false;
      }

      if (isMagic) {
         int diag2 = 0;
         for (int i = 0; i < n; i++)
            diag2 += matrix[i, n - 1 - i];

         if (diag2 != magicSum)
            isMagic = false;
      }

      if (isMagic)
         Console.WriteLine ("Magic Matrix");
      else
         Console.WriteLine ("Not a Magic Matrix");
   }
}