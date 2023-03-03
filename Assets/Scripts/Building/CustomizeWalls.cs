using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[System.Serializable]
public class CustomizeWalls : MonoBehaviour
{
    private Transform[] childs;
    [HideInInspector]
    public Color Ground = Color.white;
    [HideInInspector]
    public Color Walls = Color.white;
    [HideInInspector]
    public Color BorderWalls = Color.white;
    [HideInInspector]
    public Color DoorFrame = Color.white;
    private void LateUpdate()
    {
        childs = gameObject.GetComponentsInChildren<Transform>();
    }
    public void SetWallColors()
    {
        foreach (Transform child in childs)
        {
            if (child.gameObject.tag == "Ground")
            {
                child.gameObject.GetComponent<SpriteRenderer>().color = Ground;
            }
            if (child.gameObject.tag == "Walls")
            {
                child.gameObject.GetComponent<SpriteRenderer>().color = Walls;
            }
            if (child.gameObject.tag == "BorderWalls")
            {
                child.gameObject.GetComponent<SpriteRenderer>().color = BorderWalls;
            }
            if (child.gameObject.tag == "DoorFrame")
            {
                child.gameObject.GetComponent<SpriteRenderer>().color = DoorFrame;
            }
        }
    }
}
