using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "King", menuName = "Piece/King", order = 1)]  
    public class King : Piece
    {
        public override Vector2Int availableMovement()
        {
            throw new System.NotImplementedException();
        }
    }
}