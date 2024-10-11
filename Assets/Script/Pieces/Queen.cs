using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Queen", menuName = "Piece/Queen", order = 1)] 
    public class Queen : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            throw new System.NotImplementedException();
        }
    }
}