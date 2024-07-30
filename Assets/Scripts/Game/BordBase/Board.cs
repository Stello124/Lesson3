using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Board : MonoBehaviour
{
    [Inject] Cell.CellFactory _cellFactory;
    public int Rows {  get; private set; }
    public int Cols {  get; private set; }
    public Cell[,] Cells {  get; private set; }
}
