using System;
using Script.Pieces;
using UnityEngine;
using Utils;

namespace Script.Game
{
    public class GameManager : MonoBehaviourSingleton<GameManager>
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
        [SerializeField] private GameObject TranparentPiecePrefab;

        public Piece[,] Pieces;
        
        private void Start()
        {
            Pieces = new Piece[,]
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

            for (int x = 0; x < Pieces.GetLength(0); x++)
            {
                for (int y = 0; y < Pieces.GetLength(1); y++)
                {
                    if (Pieces[x, y] != null)
                    {
                        GameObject newPiece = Instantiate(PiecePrefab, pieceParent);
                        newPiece.GetComponent<PieceHandler>().Setup(Pieces[x, y], new Vector2Int(x, y));
                    }
                    else
                    {
                        Instantiate(TranparentPiecePrefab, pieceParent);
                    }
                }
            }
        }
    }
}
