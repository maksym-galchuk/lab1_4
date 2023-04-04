using Мatrix;



while (true) {
    Console.Write("\nEnter the dimensions of the matrix 'rows cols', or 'stop' to exit: ");
    string? input = Console.ReadLine();
    
    if (input == "stop") {break;}
    if (input == null || input.Split(' ').Length != 2) {
        Console.WriteLine("Invalid format.");
        continue;
    }
    
    int nRows = int.Parse(input.Split(' ')[0]);
    int nCols = int.Parse(input.Split(' ')[1]);
    Matrix m = new Matrix(nRows, nCols);

    while (true) {
        Console.WriteLine("Enter 'w' to write or 'r' to read, or any other key to exit.");
        char c = Console.ReadKey().KeyChar;
        if (c == 'w') {
            Console.WriteLine("\nEnter the elements of the matrix in format 'row col value', or 'stop' to stop.");
            while (true) {
                input = Console.ReadLine();
                if (input == "stop") {break;}
                if (input == null || input.Split(' ').Length != 3) {
                    Console.WriteLine("Invalid format.");
                    continue;
                }
                
                try {
                    int row = int.Parse(input.Split(' ')[0]);
                    int col = int.Parse(input.Split(' ')[1]);
                    int value = int.Parse(input.Split(' ')[2]);
                    m[row, col] = value;
                } catch (IndexOutOfRangeException) {
                    Console.WriteLine("Index out of range.");
                } catch (FormatException) {
                    Console.WriteLine("Invalid format.");
                }
            }
        } else if (c == 'r') {
            Console.WriteLine("\nEnter the elements of the matrix in format 'row col', or 'stop' to stop.");
            while (true) {
                input = Console.ReadLine();
                if (input == "stop") {break;}
                if (input == null || input.Split(' ').Length != 2) {
                    Console.WriteLine("Invalid format.");
                    continue;
                }
                
                try {
                    int row = int.Parse(input.Split(' ')[0]);
                    int col = int.Parse(input.Split(' ')[1]);
                    Console.WriteLine(m[row, col]);
                } catch (IndexOutOfRangeException) {
                    Console.WriteLine("Index out of range.");
                } catch (FormatException) {
                    Console.WriteLine("Invalid format.");
                }
            }
        } else {
            break;
        }
    }

}
