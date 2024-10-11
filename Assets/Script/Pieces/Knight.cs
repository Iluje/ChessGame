using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Knight", menuName = "Piece/Knight", order = 1)]  
    public class Knight : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            throw new System.NotImplementedException();
        }
    }
}