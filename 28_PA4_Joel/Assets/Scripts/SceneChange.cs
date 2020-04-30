using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneChanger());
    }
    private void Update()
    {
        
    }

    IEnumerator SceneChanger()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CubeScene");
    }

}
