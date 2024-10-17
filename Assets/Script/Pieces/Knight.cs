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
                new Vector2Int(1, -2),
            };

            Vector2Int testMovement;
            testMovement = position;

            foreach (Vector2Int movement in knightMovements)
            {
                testMovement += movement;
                Debug.Log(testMovement);
                if (testMovement.x > 7 || testMovement.x < 0 || testMovement.y > 7 || testMovement.y < 0)
                {
                    Debug.Log(testMovement + " is out of range ");
                    continue;
                }
                if (GameManager.Instance.Pieces[testMovement.x, testMovement.y] == null)
                {
                    moves.Add(new Vector2Int(testMovement.x, testMovement.y));
                }

                testMovement = position;
            }

            return moves;
        }
    }
}