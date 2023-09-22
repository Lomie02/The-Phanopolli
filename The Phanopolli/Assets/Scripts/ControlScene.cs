using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {



        //proof that our scene has resetted each time clicked the button
        print("This scene has been loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        ///Reset scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
