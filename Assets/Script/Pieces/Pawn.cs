using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Pawn", menuName = "Piece/Pawn", order = 1)] 
    public class Pawn : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            
            if (isWhite)
            {
                moves.Add(new Vector2Int(-1, 0) + position);
                moves.Add(new Vector2Int(-2, 0) + position);
            }
            else
            {
                moves.Add(new Vector2Int(1, 0) + position);
                moves.Add(new Vector2Int(2, 0) + position);
            }
            
            return moves;
        }
    }
}