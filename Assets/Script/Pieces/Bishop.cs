using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Bishop", menuName = "Piece/Bishop", order = 2)]
    public class Bishop : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            
            for (int i = 1; position.x + i <= 7 && position.y + i <= 7; i++)
            {
                if (GameManager.Instance.Pieces[position.x + i, position.y + i] == null || GameManager.Instance.Pieces[position.x + i, position.y + i] != null)
                {
                    moves.Add(new Vector2Int(position.x + i, position.y + i));
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = 1; position.x + i <= 7 && position.y - i >= 0; i++)
            {
                if (GameManager.Instance.Pieces[position.x + i, position.y - i] == null || GameManager.Instance.Pieces[position.x + i, position.y - i] != null)
                {
                    moves.Add(new Vector2Int(position.x + i, position.y - i));
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = 1; position.x - i >= 0 && position.y + i <= 7; i++)
            {
                if (GameManager.Instance.Pieces[position.x - i, position.y + i] == null || GameManager.Instance.Pieces[position.x - i, position.y + i] != null)
                {
                    moves.Add(new Vector2Int(position.x - i, position.y + i));
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = 1; position.x - i >= 0 && position.y - i >= 0; i++)
            {
                if (GameManager.Instance.Pieces[position.x - i, position.y - i] == null || GameManager.Instance.Pieces[position.x - i, position.y - i] != null)
                {
                    moves.Add(new Vector2Int(position.x - i, position.y - i));
                    continue;
                }
                else
                {
                    break;
                }
            }

            return moves;
        }
    }
}