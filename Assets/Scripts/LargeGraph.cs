using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeGraph : MonoBehaviour
{
    //Transform is what is used to manipulate the size and position of an object.
    [SerializeField]
    Transform pointPrefab = default;

    //The resolution is the number of blocks that exists in my graph.
    [SerializeField, Range(10, 100)]
    int resolution = 10;

    [SerializeField, Range(2, 10)]
    int graphRange = 2;

    void Awake()
    {
        float step = (float)graphRange / resolution; //Divides the number of blocks by the range of values
        var scale = Vector3.one * step; //Takes the size of the blocks from (1,1,1) to the step value
        var position = Vector3.zero;

        //determines the position of each block
        for (int i = 0; i < resolution; i++)
        {
            for (int j = 0; j < resolution; j++)
            {
                Transform point = Instantiate(pointPrefab);
                position.x = (i + 0.5f) * step - ((float)graphRange / 2); //sets the initial x position
                position.z = (j + 0.5f) * step - ((float)graphRange / 2); //sets the initial y position
                position.y = position.x * position.x + position.z * position.z; //sets the z position based off the x and y position
                point.localPosition = position; //sets the position relative to (0,0,0)
                point.localScale = scale; //sets the scale of each point to the scale size
                point.SetParent(transform); //Places each point under our parent object
            }
        }
    }
}
