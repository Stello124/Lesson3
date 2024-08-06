using UnityEngine;

namespace Game.Services
{
    [CreateAssetMenu(fileName = "ImageData", menuName = "Scriptable Objects/ImageData")]
    public class ImageDataSO : ScriptableObject
    {
        [Header("Red Cubes")]
        [SerializeField] private Sprite redCube;
        [SerializeField] private Sprite redCubeRocket;
        [SerializeField] private Sprite redCubeBomb;
        [SerializeField] private Sprite redCubeDisco;

        [Space, Header("Green Cubes")]
        [SerializeField] private Sprite greenCube;
        [SerializeField] private Sprite greenCubeRocket;
        [SerializeField] private Sprite greenCubeBomb;
        [SerializeField] private Sprite greenCubeDisco;

        [Space, Header("Blue Cubes")]
        [SerializeField] private Sprite blueCube;
        [SerializeField] private Sprite blueCubeRocket;
        [SerializeField] private Sprite blueCubeBomb;
        [SerializeField] private Sprite blueCubeDisco;

        [Space, Header("Yellow Cubes")]
        [SerializeField] private Sprite yellowCube;
        [SerializeField] private Sprite yellowCubeRocket;
        [SerializeField] private Sprite yellowCubeBomb;
        [SerializeField] private Sprite yellowCubeDisco;

        [Space, Header("Pink Cubes")]
        [SerializeField] private Sprite pinkCube;
        [SerializeField] private Sprite pinkCubeRocket;
        [SerializeField] private Sprite pinkCubeBomb;
        [SerializeField] private Sprite pinkCubeDisco;

        [Space, Header("Purple Cubes")]
        [SerializeField] private Sprite purpleCube;
        [SerializeField] private Sprite purpleCubeRocket;
        [SerializeField] private Sprite purpleCubeBomb;
        [SerializeField] private Sprite purpleCubeDisco;

        [Space, Header("Balloons")]
        [SerializeField] private Sprite balloon;
        [SerializeField] private Sprite balloonGreen;
        [SerializeField] private Sprite balloonRed;
        [SerializeField] private Sprite balloonBlue;
        [SerializeField] private Sprite balloonYellow;
        [SerializeField] private Sprite balloonPink;
        [SerializeField] private Sprite balloonPurple;

        [Space, Header("Creates")]
        [SerializeField] private Sprite createLayer1;
        [SerializeField] private Sprite createLayer2;

        [Space, Header("Rockets")]
        [SerializeField] private Sprite rocketVertical;
        [SerializeField] private Sprite rocketHorizontal;

        [Space, Header("Bomb")]
        [SerializeField] private Sprite bomb;

        [Space, Header("Disco")]
        [SerializeField] private Sprite disco;
    }
}