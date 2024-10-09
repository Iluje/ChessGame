using UnityEngine;

namespace Script.ScriptGame
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Piece WhitePawn;
        [SerializeField] private Piece WhiteKing;
        [SerializeField] private Piece WhiteQueen;
        [SerializeField] private Piece WhiteRook;
        [SerializeField] private Piece WhiteKnight;
        [SerializeField] private Piece WhiteBishop;
    
        [SerializeField] private Piece BlackPawn;
        [SerializeField] private Piece BlackKing;
        [SerializeField] private Piece BlackQueen;
        [SerializeField] private Piece BlackRook;
        [SerializeField] private Piece BlackKnight;
        [SerializeField] private Piece BlackBishop;
    
        [SerializeField] private GameObject PiecePrefab;
        [SerializeField] private Transform pieceParent;
    
        private void Start()
        {
            Piece[,] piece =
            {
                { BlackRook, BlackKnight, BlackBishop, BlackKing, BlackQueen, BlackBishop, BlackKnight, BlackRook },
                { BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn},
                { null, null, null, null,null, null, null, null},
                { null, null, null, null,null, null, null, null},
                { null, null, null, null,null, null, null, null},
                { null, null, null, null,null, null, null, null},
                { WhitePawn, WhitePawn, WhitePawn, WhitePawn, WhitePawn, WhitePawn, WhitePawn, WhitePawn},
                { WhiteRook, WhiteKnight, WhiteBishop, WhiteKing, WhiteQueen, WhiteBishop, WhiteKnight, WhiteRook },
            };

            for (int i = 0; i < piece.GetLength(0); i++)
            {
                for (int j = 0; j < piece.GetLength(1); j++)
                {
                    Debug.Log(piece[i, j].name);
                    
                    GameObject instantiate = Instantiate(PiecePrefab, pieceParent);
                    instantiate.GetComponent<PieceDisplay>();
                }
            }
            
            // GameObject instantiate = Instantiate(PiecePrefab, PieceParent);
            // instantiate.GetComponent<PieceDisplay>().Setup();

        }
    }
}
