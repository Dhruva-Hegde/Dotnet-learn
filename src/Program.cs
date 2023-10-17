using System;

class Class3 {
    static void Main(string[] args) {
        string?[] cars = new string?[4]; // Use 'string?' to allow null

        for (int i = 0; i < cars.Length; i++) {
            Console.Write("\tElement[" + i + "]: ");
            string? input = Console.ReadLine(); // Read a nullable string
            cars[i] = input; // Assign the potentially nullable input to the array
        }

        Console.WriteLine("List of cars:");
        foreach (string? car in cars) {
            if (!string.IsNullOrEmpty(car)) {
                Console.WriteLine(car); // Print the car name if it's not null or empty
            }
        }

        Console.ReadLine();
    }
}
