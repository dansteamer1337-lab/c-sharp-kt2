//namespace App.Topics.Indexers.T1_3_Matrix2D;

//public class Matrix2D
//{
//    private readonly int[] _data;

//    public int Rows { get; }
//    public int Cols { get; }

//    public Matrix2D(int rows, int cols)
//    {
//        if (rows <= 0) throw new ArgumentOutOfRangeException(nameof(rows));
//        if (cols <= 0) throw new ArgumentOutOfRangeException(nameof(cols));

//        Rows = rows;
//        Cols = cols;
//        _data = new int[rows * cols];
//    }

//    public int this[int row, int col]
//    {
//        get
//        {
//            if (row < 0 || row >= Rows) throw new ArgumentOutOfRangeException(nameof(row));
//            if (col < 0 || col >= Cols) throw new ArgumentOutOfRangeException(nameof(col));

//            return _data[row * Cols + col];
//        }
//        set
//        {
//            if (row < 0 || row >= Rows) throw new ArgumentOutOfRangeException(nameof(row));
//            if (col < 0 || col >= Cols) throw new ArgumentOutOfRangeException(nameof(col));

//            _data[row * Cols + col] = value;
//        }
//    }
//}