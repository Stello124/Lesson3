using System;
using UnityEngine;
using Zenject;

namespace Game.Items
{
    public class CubeItem : Item
    {
        [Inject] ImageLibService _imageLibService;
        private MatchType _matchType;

        public void Prepare(ItemBase itemBase, MatchType matchType, ItemType itemType)
        {
            ItemType = itemType;
            _matchType = matchType;
            Init(itemBase, GetSpriteForMatchType());
        }

        private Sprite GetSpriteForMatchType()
        {
            switch (_matchType)
            {
                case MatchType.None:
                    break;
                case MatchType.Green:
                    return _imageLibService.Images.greenCube;
                case MatchType.Yellow:
                    return _imageLibService.Images.yellowCube;
                case MatchType.Blue:
                    return _imageLibService.Images.blueCube;
                case MatchType.Red:
                    return _imageLibService.Images.redCube;
                case MatchType.Pink:
                    return _imageLibService.Images.pinkCube;
                case MatchType.Purple:
                    return _imageLibService.Images.purpleCube;
                case MatchType.SpecialType:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return null;
        }
    }
}