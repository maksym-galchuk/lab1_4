namespace Мatrix; 

public class Matrix {
    private int[,] data;
    
    public Matrix(int rows, int cols) {
        if (rows <= 0 || cols <= 0) {
            throw new ArgumentException("Rows and cols must be positive.");
        }
        data = new int[rows, cols];
    }

    public int Rows {get => data.GetLength(0);}
    public int Cols {get => data.GetLength(1);}
    
    public int this[int row, int col] {
        get {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols) {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            return data[row, col];
        }
        set {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols) {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            data[row, col] = value;
        }
    }
}