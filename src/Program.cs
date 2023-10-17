using System;

class Class3 {
    static void Main(string[] args) {
        string?[] cars = new string?[4];

        for (int i = 0; i < cars.Length; i++) {
            Console.Write($"\tElement[{i}]: ");
            cars[i] = Console.ReadLine();
        }

        Console.WriteLine("List of cars:");
        foreach (string? car in cars) {
            if (!string.IsNullOrWhiteSpace(car)) {
                Console.WriteLine(car);
            }
        }

        Console.ReadLine();
    }
}
