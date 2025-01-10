using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrePosition : MonoBehaviour
{
    public static Dictionary<string, Vector2> scenePosPre = new();

    private void OnDestroy()
    {
        if (!scenePosPre.ContainsKey(SceneManager.GetActiveScene().name))
            scenePosPre.Add(SceneManager.GetActiveScene().name, transform.position);
        else
            scenePosPre[SceneManager.GetActiveScene().name] = transform.position;

        Debug.Log($"Storing position in scene {SceneManager.GetActiveScene().name} at {transform.position}");
    }
}
