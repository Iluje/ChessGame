using Script.Pieces;
using UnityEngine;
using UnityEngine.Serialization;
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
        
        public GameObject SelectedPiece;
        [FormerlySerializedAs("WhiteTurn")] public bool BlackTurn = true;
        
        private PieceHandler _pieceHandler;

        public Piece[,] Pieces;
        public GameObject[,] GameObjectDisplay;

        private void Start()
        {
            Pieces = new Piece[,]
            {
                { BlackRook, BlackKnight, BlackBishop, BlackKing, BlackQueen, BlackBishop, BlackKnight, BlackRook },
                { BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn, BlackPawn},
                { null, null, null, null,null, null, null, null},
                { null, null, null, WhiteKing,null, null, null, null},
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
            
            GameObjectDisplay = new GameObject[8, 8];
            
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
                    }
                    else
                    {
                        instantiate = Instantiate(EmptyGameObject, pieceParent);
                        instantiate.GetComponent<PieceHandler>().Setup(new Vector2Int(x, y));
                        instantiate.GetComponent<TakeCoordonateEmpty>().Setup(new Vector2Int(x,y));
                    }
                    
                    GameObjectDisplay[x, y] = instantiate;
                }
            }
            foreach (GameObject SelectedObject in GameObjectDisplay)
            {
                gameObject.GetComponent<BoxCollider2D>();
                BoxCollider2D collider = SelectedObject.GetComponent<BoxCollider2D>();
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
