using System;
using System.Collections.Generic;
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
        
        private bool _isSelected;
        private Vector2Int _curentCoordonate;
        
        public Vector2Int _position;
        private Image _image;
        public Piece _piece;
        
        List<Vector2Int> moves = new List<Vector2Int>();

        public Vector2Int CurentPosition;

        [SerializeField] private bool HavePiece;
       [SerializeField] private bool _isPosibleMovement;
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

        public void  OnPointerClick(PointerEventData eventData)
        {

                
            GameManager.Instance.SelectedPiece = gameObject;
            
            foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
            { 
                TakeCoordonateEmpty EmptySelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<TakeCoordonateEmpty>();
                PieceHandler PieceSelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
                PieceSelect._image.color = new Color(1f, 1f, 0f, 0.4f);
                EmptySelect.CanClick = true;
            }
            Debug.Log(moves.Count);
            
            
            
            
            
            // if (GameManager.Instance.BlackTurn)
            // {
            //     if (_piece.isWhite == false)
            //     {
            //         GameManager.Instance.SelectedPiece = gameObject;
            //
            //         foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
            //         { 
            //             TakeCoordonateEmpty EmptySelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<TakeCoordonateEmpty>();
            //             PieceHandler PieceSelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
            //             PieceSelect._image.color = new Color(1f, 1f, 0f, 0.4f);
            //             EmptySelect.CanClick = true;
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
            //             TakeCoordonateEmpty EmptySelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<TakeCoordonateEmpty>();
            //             PieceHandler PieceSelect = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
            //             PieceSelect._image.color = new Color(1f, 1f, 0f, 0.4f);
            //             EmptySelect.CanClick = true;
            //         }
            //         Debug.Log(moves.Count);
            //     }
            // }
        }

        public void MovePiece(Vector2Int newPosition)
        {
            //Debug.Log("Movement de " + _position + " à " + newPosition);
            GameManager.Instance.Pieces[_position.x, _position.y] = null;
            GameManager.Instance.Pieces[newPosition.x, newPosition.y] = _piece;
            
            
            
            GameManager.Instance.ResetMatrix();
            GameManager.Instance.DiplayMatrix();
        }

        public void EatPiece()
        {
            Debug.Log("Eat Piece");
        }
    }
    //GameManager.Instance.ResetMatrix();
    //GameManager.Instance.DiplayMatrix();
            
    // if (moves.Count != 0)
    // {
    //     moves.Clear();
    //     
    //     GameManager.Instance.ResetMatrix();
    //     GameManager.Instance.DiplayMatrix();
    // }
    
       
    // //PieceHandler selectedPieceHandler = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
    // //selectedPieceHandler.Select(_position);
    // GameManager.Instance.Pieces[_position.x, _position.y] = GameManager.Instance.SelectedPiece;
    // //_image.color = new Color(_image.color.r, _image.color.g, _image.color.b, 0.4f);
    
    
    // //PieceHandler selectedPieceHandler = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
    // //selectedPieceHandler.Select(_position);
    // GameManager.Instance.Pieces[_position.x, _position.y] = GameManager.Instance.SelectedPiece;
    // //_image.color = new Color(_image.color.r, _image.color.g, _image.color.b, 0.4f);
    
    // private void Select(Vector2Int position) 
    // {
    //     //_image.color = new Color(_image.color.r, _image.color.g, _image.color.b, 0.4f);
    //     //_takeCoordonateEmpty = GetComponent<TakeCoordonateEmpty>();
    //     //_positionMovement = position;
    //     //_isSelected = true;
    // }
    
    // Debug.Log("Movement de " + _positionMovement + " à " + _takeCoordonateEmpty.Coordonate);
    // GameManager.Instance.Pieces[_positionMovement.x, _positionMovement.y] = null;
    // GameManager.Instance.Pieces[_takeCoordonateEmpty.Coordonate.x, _takeCoordonateEmpty.Coordonate.y] = _piece;
                
    //GameManager.Instance.Pieces[_position.x, _position.y] = _piece;
    //GameManager.Instance.Pieces[_position.x, _position.y] = _piece;
}
