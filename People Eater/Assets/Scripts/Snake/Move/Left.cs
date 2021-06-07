using UnityEngine;
using UnityEngine.EventSystems;

// �� �� ���� ���� ������� ����� ����������: ���� ������� �������, ���� � ���.
// �� ����� ���������� � ���������, ��������� ������ �� ����� ���������� � �����

// � ������, ���� ��� �� �� ����������� ������(���� � �� ����� �������, ��� ����������� � ������� ����)
// �� ����� ��������� �� ���� � ���� ����� �� �����������
public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] SnakeMove snakeMove;
    // ����� ����� - ����� �����
    public void OnPointerDown(PointerEventData eventData)
    {
        snakeMove.LeftDown();
    }

    // ������ ����� - ��������� ���� �����(��� ������)
    public void OnPointerUp(PointerEventData eventData)
    {
        snakeMove.LeftUp();
    }
}
