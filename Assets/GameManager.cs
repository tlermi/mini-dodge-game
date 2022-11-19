using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public float slowness = 10f;

  public void EndGame ()
  {
    StartCoroutine(RestartLevel());



  }
    IEnumerator RestartLevel ()
    {
        // before 1 sec
        Time.timeScale = 1f/slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;



        yield return new WaitForSeconds(1f / slowness);


        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        
        // after 1 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );


    }


}
