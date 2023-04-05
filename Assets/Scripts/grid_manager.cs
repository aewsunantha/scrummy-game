using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class grid_manager : MonoBehaviour
{
    [SerializeField]
    private int rows = 12;
    [SerializeField]
    private int cols = 32;
    [SerializeField]
    private float tile_size = 1;



    // Start is called before the first frame update
    void Start()
    {
        generate_grid();
    }

    private void generate_grid()
    {
        GameObject referenece_tile = Resources.Load("grid", typeof(GameObject)) as GameObject;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {

                GameObject tile = (GameObject)Instantiate(referenece_tile, transform);
                float x = col * tile_size;
                float y = row * -tile_size;

                tile.transform.position = new Vector2(x, y);
            }
        }
        Destroy(referenece_tile);

        float w = cols * tile_size;
        float h = rows * tile_size;

        transform.position = new Vector2(-w / 2 + tile_size / 2, h / 2 - tile_size / 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

