using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    //Turkey

    public GameObject winMenuUl;

    int totalPiece = 3;
    int piece = 0;

    public void LevelTurkeyFinish()
    {
        piece++;
        if(piece==totalPiece)
        {
            winMenuUl.SetActive(true);
        }
    }
}
