using UnityEngine;
using UnityEngine.EventSystems;

namespace Script.Game
{
    public class TakeCoordonateEmpty : MonoBehaviour, IPointerClickHandler
    {
        private Vector2Int _position;
        public bool CanClick;

        public void Setup(Vector2Int position)
        {
            _position = position;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (CanClick)
            {
                //GameManager.Instance.SelectedPiece.GetComponent<PieceHandler>().MovePiece(_position);
                GameManager.Instance.BlackTurn =! GameManager.Instance.BlackTurn;
            }
        }
    }
}
