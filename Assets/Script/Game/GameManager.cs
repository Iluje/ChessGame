using System;
using Script.Pieces;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
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
        
        [SerializeField] private GameObject EmptyGameObject;
        [SerializeField] private GameObject PiecePrefab;
        [SerializeField] private Transform pieceParent;
        [SerializeField] private GameObject TranparentPiecePrefab;
        
        private PieceHandler _pieceHandler;

        public Piece[,] Pieces;
        public GameObject[,] SelectGameobject;

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
            
            DiplayMatrix();
            
        }
        
        public void DiplayMatrix()
        {
            // je créer un gameObject qui ferra la même chose que la création du tableau.
            
            SelectGameobject = new GameObject[8, 8];
            
            for (int x = 0; x < Pieces.GetLength(0); x++)
            {
                for (int y = 0; y < Pieces.GetLength(1); y++)
                {
                    
                    // créer un GameObject Apeller instantiate
                    GameObject instantiate;
                    if (Pieces[x, y] != null)
                    {
                        instantiate = Instantiate(PiecePrefab, pieceParent);
                        instantiate.GetComponent<PieceHandler>().Setup(Pieces[x, y], new Vector2Int(x, y));
                        Debug.Log("instanciated piece");
                    }
                    else
                    {
                        instantiate = Instantiate(EmptyGameObject, pieceParent);
                        Debug.Log("instanciated piece vide");
                    }
                    
                    SelectGameobject[x, y] = instantiate;
                }
            }
        }

        public void ResetMatrix()
        {
            foreach (Transform child in pieceParent)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
