using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class VerticalWallProperties : MonoBehaviour
{
    [Header("Walls")]
    public GameObject verticalWall;
    public GameObject verticalCollider;

    [Header("Scale")]
    [Range(0,10)]
    public float scaleVertical = 1;
    private void LateUpdate()
    {
        verticalWall.transform.localScale = new Vector3(1, scaleVertical + 1.2f, 1);
        verticalCollider.transform.localScale = new Vector3(1, scaleVertical + 0.415f, 1);
    }
}
