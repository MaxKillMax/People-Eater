using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagment : MonoBehaviour
{
    [SerializeField] GameObject MenuPanel;
    [SerializeField] GameObject OptionsPanel;

    // Используется в обоих сценах в Basic: связывается с SceneManagment
    public void ConnectToSceneManagment(int id)
    {
        SceneManagment.LoadScene(id);
    }

    // Выйти в меню
    public void QuitToDesktop()
    {
        Application.Quit();
    }

    // С опциями я мог бы всё сделать одним методом, но наверное в этой небольшой игре можно
    // убрать гибкость этого метода(потому что здесь в меню только настройки имеют такую функцию)

    // Открыть меню опций
    public void OptionsGameOpen()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }

    // Закрыть меню опций
    public void OptionsGameClose()
    {
        OptionsPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }
}
