using System;
using System.Threading;

namespace Thread1
{
    class Messenger
    {

        private readonly string _message;
        private bool _cancel;

        public Messenger(string message)
        {
            _message = message;
            _cancel = false;
        }

        public void Cancel()
        {
            _cancel = true;
        }

        public void ShowMessage()
        {
            while (!_cancel)
            {
                Console.WriteLine(_message);
                Thread.Sleep(1000);
            }
        }
    }
}
