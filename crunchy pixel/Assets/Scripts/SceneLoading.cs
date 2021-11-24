using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(3);
    }

}
