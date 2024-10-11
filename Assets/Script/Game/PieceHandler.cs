using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Script.Pieces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Script.Game
{
    public class PieceHandler : MonoBehaviour, IPointerClickHandler
    {
        
        private bool CanMove;
        private bool CanEat;
        
        private Vector2Int _position;
        private Image _image;
        private Piece _piece;

        private Vector2Int _curentVector2Int;
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

        public void  OnPointerClick(PointerEventData eventData)
        {
            GameManager.Instance.ResetMatrix();
            GameManager.Instance.DiplayMatrix();
            
            foreach (Vector2Int vector2Int in _piece.availableMovement(_position))
            { 
                Debug.Log(vector2Int);
                
                _curentVector2Int = vector2Int;
                
               Image image = GameManager.Instance.SelectGameobject[_curentVector2Int.x, _curentVector2Int.y].GetComponent<Image>();
               image.color = new Color(image.color.r, image.color.g, image.color.b, 0.4f);
               
               Debug.Log(_curentVector2Int);
            }
            // GameManager.Instance.Pieces[_position.x, _position.y] = null;
            // GameManager.Instance.Pieces[_position.x + 1, _position.y] = _piece;
            
            // GameManager.Instance.ResetMatrix();
            // GameManager.Instance.DiplayMatrix();
        }
    }
}
