using System;

namespace Swin_Adventure
{
    public class Identifiable_Object
    {
        private List<string> _identifiers;
        public Identifiable_Object(string[] idents)
        {
            _identifiers = new List<string>();
            foreach (string s in idents)
                AddIdentifier(s);
        }
        public bool AreYou(string id)
        {
            return _identifiers.Any(_id => _id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id);
        }
        public string FirstId
        {
            get { return (_identifiers.Count == 0 ? "" : _identifiers[0]); }
        }
    }
}