using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
   public void SceneInGame()
   {
        SceneManager.LoadScene("SceneInGame");

   }

    public void SceneCredit()
   {
        SceneManager.LoadScene("SceneCredit");

   }

}
