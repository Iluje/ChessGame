using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Rook", menuName = "Piece/Rook", order = 1)] 
    public class Rook : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();

            int X = position.x;
            int Y = position.y;
            
            Debug.Log(X);
            Debug.Log(Y);

            while (X >= 0 && X < 8 && Y >= 0 && Y < 8 && PieceHandler.Instance._piece == null)
            {
                int Xint;
                
                // moves.Add(new Vector2Int(+Xint,Y) + position);
            }
            
            return moves;
        }
    }
}

// int[] PositionX = { 1,-1,1,-1 };
// int[] PositionY = { 1,1,-1,-1 };

// for (int i = 0; i < 4; i++)
// {
//     int x = position.x + position[i];
//     int y = position.y + position[i];
//
//     while (x >= 0 && x < 8 && y >= 0 && y < 8)
//     {
//         Vector2Int nexPosition = new Vector2Int(x, y);
//         moves.Add(nexPosition);
//         
//     }
//     
// }