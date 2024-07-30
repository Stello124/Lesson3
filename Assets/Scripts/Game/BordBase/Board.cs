using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Board : MonoBehaviour
{
    [Inject] Cell.CellFactory cellFactory;
}
