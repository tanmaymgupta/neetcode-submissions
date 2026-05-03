
/*
  0  1  2  3  4  5  6  7  8
0 0  0  0  1  1  1  2  2  2
1 0  0  0  1  1  1  2  2  2 
2 0  0  0  1  1  1  2  2  2
3 3  3  3  4  4  4  5  5  5
4 3  3  3  4  4  4  5  5  5
5 3  3  3  4  4  4  5  5  5
6 6  6  6  7  7  7  8  8  8
7 6  6  6  7  7  7  8  8  8
8 6  6  6  7  7  7  8  8  8

0 = 0,0 to 2,2
1 = 0,3 to 2,5
2 = 0,6 to 2,8
3 = 3,0 to 5,2
*/



public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> row_states = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> column_states = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> square_states = new Dictionary<int, HashSet<char>>();
        for(int i=0; i<9; i++)
        {
            if(!row_states.ContainsKey(i))
            {
                row_states[i] = new HashSet<char>();
            }
            for (int j=0; j<9; j++)
            {
                int sqr = (i/3)*3+(j/3);
                char search_char = board[i][j];
                if(HasDuplicate(row_states, i, search_char) || HasDuplicate(column_states, j, search_char)|| HasDuplicate(square_states, sqr, search_char))
                {
                    return false;
                }
            }
        }
        return true;
    }

    public bool HasDuplicate(Dictionary<int, HashSet<char>> dictionary, int index, char searchChar)
    {
        if(searchChar=='.')
        {
            return false;
        }
        
        if(!dictionary.ContainsKey(index))
        {
            dictionary[index] = new HashSet<char>();
        }

        if(dictionary[index].Contains(searchChar))
        {
            return true;
        }
        
        dictionary[index].Add(searchChar);
        return false;
    }
}
