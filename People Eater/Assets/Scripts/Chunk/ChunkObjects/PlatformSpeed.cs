using UnityEngine;

public class PlatformSpeed : MonoBehaviour
{
    private SpawnController spawnController;
    private float Move;
    private float Speed;
    // ��������� ���������� ��������� ��� �������� �����
    public void GetInformation(SpawnController Controller, GameObject Snake, float Speed)
    {
        this.Speed = Speed;
        Move = Snake.GetComponentInChildren<SnakeMove>().Speed;
        spawnController = Controller;
    }

    // ������ �������� (�������� ���, ��� ����������� ���� ������ �������� �� ���� �����.
    // ���������� ���, ������ ��� ���� ������, ��� ��� ��� ������: � ���� ������� �� ���������)
    public void ChangeSpeed()
    {
        Move = Speed;
        print("����������� ��������: " + Speed);
    }

    // ���������� ��� PlatformCollider.cs (�� ��� ��� ��������, ��� ���� �� ������� � ������� �������� �� ����)
    public void Next()
    {
        spawnController.CreateNewChunk();
    }
}
