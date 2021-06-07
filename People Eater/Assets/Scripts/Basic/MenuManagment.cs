using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagment : MonoBehaviour
{
    [SerializeField] GameObject MenuPanel;
    [SerializeField] GameObject OptionsPanel;

    // ������������ � ����� ������ � Basic: ����������� � SceneManagment
    public void ConnectToSceneManagment(int id)
    {
        SceneManagment.LoadScene(id);
    }

    // ����� � ����
    public void QuitToDesktop()
    {
        Application.Quit();
    }

    // � ������� � ��� �� �� ������� ����� �������, �� �������� � ���� ��������� ���� �����
    // ������ �������� ����� ������(������ ��� ����� � ���� ������ ��������� ����� ����� �������)

    // ������� ���� �����
    public void OptionsGameOpen()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }

    // ������� ���� �����
    public void OptionsGameClose()
    {
        OptionsPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }
}
