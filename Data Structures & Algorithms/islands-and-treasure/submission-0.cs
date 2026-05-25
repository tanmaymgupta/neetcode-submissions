public class Solution {
    private static readonly int[][] directions = new int[][] {
        new int[] {1,0}, new int[] {-1,0}, new int[] {0,1}, new int[] {0,-1}
    };
    
    public void islandsAndTreasure(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        var queue = new Queue<(int r, int c)>();

        // Step 1: enqueue all treasure chests
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 0) {
                    queue.Enqueue((r, c));
                }
            }
        }

        // Step 2: BFS from all treasures simultaneously
        while (queue.Count > 0) {
            var (r, c) = queue.Dequeue();
            foreach (var d in directions) {
                int nr = r + d[0], nc = c + d[1];
                if (nr < 0 || nc < 0 || nr >= rows || nc >= cols) continue;
                if (grid[nr][nc] == int.MaxValue) { // land not yet updated
                    grid[nr][nc] = grid[r][c] + 1;
                    queue.Enqueue((nr, nc));
                }
            }
        }
    }
}
