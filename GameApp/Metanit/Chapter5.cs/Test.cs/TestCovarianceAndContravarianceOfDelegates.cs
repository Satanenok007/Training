using System;

namespace TestCovarianceAndContravarianceOfDelegates
{
    class C1
    {
        delegate Message MessageBuilder(string text);
        delegate void EmailReceiver(EmailMessage message);
        delegate T MessageBuilder<out T>(string text);
        static void F1()
        {
            MessageBuilder obj1 = WriteEmailMessage;
            Message ob1 = obj1("1");
            ob1.Print();
            EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);


            EmailReceiver obj2 = ReceiveMessage;
            obj2(new EmailMessage("2"));
            void ReceiveMessage(Message message) => message.Print();


            MessageBuilder<Message> obj3 = WriteEmailMessage;
            Message ob3 = obj3("3");
            ob3.Print();
        }
    }

    class Message
    {
        public string Text { get; }
        public Message(string text) => Text = text;
        public virtual void Print() => Console.WriteLine($"Message: {Text}");
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
        public override void Print() => Console.WriteLine($"Email: {Text}");
    }
    class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text) { }
        public override void Print() => Console.WriteLine($"Sms: {Text}");
    }
}