using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Bishop", menuName = "Piece/Bishop", order = 1)]  
    public class Bishop : Piece
    {
        public override Vector2Int availableMovement()
        {
            throw new System.NotImplementedException();
        }
    }
}