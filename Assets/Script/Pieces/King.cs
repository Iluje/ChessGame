using System.Collections.Generic;
using Script.Game;
using Unity.VisualScripting;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "King", menuName = "Piece/King", order = 1)]
    public class King : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            List<Vector2Int> Position = new List<Vector2Int>();

            for (int i = 0; i < 1; i++)
            {
                int X = position.x + position.x;
                int Y = position.y + position.y;

                if (GameManager.Instance.Pieces[X, Y] != null)
                {
                    
                }
                
                moves.Add(new Vector2Int(-1, 0) + position);
                moves.Add(new Vector2Int(1, 0) + position);
                moves.Add(new Vector2Int(0, -1) + position);
                moves.Add(new Vector2Int(0, 1) + position);
                moves.Add(new Vector2Int(1, 1) + position);
                moves.Add(new Vector2Int(-1, -1) + position);
                moves.Add(new Vector2Int(1, -1) + position);
                moves.Add(new Vector2Int(-1, 1) + position);
            }
            
            
            
            
            
            // for (int i = 0; i < 1; i++)
            // {
            //     int X = position.x + position.x;
            //     int Y = position.y + position.y;
            //     
            //     while ((X < 0 || X >= 8 || Y < 0 || Y >= 8))
            //     {
            //         Vector2Int AddPosition = new Vector2Int(X, Y);
            //         moves.Add(AddPosition);
            //         
            //         moves.Add(new Vector2Int(-1, 0) + position);
            //         moves.Add(new Vector2Int(1, 0) + position);
            //         moves.Add(new Vector2Int(0, -1) + position);
            //         moves.Add(new Vector2Int(0, 1) + position);
            //         moves.Add(new Vector2Int(1, 1) + position);
            //         moves.Add(new Vector2Int(-1, -1) + position);
            //         moves.Add(new Vector2Int(1, -1) + position);
            //         moves.Add(new Vector2Int(-1, 1) + position);
            //         break;
            //     }
            // }
            
            return moves;
        }

    }
}