using System;
using System.Collections.ObjectModel;
using System.Windows.Automation;
using WpfChat.Core;
using WpfChat.MVVM.Model;

namespace WpfChat.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<Message> Messages { get; set; }
        public ObservableCollection<Contact> Contacts { get; set; }

        public RelayCommand SendCommand { get; set; }

        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _messageText;

        public string MessageText
        {
            get { return _messageText; }
            set
            {
                _messageText = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<Message>();
            Contacts = new ObservableCollection<Contact>();
            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new Message
                {
                    Content = MessageText,
                    IsFirstMessage = false
                });

                MessageText = "";
            });

            var fromUser = Faker.Name.FullName();
            const string fromUserColour = "#409AFF";

            for (var i = 0; i < 4; i++)
            {
                Messages.Add(new Message
                {
                    Username = fromUser,
                    UsernameColour = fromUserColour,
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
