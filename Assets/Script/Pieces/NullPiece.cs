using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "NullPiece", menuName = "Piece/NullPiece", order = 1)] 
    public class NullPiece : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            throw new System.NotImplementedException();
        }
    }
}