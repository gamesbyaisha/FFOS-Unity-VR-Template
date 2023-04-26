using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
 
 
public class LoadScene : MonoBehaviour {
 
     void Awake()
     {
        DontDestroyOnLoad(this.gameObject);
     }
   
    void Start()
    {
        StartCoroutine (Wait());
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds (10);  // wait for 10 sec, then do whats under it.
        Debug.Log("wait complete");
        SceneManager.LoadScene ("Portal");
        Debug.Log("scene loaded");
    }
}