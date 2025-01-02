

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Core.Talking
{
    public class TalkWindowManager
    {
        private Dictionary<string, JamesWindow> _windows = new();
        public event EventHandler? WindowCountChanged;

        public TalkWindowManager()
        {

        }

        public List<KeyValuePair<string, JamesWindow>> GetAllWindows()
        {
            return _windows.ToList();
        }

        private void UnregisterWindow(string id)
        {
            _windows.Remove(id);
            WindowCountChanged?.Invoke(this, EventArgs.Empty);
        }

        public T ResolveWindow<T>(string id) where T : JamesWindow, new()
        {
            if (_windows.ContainsKey(id))
            {
                return (T)_windows[id];
            }
            var window = new T();
            window.Closed += (s, e) => UnregisterWindow(id);
            _windows.Add(id, window);
            WindowCountChanged?.Invoke(this, EventArgs.Empty);
            return window;
        }


    }
}
