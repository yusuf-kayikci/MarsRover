using MarsRover.App.Enums;
using MarsRover.App.Exceptions;
using MarsRover.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.App.Model
{
    public class Message
    {
        private List<char> _messageText;
        public int CommandCount { get; internal set; }
        public MovementType nextMovement { get; internal set; }
        private int index = 0;


        public Message(string messageText)
        {
            var messageTextAsList = messageText.ToList();
            _messageText = messageTextAsList;
            CommandCount = messageTextAsList.Count();
        }

        public void SetNextLetter()
        {
            try
            {
                nextMovement = Enum.Parse<MovementType>(_messageText[index].ToString(), false);
                index++;
            }
            catch (Exception ex)
            {
                throw new InvalidMessageException(ex);
            }
        }



    }
}
