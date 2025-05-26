using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnFall : MonoBehaviour
{
    public float yRespawnValue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yRespawnValue)
        {
            // Debug.Log( "Me caí : (");
            SceneManager.LoadScene("FPS Parkour");
        }
    }
}
