using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static short puntos;
    // Start is called before the first frame update
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }
}
