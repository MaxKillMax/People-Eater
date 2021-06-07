using UnityEngine;

public class SpikeDeath : MonoBehaviour
{
    float Hard = StaticOptions.Difficulty / 100;
    // ��� �������� ���������� ������ ����(� ��� ��������� ��������������)
    private void Start()
    {
        this.transform.localScale = new Vector3(1 + Hard, 1 + Hard, 1 + Hard);
    }

    // ����������� �������
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "SnakeHead")
        {
            other.GetComponent<OnDeath>().DestroySnake();
        }
    }
}
