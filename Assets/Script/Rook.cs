using UnityEngine;

namespace Script
{
    [CreateAssetMenu(fileName = "Rook", menuName = "Piece/Rook", order = 1)] 
    public class Rook : Piece
    {
        public override Vector2Int availableMovement()
        {
            throw new System.NotImplementedException();
        }
    }
}