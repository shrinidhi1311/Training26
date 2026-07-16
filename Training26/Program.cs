static void magicmatrix () {
   int rows = 3;
   int cols = 3;
   int[,] matrix1 = new int[rows, cols];
   int sum = 0;
   int sum1 = 0;
   int sum2 = 0;
   Console.WriteLine ("matrix");
   for (int i = 0; i < rows; i++) {
      for (int j = 0; j < cols; j++) {
         matrix1[i, j] = int.Parse (Console.ReadLine ());
         Console.WriteLine (matrix1[i, j] + "");
      }
   }
   for (int i = 0; i < rows; i++) {
      for (int j = 0; j < cols; j++) {
         sum += matrix1[i, j];
      }
   }
   for (int i = 0; i < cols; i++) {
      for (int j = 0; j < rows; j++) {
         sum1 += matrix1[j, i];
      }
   }
   for (int i = 0; i < rows; i++) {
      sum2 += matrix1[i, i];
   }
   if (sum == sum1 && sum == sum2) {
      Console.WriteLine ("True");
   } else {
      Console.WriteLine ("False");
   }
}