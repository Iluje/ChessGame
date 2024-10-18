using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Knight", menuName = "Piece/Knight", order = 1)]
    public class Knight : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            
            List<Vector2Int> knightMovements = new List<Vector2Int>()
            {
                new Vector2Int(2, 1),
                new Vector2Int(2, -1),
                new Vector2Int(-2, 1),
                new Vector2Int(-2, -1),
                new Vector2Int(-1, 2),
                new Vector2Int(1, 2),
                new Vector2Int(-1, -2),
                new Vector2Int(1, -2)
            };

            foreach (Vector2Int movement in knightMovements)
            {
                Vector2Int testMovement = position + movement;

                if (testMovement.x > 7 || testMovement.x < 0 || testMovement.y > 7 || testMovement.y < 0)
                {
                    Debug.Log("n'est pas dans le tableau");
                    continue;
                }
                if (GameManager.Instance.Pieces[testMovement.x, testMovement.y] == null)
                {
                    moves.Add(testMovement);
                }
            }
            return moves;
        }
    }
}