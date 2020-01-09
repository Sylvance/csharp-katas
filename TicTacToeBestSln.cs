using System;

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    if (board[0, 0].Equals(board[0, 1]) && board[0, 1].Equals(board[0, 2]) && !board[0, 0].Equals(0)) return board[0, 0];
    
    if (board[1, 0].Equals(board[1, 1]) && board[1, 1].Equals(board[1, 2]) && !board[1, 0].Equals(0)) return board[1, 0];
    
    if (board[2, 0].Equals(board[2, 1]) && board[2, 1].Equals(board[2, 2]) && !board[2, 0].Equals(0)) return board[2, 0];
    
    if (board[0, 0].Equals(board[1, 0]) && board[1, 0].Equals(board[2, 0]) && !board[0, 0].Equals(0)) return board[0, 0];
    
    if (board[0, 1].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 1]) && !board[0, 1].Equals(0)) return board[0, 1];
    
    if (board[0, 2].Equals(board[1, 2]) && board[1, 2].Equals(board[2, 2]) && !board[0, 2].Equals(0)) return board[0, 2];
    
    if (board[0, 0].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 2]) && !board[0, 0].Equals(0)) return board[0, 0];
    
    if (board[0, 2].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 0]) && !board[0, 2].Equals(0)) return board[0, 2];          
    
    foreach(var e in board)
    {
        if(e.Equals(0)) return -1;
    }
    
    return 0;
  }
}
