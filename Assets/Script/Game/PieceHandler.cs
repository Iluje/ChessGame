using System;
using System.Collections.Generic;
using System.Linq;
using Script.Pieces;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Script.Game
{
    public class PieceHandler : MonoBehaviourSingleton<PieceHandler>, IPointerClickHandler
    {

        private TakeCoordonateEmpty _takeCoordonateEmpty;
        
        [SerializeField] private bool _isSelected;
        private Piece _selectedPiece;
        
        public Vector2Int _position;
        private Image _image;
        private Piece _piece;

        public Vector2Int OldPosition;
        
        List<Vector2Int> moves = new List<Vector2Int>();

        private List<Vector2Int> availableMovement = new List<Vector2Int>();
        
        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        public void Setup(Piece piece, Vector2Int position)
        {
            _piece = piece;
            _position = position;
            _image.sprite = piece.sprite;
        }

        public void Setup(Vector2Int position)
        {
            _position = position;
        }


        private void Update()
        {
            Debug.Log(_isSelected);
        }


        public void  OnPointerClick(PointerEventData eventData)
        {
            List<Vector2Int> AvaibleMovement = new List<Vector2Int>();

            GameManager.Instance.ResetMatrix();
            GameManager.Instance.DiplayMatrix();

            
            
            Debug.Log("la nouvelle piece est "  + GameManager.Instance.SelectedPiece);

            
            
            Debug.Log(_position);
            if (_isSelected)
            {
                Piece movingPiece = GameManager.Instance.Pieces[OldPosition.x, OldPosition.y];
                GameManager.Instance.Pieces[OldPosition.x, OldPosition.y] = null;
                GameManager.Instance.Pieces[_position.x, _position.y] = movingPiece;
            
                GameManager.Instance.ResetMatrix();
                GameManager.Instance.DiplayMatrix();
            }
            else
            {
                if (_piece == null)
                {
                    return;
                }
                foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
                {
                    availableMovement.Add(vector2Int);

                    PieceHandler MovementPosible = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
                    MovementPosible._image.color = Color.cyan;

                    MovementPosible._isSelected = true;
                    MovementPosible.OldPosition = _position;
                    
                    GameManager.Instance.SelectedPiece = _piece;
                }

                // foreach (Vector2Int VARIABLE in availableMovement)
                // {
                //     Debug.Log(VARIABLE);
                // }

                
            }
            
            
            
            
            
            
        }
        

        // public void MovePiece(Vector2Int newPosition)
        // {
        //     //Debug.Log("Movement de " + _position + " à " + newPosition);
        //     GameManager.Instance.Pieces[_position.x, _position.y] = null;
        //     GameManager.Instance.Pieces[newPosition.x, newPosition.y] = _piece;
        //     
        //     GameManager.Instance.ResetMatrix();
        //     GameManager.Instance.DiplayMatrix();
        // }
    }
}









// GameManager.Instance.SelectedPiece = gameObject;
//
// GameManager.Instance.SelectedPiece = gameObject;
//
// foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
// { 
//     //TakeCoordonateEmpty EmptySelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<TakeCoordonateEmpty>();
//     
//     
//     PieceHandler PieceSelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
//     PieceSelect._image.color = new Color(1f, 1f, 0f, 0.4f);
//     
//     
//     //EmptySelect.CanClick = true;
// }
// Debug.Log(moves.Count);







// if (GameManager.Instance.BlackTurn)
// {
//     if (_piece.isWhite == false)
//     {
//         GameManager.Instance.SelectedPiece = gameObject;
//
//         foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
//         { 
//             //TakeCoordonateEmpty EmptySelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<TakeCoordonateEmpty>();
//             PieceHandler PieceSelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
//             PieceSelect._image.color = new Color(1f, 1f, 0f, 0.4f);
//             //EmptySelect.CanClick = true;
//         }
//         Debug.Log(moves.Count);
//     }
// }
// else
// {
//     if (_piece.isWhite)
//     {
//         GameManager.Instance.SelectedPiece = gameObject;
//
//         foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
//         { 
//             //TakeCoordonateEmpty EmptySelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<TakeCoordonateEmpty>();
//             PieceHandler PieceSelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
//             PieceSelect._image.color = new Color(1f, 1f, 0f, 0.4f);
//             //EmptySelect.CanClick = true;
//         }
//         Debug.Log(moves.Count);
//     }
// }
