using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuGrid : MonoBehaviour
{
    public int columns = 0;
    public int rows = 0;
    public float square_offset = 0.0f;
    public GameObject grid_square;  //"our prefab"
    public Vector2 start_position = new Vector2(0.0f, 0.0f);
    public float square_scale = 1.0f;

    private List<GameObject> grid_squares = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        if (grid_square.GetComponent<GridSquare>() == null)
            Debug.LogError("This Game Object needs to have Gr "); //"this check id our prefab has gridsquare script attahced"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
