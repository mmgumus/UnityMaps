using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GroundProperties : MonoBehaviour
{
    [SerializeField]
    [Range(0.1f,10)]
    private float scaleX = 1;

    [SerializeField]
    [Range(0.1f, 10)]
    private float scaleY = 1;
    private void LateUpdate()
    {
        transform.localScale = new Vector3(scaleX, scaleY);
    }
}
