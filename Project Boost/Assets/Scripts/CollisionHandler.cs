using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other){

        switch(other.gameObject.tag){

            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("Next Level");
                break;
            case "Fuel":
                Debug.Log("Fuel acquired");
                break;
            default:
                ReloadLevel();
                break;

        }

    }


    void ReloadLevel(){

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;   
        SceneManager.LoadScene(currentSceneIndex);


    }
}
