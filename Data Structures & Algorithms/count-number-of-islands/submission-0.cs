public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int columns = grid[0].Length;
        int count = 0;
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        for(int r = 0; r < rows; r++)
        {
            for (int c=0; c < columns; c++)
            {
                if(grid[r][c] == '1' && !visited.Contains((r,c)))
                {
                    count++;
                    DFS(grid, r, c, rows, columns, visited);
                }
            }
        }
        return count;
    }

    public void DFS(char[][] grid, int r, int c, int rows, int columns, HashSet<(int, int)> visited)
    {
        if(r<0 || c<0 || r>=rows || c>=columns || grid[r][c] == '0' || visited.Contains((r,c)))
            return;
        
        visited.Add((r,c));

        DFS(grid, r+1, c, rows, columns, visited);
        DFS(grid, r-1, c, rows, columns, visited);
        DFS(grid, r, c+1, rows, columns, visited);
        DFS(grid, r, c-1, rows, columns, visited);
    }
}


