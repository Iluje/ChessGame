using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "King", menuName = "Piece/King", order = 2)]
    public class King : Piece
    {
        
        
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            
            List<Vector2Int> kingMovements = new List<Vector2Int>()
            {
                new Vector2Int(1, 0), 
                new Vector2Int(-1, 0),
                new Vector2Int(0, 1),   
                new Vector2Int(0, -1), 
                new Vector2Int(1, 1),   
                new Vector2Int(1, -1),  
                new Vector2Int(-1, 1),  
                new Vector2Int(-1, -1)   
            };
            
            foreach (Vector2Int movement in kingMovements)
            {
                Vector2Int testMovement = position + movement;
                Debug.Log(testMovement);
                
                if (testMovement.x > 7 || testMovement.x < 0 || testMovement.y > 7 || testMovement.y < 0)
                {
                    Debug.Log("n'est pas dans le tableau");
                    continue;
                }
                if (GameManager.Instance.Pieces[testMovement.x, testMovement.y] == null || GameManager.Instance.Pieces[testMovement.x, testMovement.y] != null)
                {
                    moves.Add(testMovement);
                }
            }
            return moves;
        }
        
           
    }
}