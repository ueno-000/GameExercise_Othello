using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Othello : MonoBehaviour
{

    [SerializeField]
    //private Piece _piecePrefab = null;

    List<Piece> _piece = new List<Piece>();


    void Start()
    {

        // 0`ŒÂ”-1‚Ü‚Å‚Ìq‚ğ‡”Ô‚É”z—ñ‚ÉŠi”[
        for (var i = 0; i < this.transform.childCount; ++i)
        {
            _piece.Add(this.transform.GetChild(i).GetComponentInChildren<Piece>());
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
