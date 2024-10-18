using System.Collections.Generic;
using Script.Game;
using UnityEngine;

namespace Script.Pieces
{
    [CreateAssetMenu(fileName = "Rook", menuName = "Piece/Rook", order = 1)]
    public class Rook : Piece
    {
        public override List<Vector2Int> availableMovement(Vector2Int position)
        {
            List<Vector2Int> moves = new List<Vector2Int>();
            
            
            for (int i = position.x + 1; i <= 7; i++)
            {
                //Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[i, position.y] == null || GameManager.Instance.Pieces[i, position.y] != null)
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
                //Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[i, position.y] == null || GameManager.Instance.Pieces[i, position.y] != null)
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
               //Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[position.x, i] == null || GameManager.Instance.Pieces[position.x, i] != null)
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
                //Debug.Log(i + " , " + position.y);
                if (GameManager.Instance.Pieces[position.x, i] == null || GameManager.Instance.Pieces[position.x, i] != null)
                {
                    moves.Add(new Vector2Int(position.x, i));
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