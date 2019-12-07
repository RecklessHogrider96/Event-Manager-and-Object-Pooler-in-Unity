using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject MENU_UI;
    public GameObject GAME_ROOT;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(MENU_UI, this.transform);
        Instantiate(GAME_ROOT, this.transform);
    }
    
}
