
using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Core.Talking
{
    public class TalkWindowManager
    {
        Dictionary<int, JamesWindow> _windows;

        public TalkWindowManager()
        {
            _windows = new();
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

            return window;
        }

        private void UnregisterWindow(int id)
        {
            _windows.Remove(id);
        }
    }
}
