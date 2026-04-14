public class Solution {
    public bool IsValidSudoku(char[][] board) {

        // 🔹 1. Check each row
        for(int row = 0; row < 9; row++){
            HashSet<char> seen = new HashSet<char>(); // stores digits seen in current row

            for(int col = 0; col < 9; col++){
                if(board[row][col] == '.') continue; // skip empty cells

                // if duplicate found → invalid Sudoku
                if(seen.Contains(board[row][col])) return false;

                seen.Add(board[row][col]);
            }
        }

        // 🔹 2. Check each column
        for(int col = 0; col < 9; col++){
            HashSet<char> seen = new HashSet<char>(); // stores digits seen in current column

            for(int row = 0; row < 9; row++){
                if(board[row][col] == '.') continue;

                if(seen.Contains(board[row][col])) return false;

                seen.Add(board[row][col]);
            }
        }

        // 🔹 3. Check each 3×3 sub-box
        for(int square = 0; square < 9; square++){
            HashSet<char> seen = new HashSet<char>(); // stores digits in current 3x3 box

            // iterate inside 3×3 box
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){

                    // 🔸 Convert square index → actual board indices
                    int row = (square / 3) * 3 + i; // box row + offset
                    int col = (square % 3) * 3 + j; // box col + offset

                    if(board[row][col] == '.') continue;

                    if(seen.Contains(board[row][col])) return false;

                    seen.Add(board[row][col]);
                }
            }
        }

        // if all checks passed → valid Sudoku
        return true;
    }
}