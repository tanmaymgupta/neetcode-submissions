public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int rows = grid.Length;
        int columns = grid[0].Length;
        int max_area = 0;
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        for(int r = 0; r < rows; r++)
        {
            for (int c=0; c < columns; c++)
            {
                if(grid[r][c] == 1 && !visited.Contains((r,c)))
                {
                    max_area = Math.Max(DFS(grid, r, c, rows, columns, visited), max_area);
                }
            }
        }
        return max_area;
    }

    public int DFS(int[][] grid, int r, int c, int rows, int columns, HashSet<(int, int)> visited)
    {
        if(r<0 || c<0 || r>=rows || c>=columns || grid[r][c] == 0 || visited.Contains((r,c)))
            return 0;
        
        visited.Add((r,c));

        int area=1;
        
        area += DFS(grid, r+1, c, rows, columns, visited);
        area += DFS(grid, r-1, c, rows, columns, visited);
        area += DFS(grid, r, c+1, rows, columns, visited);
        area += DFS(grid, r, c-1, rows, columns, visited);

        return area;
    }
}
