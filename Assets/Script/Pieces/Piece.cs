using UnityEngine;

namespace Script.Pieces
{
 
    public abstract class Piece : ScriptableObject
    {
        public Sprite sprite;
        public bool isWhite;
        
        public abstract Vector2Int availableMovement();
        
        
    }
}
