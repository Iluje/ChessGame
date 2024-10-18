using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Queen", menuName = "Piece/Queen", order = 1)] 
    public class Queen : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();

            // déplacement vertical et horizontal
            
            for (int i = position.x + 1; i <= 7; i++)
            {
                Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[i, position.y] == null)
                {
                    moves.Add(new Vector2Int(i, position.y));
                    continue;
                }
                else
                {
                    break;
                }
            }
            for (int i = position.x - 1; i >= 0; i--)
            {
                Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[i, position.y] == null)
                {
                    moves.Add(new Vector2Int(i, position.y));
                    continue;
                }
                else
                {
                    break;
                }
            }
            for (int i = position.y + 1; i <= 7; i++)
            {
                Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[position.x, i] == null)
                {
                    moves.Add(new Vector2Int(position.x, i));
                    continue;
                }
                else
                {
                    break;
                }
            }
            for (int i = position.y - 1; i >= 0; i--)
            {
                Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[position.x, i] == null)
                {
                    moves.Add(new Vector2Int(position.x, i));
                    continue;
                }
                else
                {
                    break;
                }
            }

            // Déplacement diagonal
            
            for (int i = 1; position.x + i <= 7 && position.y + i <= 7; i++)
            {
                if (GameManager.Instance.Pieces[position.x + i, position.y + i] == null)
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
                if (GameManager.Instance.Pieces[position.x + i, position.y - i] == null)
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
                if (GameManager.Instance.Pieces[position.x - i, position.y + i] == null)
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
                if (GameManager.Instance.Pieces[position.x - i, position.y - i] == null)
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