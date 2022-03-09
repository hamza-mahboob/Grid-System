using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridSystem : MonoBehaviour
{
    public GameObject cube;
    public GameObject player;
    private const int rows = 10, cols = 10;
    private GameObject[,] cubes;


    // Start is called before the first frame update
    void Start()
    {
        cubes = new GameObject[rows, cols];
        
        for (int i = 0; i < rows; i += 2)
        {
            for (int j = 0; j < cols; j += 2)
            {
                //instantiate cube grid
                cubes[i, j] = Instantiate(cube, new Vector3(i, 0, j), Quaternion.identity);


                //set player position to first cube
                if (i == 0 && j == 0)
                    player.transform.position = cubes[i, j].transform.position + new Vector3(0, 1, 0);
            }
        }
    }
}