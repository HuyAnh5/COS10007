using Swin_Adventure;

namespace Swin_Adventure
{
    public abstract class Game_Object : Identifiable_Object
    {
        private string _name, _description;

        public Game_Object(string[] ids, string name, string desc)
            : base(ids)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get { return _name; }
        }

        public string ShortDescription
        {
            get { return $"a {_name} ({FirstId})"; }
        }

        public virtual string FullDescription
        {
            get { return _description; }
        }
    }
}