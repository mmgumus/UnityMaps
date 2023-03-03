using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(CustomizeWalls))]
public class CustomColors : Editor
{
    
    public override void OnInspectorGUI()
    {
        CustomizeWalls customize = (CustomizeWalls)target;

        customize.Ground = EditorGUILayout.ColorField("Ground", customize.Ground);
        customize.Walls = EditorGUILayout.ColorField("Walls", customize.Walls);
        customize.BorderWalls = EditorGUILayout.ColorField("Border Walls", customize.BorderWalls);
        customize.DoorFrame = EditorGUILayout.ColorField("Door Frame", customize.DoorFrame);
        customize.SetWallColors();

        if (GUI.changed)
        {
            EditorUtility.SetDirty(customize);
            EditorSceneManager.MarkSceneDirty(customize.gameObject.scene);
        }
    }
}
