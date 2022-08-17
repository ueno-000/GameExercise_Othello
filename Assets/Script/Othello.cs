using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Othello : MonoBehaviour
{

    [SerializeField]
    private Piece _piecePrefab = null;

    List<Piece> _piece = new List<Piece>();


    void Start()
    {
        for (var i = 0; i < this.transform.childCount; ++i)
        {
            _piece.Add(this.transform.GetChild(i).GetComponentInChildren<Piece>());
            
            //真ん中四つのpieceをアクティブ化
            if (i == 27 || i == 28 || i == 35 || i == 36)
            {
                this.transform.GetChild(i).GetComponent<Transform>().GetChild(0).gameObject.SetActive(true);                
            }
        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
