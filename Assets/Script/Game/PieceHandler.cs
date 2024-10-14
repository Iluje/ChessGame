using System;
using System.Collections;
using Script.Pieces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Script.Game
{
    public class PieceHandler : MonoBehaviourSingleton<PieceHandler>, IPointerClickHandler
    {

        private bool _isSelected;
        private Vector2Int _positionMovement;
        
        private Vector2Int _position;
        private Image _image;
        private Piece _piece;

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
            Debug.Log(_position);
            if (_isSelected)
            {
                Debug.Log("Movement de " + _positionMovement + " à " + _position);
                GameManager.Instance.Pieces[_positionMovement.x, _positionMovement.y] = null;
                GameManager.Instance.Pieces[_position.x, _position.y] = _piece;
                
                //MoveTest();
                //GameManager.Instance.Pieces[_position.x, _position.y] = _piece;
                //GameManager.Instance.Pieces[_position.x, _position.y] = _piece;

                GameManager.Instance.ResetMatrix();
                GameManager.Instance.DiplayMatrix();
            }
            else
            {
                GameManager.Instance.ResetMatrix();
                GameManager.Instance.DiplayMatrix();

                //_curentPosition = _position;
                foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
                { 
                    PieceHandler selectedPieceHandler = GameManager.Instance.GameObjectDisplay[vector2Int.x, vector2Int.y].GetComponent<PieceHandler>();
                    selectedPieceHandler.Select(_position);
                }
            }
        }
        private void Select(Vector2Int position) 
        {
            _image.color = new Color(_image.color.r, _image.color.g, _image.color.b, 0.4f);
            _positionMovement = position;
            _isSelected = true;
        }

        private void Update()
        {
            Debug.Log(_isSelected);
        }

       [ContextMenu("MoveTest")] public void MoveTest()
        {
            GameManager.Instance.Pieces[_position.x = 4, _position.y = 4] = _piece;
        }
    }
}
