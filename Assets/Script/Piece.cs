using UnityEngine;



namespace Script
{
 
    public abstract class Piece : ScriptableObject
    {
        public Sprite sprite;
        public bool isWhite;

        public abstract Vector2Int availableMovement();
    }
}
