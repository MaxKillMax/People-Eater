using UnityEngine;
// ����� ������ ������ ���������� ������ �������
// (� �������, ���� ���������� �� ��������, �� ��������� ������ - ������� �� ������ ���������)
public static class StaticOptions
{
    // ��� ������ ��������� �������� � ���� �������� ����� ����� Options
    public static float Difficulty = 50;
    public static float ChunkCount = 50;
    public static bool Immortality = false;

    // ��������� ����
    // ��, �� ��� ������ ��������� ����: Spike Death/Start; SnakeMove/OnCollisionEnter; SnakeMove/Update; Chunk/Create;
    public static void GetDifficulty(int Num = 50)
    {
        Difficulty = Num;
    }

    // ���������� ������ �� �����
    // (����������: ���� - ��� ������������ ������� ����� � ����������� ����������)
    // ��, �� ��� ������ ���������� ������: SpawnController/CreateNewChunk;
    public static void GetChunkCount(int Num = 50)
    {
        ChunkCount = Num;
    }

    // ����� ����������
    // (����������: ����� ��������� ������ ������ �����, � ����� ������ �� �������)
    // ��, �� ��� ������ ����� ����������: OnDeath/DestroySnake;
    public static void GetImmortality(bool Act = false)
    {
        Immortality = Act;
    }
}
