using System.Collections.Generic;
using UnityEngine;

namespace Script.Pieces
{
 
    public abstract class Piece : ScriptableObject
    {
        public Sprite sprite;
        public bool isWhite;
        
        public abstract List<Vector2Int> availableMovement(Vector2Int position);
    }
}
