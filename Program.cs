Console.WriteLine("--- Rolagem de Dado ---\n");

Console.Write("Quantas faces? ");
    int faces = int.Parse(Console.ReadLine());

    if (faces < 4) {
      Console.WriteLine("Não é possível simular um dado com menos de 4 faces.");
    } else {
      Random random = new Random();
      int resultado = random.Next(1, faces+1);
      Console.WriteLine("\n--- Rolagem de Dado ---\n");
      Console.WriteLine("Rolagem: " + resultado);
    }