using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class scr : MonoBehaviour, IPointerClickHandler
{
    public string sceneName;

    // Tıklama olayını yöneten metod
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Tıklandı");
        SceneManager.LoadScene(sceneName);
    }

}
