namespace StructuredProgrammingPuzzles
{
    internal class GameOfLife
    {
        static readonly int Width = Console.WindowWidth - 1;
        static readonly int Height = Console.WindowHeight - 1;
        public static void Run()
        {
            var cellCount = Width * Height;
            var random = new Random();
            var cells = Enumerable.Range(0, cellCount)
                .Select(n => random.Next(2) == 1)
                .ToArray();

            while (true)
            {
                Draw(cells);
                cells = Grow(cells);
                Thread.Sleep(100);
            }
        }

        private static bool[] Grow(bool[] cells)
        {
            var newCells = new bool[cells.Length];
            for (var i = 0; i < newCells.Length; i++)
            {
                var aliveNeighborsCount = CountAliveNeighbors(cells, i);
                var currentCellIsAlive = cells[i];
                newCells[i] = currentCellIsAlive
                    ? aliveNeighborsCount is 2 or 3
                    : aliveNeighborsCount == 3;
            }
            return newCells;
        }

        private static int CountAliveNeighbors(bool[] cells, int index)
        {
            return CountAliveNeighbor(index, -1, -1, cells)
                   + CountAliveNeighbor(index, -1, 0, cells)
                   + CountAliveNeighbor(index, -1, 1, cells)
                   + CountAliveNeighbor(index, 0, -1, cells)
                   + CountAliveNeighbor(index, 0, 1, cells)
                   + CountAliveNeighbor(index, 1, -1, cells)
                   + CountAliveNeighbor(index, 1, 0, cells)
                   + CountAliveNeighbor(index, 1, 1, cells);
        }

        private static int CountAliveNeighbor(int baseIndex, int deltaRow, int deltaCol, bool[] cells)
        {
            var row = baseIndex / Width;
            var col = baseIndex % Width;
            var lastRow = Height-1;
            var lastCol = Width - 1;
            if (row == 0 && deltaRow == -1
                || row == lastRow && deltaRow == 1
                || col == 0 && deltaCol == -1
                || col == lastCol && deltaCol == 1) return 0;
            var cellIndex = baseIndex + deltaCol + deltaRow*Width;
            return cells[cellIndex] ? 1 : 0;
        }

        private static void Draw(bool[] cells)
        {
            var text = cells.Select(isAlive => isAlive ? '*' : ' ').ToArray();
            Console.Clear();
            Console.Write(text);
        }
    }
}
