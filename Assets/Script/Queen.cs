using UnityEngine;

namespace Script
{
    [CreateAssetMenu(fileName = "Queen", menuName = "Piece/Queen", order = 1)] 
    public class Queen : Piece
    {
        public override Vector2Int availableMovement()
        {
            throw new System.NotImplementedException();
        }
    }
}