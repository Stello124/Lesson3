using UnityEngine;
using Zenject;

public enum LevelName
{
    Level_1
}

public class Level : MonoBehaviour
{
    [SerializeField] private LevelName levelName;
    private Board _board;
    private LevelData _currentLevelData;

    [Inject]
    public void Initialize(Board board)
    {
        _board = board;

        GetLevelData();
        PrepareBoard();
        PrepareLevel();
    }

    private void GetLevelData()
    {
        _currentLevelData = LevelDataFactory.Create(levelName);
    }

    private void PrepareBoard()
    {
        _board.Prepare(_currentLevelData.RowCount, _currentLevelData.ColCount);
    }

    private void PrepareLevel()
    {
        for (int x = 0; x < _currentLevelData.GridData.GetLength(0); x++)
        {
            for (int y = 0; y < _currentLevelData.GridData.GetLength(1); y++)
            {

            }
        }
    }
}