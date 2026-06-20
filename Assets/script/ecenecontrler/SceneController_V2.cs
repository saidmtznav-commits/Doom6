using UnityEngine;
using System.Collections;
using UnityEngine.Events;
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Animator Fade;
    [SerializeField]
    private UnityEvent onSceneStart;
    private void Start()
    {
        onSceneStart?.Invoke();
    }
    
public void LoadScene (string sceneName)
    
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneWithFade (string sceneName)
   
    {
         StartCoroutine(LoadSceneWithFadeCoroutine(sceneName));

    }
    private IEnumerator LoadSceneWithFadeCoroutine(string sceneName)
    {
    
      Fade.Play("FadeOut");
      yield return new WaitForSeconds(Fade.GetCurrentAnimatorStateInfo(0).length);
      LoadScene(sceneName);
    }

}
