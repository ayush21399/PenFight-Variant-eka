using System;
using System.Collections.Generic;
using UnityEngine;

public class CamMoves : MonoBehaviour
{
    Dictionary<string, Transform> CamBoardPoints = new Dictionary<string, Transform>();
    Transform pointA, pointB, pointC, pointD, pointE, pointF, pointG, pointH;



    void Start()
    {
        GameObject[] CamPoints = GameObject.FindGameObjectsWithTag("CamPoint");
        foreach (GameObject obj in CamPoints)
        {
            CamBoardPoints.Add(obj.name, obj.transform);
        }

        pointA = CamBoardPoints["CamPointA"];
        pointB = CamBoardPoints["CamPointB"];
        pointC = CamBoardPoints["CamPointC"];
        pointD = CamBoardPoints["CamPointD"];
        pointE = CamBoardPoints["CamPointE"];
        pointF = CamBoardPoints["CamPointF"];
        pointG = CamBoardPoints["CamPointG"];
        pointH = CamBoardPoints["CamPointH"];
        // Debug.Log(pointA.position);
        
    }

   
    void Update()
    {
        
    }
}
