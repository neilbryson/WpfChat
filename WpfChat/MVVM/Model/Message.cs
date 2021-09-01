using System;

namespace WpfChat.MVVM.Model
{
    public class Message
    {
        public string Username { get; set; }
        public string UsernameColour { get; set; }
        public string ImageSource { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? IsFirstMessage { get; set; }
    }
}
