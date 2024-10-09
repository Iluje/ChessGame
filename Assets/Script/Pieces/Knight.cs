using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Knight", menuName = "Piece/Knight", order = 1)]  
    public class Knight : Piece
    {
        public override Vector2Int availableMovement()
        {
            throw new System.NotImplementedException();
        }
    }
}