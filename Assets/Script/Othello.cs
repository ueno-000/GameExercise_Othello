using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Othello : MonoBehaviour
{

    [SerializeField] private List<Piece> _piece = new List<Piece>();


    private void Start()
    {
        for (var i = 0; i < this.transform.childCount; ++i)
        {
            var p = this.transform.GetChild(i).GetComponentInChildren<Piece>();
            _piece.Add(p);
            
            //真ん中四つのpieceをアクティブ化
            if (i == 27 || i == 28 || i == 35 || i == 36)
            {
                if(i == 27||i == 36) {p.piececolor = PieceColor.black;}
                else { p.piececolor = PieceColor.white; }
                
            }
        }



    }
    // Update is called once per frame
    private void Update()
    {
        
    }

}
