using System.Collections.ObjectModel;
using System.Linq;

namespace WpfChat.MVVM.Model
{
    public class Contact
    {
        public string Username { get; set; }
        public string ImageSource { get; set; }
        public ObservableCollection<Message> Messages { get; set; }
        public string LastMessage => Messages.Last().Content;
    }
}
