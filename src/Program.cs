class Program {
    static void Main(string[] args) {
        string?[] carNames = new string?[4];

        for (int i = 0; i < carNames.Length; i++) {
            Console.Write($"\tEnter Car Name {i + 1}: ");
            carNames[i] = Console.ReadLine();
        }

        Console.WriteLine("List of Cars:");
        foreach (string? carName in carNames) {
            if (!string.IsNullOrWhiteSpace(carName)) {
                Console.WriteLine(carName);
            }
        }

        Console.ReadLine();
    }
}