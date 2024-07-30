using TMPro;
using UnityEngine;
using Zenject;

public class Cell : MonoBehaviour
{
    [SerializeField] private TextMeshPro labelText;
    public int X {  get; private set; }
    public int Y {  get; private set; }
    public ListPool<Cell> Neighbors { get; private set; } = new();

    public void Prepare(int x, int y)
    {
        X = x; 
        Y = y; 

        transform.localPosition = new Vector3(X, Y);
        SetLabel();
    }

    private void SetLabel()
    {
        var cellName = $"{X} : {Y}";
        labelText.text = cellName;
        gameObject.name = $"Cell {cellName}";
    }


    public class CellFactory : PlaceholderFactory<Cell> { }
}