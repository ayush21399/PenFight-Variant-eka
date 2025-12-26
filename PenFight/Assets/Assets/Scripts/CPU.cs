using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CPU : MonoBehaviour
{

    public GameObject GB_playerpen;
    public Transform TF_playerpen;
    public Transform TF_cpupen;

    private Vector3 POS_player;
    private Vector3 POS_CPU;

    //common fields to calculate
    public float distanceBTW;
    public float angleBTW;
    Vector3 directionBTW;
    //public float directionBTW;


    void Start()
    {
        GB_playerpen = GameObject.FindWithTag("PEN"); // getting player pen gameobject
        PlayerPosition();
    }

    
    void Update()
    {
        
        //PlayerPosition();
    }

    public void PlayerPosition()
    {
        TF_playerpen = GB_playerpen.transform;
        TF_cpupen = this.transform;

        POS_player = TF_playerpen.position;
        POS_CPU = this.transform.position;

        if (GB_playerpen != null)
        {
            distanceBTW = Vector3.Distance(POS_CPU, POS_player);
            directionBTW = (POS_player - POS_CPU).normalized;
            angleBTW = Vector3.Angle(TF_cpupen.forward, directionBTW);

           // Debug.Log($"Distance to player: {distanceBTW}");
           // Debug.Log($"Angle to player: {directionBTW}");
           // Debug.Log($"Direction to player: {angleBTW}");
        }
    }
}
