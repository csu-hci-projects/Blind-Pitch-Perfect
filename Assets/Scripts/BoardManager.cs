//some code pulled from https://learn.unity.com/tutorial/2d-roguelike-setup-and-assets?uv=5.x&projectId=5c514a00edbc2a0020694718#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour
{
    public int columns = 8;
    public int rows = 8;
    public GameObject exit;
    public GameObject[] floorTiles;
    public GameObject[] wallTiles;
    public GameObject[] foodTiles;
    public GameObject[] outerWallTiles;

    private Transform boardHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    void InitialiseList(){
        gridPositions.Clear();
        for(int x =1; x< columns - 1; x++){
            for (int y = 1; y < rows - 1; y++){
                gridPositions.Add(new Vector3(x,y,0f));
            }
        }
    }
    void BoardSetup()
    {
        boardHolder = new GameObject("Board").transform;
        for(int x = -1; x < columns + 1; x++){
            for(int y = -1; y < rows + 1; y++){
                GameObject toInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];
                if(x == -1 || x == columns || y == -1 || y == rows)
                    toInstantiate = outerWallTiles[Random.Range(0, outerWallTiles.Length)];

                GameObject instance = Instantiate(toInstantiate, new Vector3 (x,y,0f), Quaternion.identity) as GameObject;

                instance.transform.SetParent(boardHolder);
            }
        }
    }

    void LayoutWalls(GameObject[] wallArray, GameObject[] foodArray){
        GameObject wallChoice = wallArray[Random.Range (0, wallArray.Length)];
        GameObject foodChoice = foodArray[Random.Range (0, foodArray.Length)];
        for(int i = 1; i < 7; i++){
            Instantiate(wallChoice, new Vector3(columns-2, rows - i, 0f), Quaternion.identity);
            Instantiate(wallChoice, new Vector3((columns -2) -i, rows - 6, 0f), Quaternion.identity);
        }
        for(int i = 2; i < 8; i++){
            Instantiate(foodChoice, new Vector3(columns - 1, rows - i, 0f),Quaternion.identity);
            Instantiate(foodChoice, new Vector3(columns - i, rows - 7, 0f), Quaternion.identity);
        }
        
    }
    
    public void SetupScene(){
        BoardSetup();
        InitialiseList();
        LayoutWalls(wallTiles, foodTiles);
        Instantiate(exit, new Vector3(columns -1, rows -1, 0f), Quaternion.identity);
    }
}
