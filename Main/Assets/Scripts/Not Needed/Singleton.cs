using UnityEngine;
using System.Collections;

public class Singleton<GameManager> : MonoBehaviour where GameManager : MonoBehaviour
{

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            // Check if the instance is null.
            if (_instance == null)
            {
                // First try to find the object already in the scene.
                _instance = GameObject.FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    // Couldn't find the singleton in the scene, so make it.
                    GameObject singleton = new GameObject(typeof(GameManager).Name);
                    _instance = singleton.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }


}
