using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class HorizontalWallProperties : MonoBehaviour
{
    [Header("Walls")]
    public GameObject horizontalWall;

    [Header("Scale")]
    [Range(0.5f, 10)]
    public float scaleHorizontalX = 1;


    private void LateUpdate()
    {
        horizontalWall.transform.localScale = new Vector3(scaleHorizontalX, 1, 1);
    }
}
