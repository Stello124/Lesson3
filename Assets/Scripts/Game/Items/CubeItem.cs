using Zenject;

namespace Game.Items
{
    public class CubeItem : Item
    {
        [Inject] ImageLibService _imageLibService;
        private MatchType _matchType;

        public void Prepare(ItemBase itemBase, MatchType matchType, ItemType itemType)
        {

        }
    }
}