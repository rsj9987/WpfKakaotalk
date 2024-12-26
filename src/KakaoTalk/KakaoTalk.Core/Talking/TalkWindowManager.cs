

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Core.Talking
{
    public class TalkWindowManager
    {
        private Dictionary<int, JamesWindow> _windows = new();
        public event EventHandler? WindowCountChanged;

        public TalkWindowManager()
        {

        }

        public List<KeyValuePair<int, JamesWindow>> GetAllWindows()
        {
            return _windows.ToList();
        }

        private void UnregisterWindow(int id)
        {
            _windows.Remove(id);
            WindowCountChanged?.Invoke(this, EventArgs.Empty);
        }

        public T ResolveWindow<T>(int id) where T : JamesWindow, new()
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
