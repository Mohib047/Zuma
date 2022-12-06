using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherModel : ZumaElement
{
    public Vector3 lookDir;
    public Vector3 dir;
    public GameObject spawnPoint;
    public GameObject[] ballPrefab;
    public GameObject currentBall;
    public float speed = 2000;
    private void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint");
    }
}
