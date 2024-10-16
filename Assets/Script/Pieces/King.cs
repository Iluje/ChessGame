using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "King", menuName = "Piece/King", order = 1)]
    public class King : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();

            moves.Add(new Vector2Int(-1, 0) + position);
            moves.Add(new Vector2Int(1, 0) + position);

            moves.Add(new Vector2Int(0, -1) + position);
            moves.Add(new Vector2Int(0, 1) + position);

            moves.Add(new Vector2Int(1, 1) + position);
            moves.Add(new Vector2Int(-1, -1) + position);
            moves.Add(new Vector2Int(1, -1) + position);
            moves.Add(new Vector2Int(-1, 1) + position);
            
            return moves;
        }

    }
}