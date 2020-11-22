using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaGraphScript : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    [SerializeField, Range(2, 10)]
    int graphRange = 2;

    void Awake()
    {
        float step = (float)graphRange / resolution;
        var scale = Vector3.one * step;
        var position = Vector3.zero;
        for (int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - ((float)graphRange / 2);
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform);

        }
    }
}
