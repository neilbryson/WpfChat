using System;
using System.Collections.ObjectModel;
using WpfChat.MVVM.Model;

namespace WpfChat.MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Message> Messages { get; set; }
        public ObservableCollection<Contact> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<Message>();
            Contacts = new ObservableCollection<Contact>();

            for (var i = 0; i < 4; i++)
            {
                Messages.Add(new Message
                {
                    Username = Faker.Name.FullName(),
                    UsernameColour = "#409AFF",
                    ImageSource = "https://i.pinimg.com/474x/c4/7a/b1/c47ab18aa9246a6c16c7619b41a536fd.jpg",
                    Content = Faker.Company.CatchPhrase(),
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                    IsFirstMessage = i == 0,
                });
            }

            for (var i = 0; i < 4; i++)
            {
                Contacts.Add(new Contact
                {
                    Username = Faker.Name.FullName(),
                    ImageSource = "https://i.pinimg.com/474x/c4/7a/b1/c47ab18aa9246a6c16c7619b41a536fd.jpg",
                    Messages = Messages,
                });
            }
        }
    }
}
