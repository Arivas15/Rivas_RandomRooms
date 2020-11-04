using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    // can't see 2D array in inspector
    public Transform[] roomSpawnersRow0;
    public Transform[] roomSpawnersRow1;
    public Transform[] roomSpawnersRow2;
    public Transform[] roomSpawnersRow3;

    public GameObject[] rooms;

    public int testRow = 0;
    public int testColumn = 0;
    public int testType = 0;
    void GenerateLevel();

    myGrid[4][4];
    int r;

    // Use this for initialization
    void Start () 
    {
        myGrid[r][0] = 1;

    }
	
	// Update is called once per frame
	void Update () 
    {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddRoom(testRow, testColumn, testType);
        }
	}

    public void AddRoom(int row, int column, int roomType)
    {
        Vector3 spawnPos = Vector3.zero;
        // figure out position to spawn at
        switch(row)
        {
            case 0:
                spawnPos = roomSpawnersRow0[column].position;
                break;
            case 1:
                spawnPos = roomSpawnersRow1[column].position;
                break;
            case 2:
                spawnPos = roomSpawnersRow2[column].position;
                break;
            case 3:
                spawnPos = roomSpawnersRow3[column].position;
                break;
        }

        // actually spawn it
        Instantiate(rooms[roomType], spawnPos, transform.rotation);
    }
    void GenerateLevel()
    {
        myGrid[r][0];
        done = false;

        int nextroom = -1;

        myGrid = Random[0, 5];

        if (myGrid == 1 || 2)
            myGrid[r][roomtype 1, roomtype 2];
        if (myGrid == 3 || 4)
            myGrid[r][roomtype 3, roomtype 4];
        if (myGrid == 5)
            myGrid[r][roomtype 5];

        myGrid[][] = nextroom;
        done = true;

    }
}