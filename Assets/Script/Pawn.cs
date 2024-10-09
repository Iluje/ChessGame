using UnityEngine;

namespace Script
{
    [CreateAssetMenu(fileName = "Pawn", menuName = "Piece/Pawn", order = 1)] 
    public class Pawn : Piece
    {
        public override Vector2Int availableMovement()
        {
            throw new System.NotImplementedException();
        }
    }
}