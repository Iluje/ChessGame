using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class PieceDisplay : MonoBehaviour
{
   private SpriteRenderer _spriteRenderer;
   
   private void Start()
   {
       _spriteRenderer = GetComponent<SpriteRenderer>();
   }

   public void Setup(Piece piece)
   {
       _spriteRenderer.sprite = piece.sprite;
   }
}
