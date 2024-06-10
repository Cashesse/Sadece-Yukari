using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GoToHomeScene : MonoBehaviour, IPointerClickHandler
{
    public string sceneName;

    // Tıklama olayını yöneten metod
/*    public void OnButtonClick(PointerEventData eventData)
    {
        Debug.Log("Tıklandı");
        SceneManager.LoadScene(sceneName);
    }*/

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Tıklandı");
        SceneManager.LoadScene(sceneName);
    }

    void Start()
    {
        // Mouse imlecini görünür hale getir
        Cursor.visible = true;
        // Mouse imlecinin kilidini aç
        Cursor.lockState = CursorLockMode.None;
    }
}
