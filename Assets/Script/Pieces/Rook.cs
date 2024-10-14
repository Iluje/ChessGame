using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Rook", menuName = "Piece/Rook", order = 1)] 
    public class Rook : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            
            return moves;
        }
    }
}