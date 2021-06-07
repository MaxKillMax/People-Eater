using UnityEngine;
// Метод просто раздаёт инструкции разным классам
// (к примеру, игра ускоряется со временем, но насколько быстро - зависит от уровня сложности)
public static class StaticOptions
{
    // Все методы принимают значения с меню настроек через класс Options
    public static float Difficulty = 50;
    public static float ChunkCount = 50;
    public static bool Immortality = false;

    // Сложность игры
    // Всё, на что влияет сложность игры: Spike Death/Start; SnakeMove/OnCollisionEnter; SnakeMove/Update; Chunk/Create;
    public static void GetDifficulty(int Num = 50)
    {
        Difficulty = Num;
    }

    // Количество чанков на карте
    // (Примечание: чанк - это определенный участок карты с процедурной генерацией)
    // Всё, на что влияет количество чанков: SpawnController/CreateNewChunk;
    public static void GetChunkCount(int Num = 50)
    {
        ChunkCount = Num;
    }

    // Режим бессмертия
    // (Примечание: можно подбирать шарики чужого цвета, а также ходить по спайкам)
    // Всё, на что влияет режим бессмертия: OnDeath/DestroySnake;
    public static void GetImmortality(bool Act = false)
    {
        Immortality = Act;
    }
}
