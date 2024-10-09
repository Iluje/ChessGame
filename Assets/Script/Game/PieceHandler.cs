using System;
using Script.Pieces;
using UnityEngine;
using UnityEngine.EventSystems;
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

        public void OnPointerClick(PointerEventData eventData)
        {
            bool _haveCurentPostion = false;
            Vector2Int CurentPosition = _position;
            Vector2Int NewPosition = _position;
            
            if (_haveCurentPostion == false)
            {
                Debug.Log(CurentPosition + _piece.name); 
                _haveCurentPostion = true;
            }
            else
            {
                CurentPosition = NewPosition;
                _position = NewPosition;
            }
            
            
            
            
        }
    }
}
