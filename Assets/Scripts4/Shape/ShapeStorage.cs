/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeStorage : MonoBehaviour
{
    public List<Shape_Data> shape_data;
    public List<Shape> shapeList;

    void Start()
    {
        
        foreach (var shape in shapeList)
        {
            var shapeIndex = UnityEngine.Random.Range(0, shape_data.Count);
            shape.CreateShape(shape_data[shapeIndex]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/