using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Bishop", menuName = "Piece/Bishop", order = 1)]  
    public class Bishop : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            throw new System.NotImplementedException();
        }
    }
}